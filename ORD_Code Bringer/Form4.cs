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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            string target = "";
            if (btn.Text == "거프")
                target = "garp im";
            else if (btn.Text == "로져")
                target = "roger im";
            else if (btn.Text == "흰수염")
                target = "whitebeard im";
            else if (btn.Text == "레일리")
                target = "rayleigh im";
            else if (btn.Text == "가반")
                target = "gaban im";
            else if (btn.Text == "카이도우")
                target = "kaido im";
            else if (btn.Text == "금사자 시키")
                target = "shiki im";
            else if (btn.Text == "버기")
                target = "buggy et";
            else if (btn.Text == "해적환자")
                target = "cavendish et";
            else if (btn.Text == "미호크")
                target = "mihawk et";
            else if (btn.Text == "비비")
                target = "vivi et";
            else if (btn.Text == "에이스")
                target = "ace et";
            else if (btn.Text == "오뎅")
                target = "oden et";
            else if (btn.Text == "핸콕")
                target = "hancock et";
            else if (btn.Text == "빅맘")
                target = "bigmam im";
            else if (btn.Text == "드래곤")
                target = "dragon im";
            else if (btn.Text == "센고쿠")
                target = "sengoku im";
            else if (btn.Text == "제트")
                target = "z im";
            else return;

            Clipboard.SetDataObject(target, true);
        }
    }
}
