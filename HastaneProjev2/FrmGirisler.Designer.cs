namespace HastaneProjev2
{
    partial class FrmGirisler
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
			this.BtnHastaGiris = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnDoktorGiris = new System.Windows.Forms.Button();
			this.BtnSekreterGiris = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnHastaGiris
			// 
			this.BtnHastaGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHastaGiris.BackgroundImage")));
			this.BtnHastaGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnHastaGiris.Location = new System.Drawing.Point(46, 176);
			this.BtnHastaGiris.Name = "BtnHastaGiris";
			this.BtnHastaGiris.Size = new System.Drawing.Size(143, 112);
			this.BtnHastaGiris.TabIndex = 0;
			this.BtnHastaGiris.UseVisualStyleBackColor = true;
			this.BtnHastaGiris.Click += new System.EventHandler(this.BtnHastaGiris_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(85, 306);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Hasta";
			// 
			// BtnDoktorGiris
			// 
			this.BtnDoktorGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoktorGiris.BackgroundImage")));
			this.BtnDoktorGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnDoktorGiris.Location = new System.Drawing.Point(210, 176);
			this.BtnDoktorGiris.Name = "BtnDoktorGiris";
			this.BtnDoktorGiris.Size = new System.Drawing.Size(143, 112);
			this.BtnDoktorGiris.TabIndex = 4;
			this.BtnDoktorGiris.UseVisualStyleBackColor = true;
			this.BtnDoktorGiris.Click += new System.EventHandler(this.BtnDoktorGiris_Click);
			// 
			// BtnSekreterGiris
			// 
			this.BtnSekreterGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSekreterGiris.BackgroundImage")));
			this.BtnSekreterGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnSekreterGiris.Location = new System.Drawing.Point(374, 176);
			this.BtnSekreterGiris.Name = "BtnSekreterGiris";
			this.BtnSekreterGiris.Size = new System.Drawing.Size(143, 112);
			this.BtnSekreterGiris.TabIndex = 5;
			this.BtnSekreterGiris.UseVisualStyleBackColor = true;
			this.BtnSekreterGiris.Click += new System.EventHandler(this.BtnSekreterGiris_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(250, 306);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Doktor";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(409, 306);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Sekreter";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(312, 40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(205, 107);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(24, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(282, 50);
			this.label4.TabIndex = 9;
			this.label4.Text = "Duman Hospital";
			// 
			// FrmGirisler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.SeaGreen;
			this.ClientSize = new System.Drawing.Size(568, 356);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BtnSekreterGiris);
			this.Controls.Add(this.BtnDoktorGiris);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnHastaGiris);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmGirisler";
			this.Text = "Duman";
			this.Load += new System.EventHandler(this.FrmGirisler_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHastaGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDoktorGiris;
        private System.Windows.Forms.Button BtnSekreterGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

