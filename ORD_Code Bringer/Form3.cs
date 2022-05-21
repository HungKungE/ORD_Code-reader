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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            string target = "";
            if (btn.Text == "도플라밍고")
                target = "joker tr";
            else if (btn.Text == "로빈")
                target = "robin tr";
            else if (btn.Text == "루피")
                target = "luffy tr";
            else if (btn.Text == "바질")
                target = "hawkins tr";
            else if (btn.Text == "사보")
                target = "sabo tr";
            else if (btn.Text == "우솝")
                target = "usopp tr";
            else if (btn.Text == "야마토")
                target = "yamato tr";
            else if (btn.Text == "조로")
                target = "zoro tr";
            else if (btn.Text == "징베")
                target = "jinbe tr";
            else if (btn.Text == "쵸파")
                target = "chopper tr";
            else if (btn.Text == "후지토라")
                target = "fujitora tr";
            else if (btn.Text == "검은수염")
                target = "tichi tr";
            else if (btn.Text == "나미")
                target = "nami tr";
            else if (btn.Text == "로우")
                target = "law tr";
            else if (btn.Text == "루치")
                target = "lucci tr";
            else if (btn.Text == "루피(오황)")
                target = "snakeman tr";
            else if (btn.Text == "상디")
                target = "sanji tr";
            else if (btn.Text == "샹크스")
                target = "shanks tr";
            else if (btn.Text == "시라호시")
                target = "shirahoshi tr";
            else if (btn.Text == "아카이누")
                target = "akainu tr";
            else if (btn.Text == "브룩")
                target = "brook tr";
            else if (btn.Text == "프랑키")
                target = "franky tr";
            else if (btn.Text == "키드")
                target = "kid tr";
            else if (btn.Text == "키자루")
                target = "kizaru tr";
            else if (btn.Text == "아오키지")
                target = "aokiji tr";
            else if (btn.Text == "타시기")
                target = "tashigi tr";
            else return;

            Clipboard.SetDataObject(target, true);
        }
    }
}
