using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORD_Code_Bringer
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            etc_btn.Enabled = false;
        }

        private void hidden_btn_Click(object sender, EventArgs e)
        {
            Form2 hidden = new Form2();
            hidden.StartPosition = FormStartPosition.Manual;
            hidden.Location = new Point(this.Location.X + 260, Location.Y);
            hidden.Show();
        }

        private void tr_btn_Click(object sender, EventArgs e)
        {
            Form3 tr = new Form3();
            tr.StartPosition = FormStartPosition.Manual;
            tr.Location = new Point(this.Location.X + 260, Location.Y);
            tr.Show();
        }

        private void im_btn_Click(object sender, EventArgs e)
        {
            Form4 im = new Form4();
            im.StartPosition = FormStartPosition.Manual;
            im.Location = new Point(this.Location.X + 260, Location.Y);
            im.Show();
        }

        private void option_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
