using System;
using System.IO;
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
    public partial class Form1 : Form
    {
        string directory;
        public Form1()
        {
            InitializeComponent();
            save_btn.Enabled = false;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int max = 0;
                directory = textBox1.Text;
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(directory);

                foreach (System.IO.FileInfo file in di.GetFiles())
                {
                    if (file.Extension.ToLower().CompareTo(".txt") == 0)
                    {
                        string file_name = file.Name.Replace("ord10_" + name_txtBox.Text + "_", "");
                        int file_num = int.Parse(file_name.Replace(".txt", ""));
                        if (max < file_num) max = file_num;
                    }
                }

                string full_path = directory + "\\ord10_" + name_txtBox.Text + "_" + max.ToString() + ".txt";

                var txtValue = System.IO.File.ReadAllLines(full_path);
                var target = txtValue[5];
                target = target.Replace("\tcall Preload( \"", "");
                target = target.Replace("\" )", "");


                Clipboard.SetDataObject(target, true);
            }
            catch (FormatException ex) { MessageBox.Show("잘못된 닉네임 or 잘못된 경로입니다!"); }
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
            FolderBrowserDialog a = new FolderBrowserDialog();
            if (a.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = a.SelectedPath;
                save_btn.Enabled = true;
            }
        }

        private void etc_btn_Click(object sender, EventArgs e)
        {
            Form5 etc = new Form5();
            etc.StartPosition = FormStartPosition.Manual;
            etc.Location = new Point(this.Location.X + 260, Location.Y);
            etc.Show();
        }

        private void combine_btn_Click(object sender, EventArgs e)
        {
            Form6 combine = new Form6();
            combine.StartPosition = FormStartPosition.Manual;
            combine.Location = new Point(this.Location.X + 260, Location.Y);
            combine.Show();
        }
    }
}