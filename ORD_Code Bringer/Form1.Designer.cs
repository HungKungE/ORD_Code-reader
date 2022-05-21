namespace ORD_Code_Bringer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.save_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.option_btn = new System.Windows.Forms.Button();
            this.combine_btn = new System.Windows.Forms.Button();
            this.name_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(14, 64);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(218, 46);
            this.save_btn.TabIndex = 0;
            this.save_btn.Text = "세이브 코드";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(59, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(173, 21);
            this.textBox1.TabIndex = 4;
            // 
            // option_btn
            // 
            this.option_btn.Location = new System.Drawing.Point(238, 10);
            this.option_btn.Name = "option_btn";
            this.option_btn.Size = new System.Drawing.Size(66, 46);
            this.option_btn.TabIndex = 6;
            this.option_btn.Text = "경로 설정";
            this.option_btn.UseVisualStyleBackColor = true;
            this.option_btn.Click += new System.EventHandler(this.option_btn_Click);
            // 
            // combine_btn
            // 
            this.combine_btn.Location = new System.Drawing.Point(238, 64);
            this.combine_btn.Name = "combine_btn";
            this.combine_btn.Size = new System.Drawing.Size(66, 46);
            this.combine_btn.TabIndex = 7;
            this.combine_btn.Text = "조 합";
            this.combine_btn.UseVisualStyleBackColor = true;
            this.combine_btn.Click += new System.EventHandler(this.combine_btn_Click);
            // 
            // name_txtBox
            // 
            this.name_txtBox.Location = new System.Drawing.Point(59, 10);
            this.name_txtBox.Name = "name_txtBox";
            this.name_txtBox.Size = new System.Drawing.Size(173, 21);
            this.name_txtBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "닉네임";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "경로";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 120);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_txtBox);
            this.Controls.Add(this.combine_btn);
            this.Controls.Add(this.option_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.save_btn);
            this.Location = new System.Drawing.Point(1400, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "code & command";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button option_btn;
        private System.Windows.Forms.Button combine_btn;
        private System.Windows.Forms.TextBox name_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

