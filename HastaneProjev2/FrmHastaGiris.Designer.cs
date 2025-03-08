namespace HastaneProjev2
{
    partial class FrmHastaGiris
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.MskTC = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtSifre = new System.Windows.Forms.TextBox();
			this.LnkUyeOl = new System.Windows.Forms.LinkLabel();
			this.BtnGirisYap = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(63, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(314, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hasta Giriş Paneli";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(68, 86);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "TC Kimlik No: ";
			// 
			// MskTC
			// 
			this.MskTC.Location = new System.Drawing.Point(205, 83);
			this.MskTC.Margin = new System.Windows.Forms.Padding(4);
			this.MskTC.Mask = "00000000000";
			this.MskTC.Name = "MskTC";
			this.MskTC.Size = new System.Drawing.Size(136, 32);
			this.MskTC.TabIndex = 1;
			this.MskTC.ValidatingType = typeof(int);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(139, 127);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "Şifre: ";
			// 
			// TxtSifre
			// 
			this.TxtSifre.Location = new System.Drawing.Point(205, 124);
			this.TxtSifre.Margin = new System.Windows.Forms.Padding(4);
			this.TxtSifre.Name = "TxtSifre";
			this.TxtSifre.Size = new System.Drawing.Size(136, 32);
			this.TxtSifre.TabIndex = 2;
			this.TxtSifre.UseSystemPasswordChar = true;
			// 
			// LnkUyeOl
			// 
			this.LnkUyeOl.AutoSize = true;
			this.LnkUyeOl.Location = new System.Drawing.Point(372, 132);
			this.LnkUyeOl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LnkUyeOl.Name = "LnkUyeOl";
			this.LnkUyeOl.Size = new System.Drawing.Size(66, 24);
			this.LnkUyeOl.TabIndex = 5;
			this.LnkUyeOl.TabStop = true;
			this.LnkUyeOl.Text = "Üye Ol";
			this.LnkUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkUyeOl_LinkClicked);
			// 
			// BtnGirisYap
			// 
			this.BtnGirisYap.Location = new System.Drawing.Point(248, 164);
			this.BtnGirisYap.Margin = new System.Windows.Forms.Padding(4);
			this.BtnGirisYap.Name = "BtnGirisYap";
			this.BtnGirisYap.Size = new System.Drawing.Size(93, 30);
			this.BtnGirisYap.TabIndex = 3;
			this.BtnGirisYap.Text = "Giriş Yap";
			this.BtnGirisYap.UseVisualStyleBackColor = true;
			this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
			// 
			// FrmHastaGiris
			// 
			this.AcceptButton = this.BtnGirisYap;
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.SeaGreen;
			this.ClientSize = new System.Drawing.Size(552, 244);
			this.Controls.Add(this.BtnGirisYap);
			this.Controls.Add(this.LnkUyeOl);
			this.Controls.Add(this.TxtSifre);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.MskTC);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "FrmHastaGiris";
			this.Text = "Hasta Giriş";
			this.Load += new System.EventHandler(this.FrmHastaGiris_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.LinkLabel LnkUyeOl;
        private System.Windows.Forms.Button BtnGirisYap;
    }
}