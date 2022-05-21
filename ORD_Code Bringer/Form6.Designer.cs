namespace ORD_Code_Bringer
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.etc_btn = new System.Windows.Forms.Button();
            this.im_btn = new System.Windows.Forms.Button();
            this.tr_btn = new System.Windows.Forms.Button();
            this.hidden_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etc_btn
            // 
            this.etc_btn.Location = new System.Drawing.Point(130, 64);
            this.etc_btn.Name = "etc_btn";
            this.etc_btn.Size = new System.Drawing.Size(113, 46);
            this.etc_btn.TabIndex = 11;
            this.etc_btn.Text = "기타";
            this.etc_btn.UseVisualStyleBackColor = true;
            this.etc_btn.Click += new System.EventHandler(this.option_btn_Click);
            // 
            // im_btn
            // 
            this.im_btn.Location = new System.Drawing.Point(12, 64);
            this.im_btn.Name = "im_btn";
            this.im_btn.Size = new System.Drawing.Size(113, 46);
            this.im_btn.TabIndex = 10;
            this.im_btn.Text = "불멸 | 영원";
            this.im_btn.UseVisualStyleBackColor = true;
            this.im_btn.Click += new System.EventHandler(this.im_btn_Click);
            // 
            // tr_btn
            // 
            this.tr_btn.Location = new System.Drawing.Point(131, 12);
            this.tr_btn.Name = "tr_btn";
            this.tr_btn.Size = new System.Drawing.Size(113, 46);
            this.tr_btn.TabIndex = 9;
            this.tr_btn.Text = "초월 조합";
            this.tr_btn.UseVisualStyleBackColor = true;
            this.tr_btn.Click += new System.EventHandler(this.tr_btn_Click);
            // 
            // hidden_btn
            // 
            this.hidden_btn.Location = new System.Drawing.Point(12, 12);
            this.hidden_btn.Name = "hidden_btn";
            this.hidden_btn.Size = new System.Drawing.Size(113, 46);
            this.hidden_btn.TabIndex = 8;
            this.hidden_btn.Text = "히든 조합";
            this.hidden_btn.UseVisualStyleBackColor = true;
            this.hidden_btn.Click += new System.EventHandler(this.hidden_btn_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 123);
            this.Controls.Add(this.etc_btn);
            this.Controls.Add(this.im_btn);
            this.Controls.Add(this.tr_btn);
            this.Controls.Add(this.hidden_btn);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button etc_btn;
        private System.Windows.Forms.Button im_btn;
        private System.Windows.Forms.Button tr_btn;
        private System.Windows.Forms.Button hidden_btn;
    }
}