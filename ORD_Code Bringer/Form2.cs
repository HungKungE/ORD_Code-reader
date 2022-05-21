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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            string target = "";
            if (btn.Text == "")
                target = "";
            else if (btn.Text == "사보")
                target = "sabo";
            else if (btn.Text == "베르고")
                target = "vergo";
            else if (btn.Text == "킬러")
                target = "killer";
            else if (btn.Text == "미호크")
                target = "mihawk";
            else if (btn.Text == "레베카")
                target = "rebecca";
            else if (btn.Text == "코알라")
                target = "koala";
            else if (btn.Text == "시류")
                target = "shiryu";
            else if (btn.Text == "킨에몬")
                target = "kinemon";
            else if (btn.Text == "류마")
                target = "ryuma";
            else if (btn.Text == "아카이누")
                target = "akainu";
            else if (btn.Text == "캐럿")
                target = "carrot";
            else if (btn.Text == "페로나")
                target = "perona";
            else if (btn.Text == "이완코브")
                target = "ivankov";
            else if (btn.Text == "봉쿠레")
                target = "bonkurei";
            else if (btn.Text == "피셔타이거")
                target = "tiger";
            else if (btn.Text == "아오키지")
                target = "aokiji";
            else if (btn.Text == "레드포스호")
                target = "redforce";
            else if (btn.Text == "반더데켄")
                target = "decken";
            else if (btn.Text == "방주맥심")
                target = "maxim";
            else if (btn.Text == "모비딕호")
                target = "mobydick";
            else if (btn.Text == "발라티에")
                target = "baratie";
            else if (btn.Text == "써니호")
                target = "sunny";

            Clipboard.SetDataObject(target, true);
        }
    }
}
