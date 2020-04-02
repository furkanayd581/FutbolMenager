namespace Futbolmenager2
{
    partial class KullaniciAnasayfa
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
            this.btnTakım = new System.Windows.Forms.Button();
            this.btnoyuncular = new System.Windows.Forms.Button();
            this.btntransfer = new System.Windows.Forms.Button();
            this.btnacıkarttırma = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbltakımadı = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTakım
            // 
            this.btnTakım.BackColor = System.Drawing.Color.Coral;
            this.btnTakım.Location = new System.Drawing.Point(334, 30);
            this.btnTakım.Name = "btnTakım";
            this.btnTakım.Size = new System.Drawing.Size(159, 57);
            this.btnTakım.TabIndex = 0;
            this.btnTakım.Text = "Takım";
            this.btnTakım.UseVisualStyleBackColor = false;
            this.btnTakım.Click += new System.EventHandler(this.BtnTakım_Click);
            // 
            // btnoyuncular
            // 
            this.btnoyuncular.BackColor = System.Drawing.Color.Coral;
            this.btnoyuncular.Location = new System.Drawing.Point(334, 157);
            this.btnoyuncular.Name = "btnoyuncular";
            this.btnoyuncular.Size = new System.Drawing.Size(159, 57);
            this.btnoyuncular.TabIndex = 2;
            this.btnoyuncular.Text = "Oyuncular";
            this.btnoyuncular.UseVisualStyleBackColor = false;
            this.btnoyuncular.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btntransfer
            // 
            this.btntransfer.BackColor = System.Drawing.Color.Coral;
            this.btntransfer.Location = new System.Drawing.Point(334, 220);
            this.btntransfer.Name = "btntransfer";
            this.btntransfer.Size = new System.Drawing.Size(159, 57);
            this.btntransfer.TabIndex = 3;
            this.btntransfer.Text = "Transfer Listesi";
            this.btntransfer.UseVisualStyleBackColor = false;
            // 
            // btnacıkarttırma
            // 
            this.btnacıkarttırma.BackColor = System.Drawing.Color.Coral;
            this.btnacıkarttırma.Location = new System.Drawing.Point(334, 94);
            this.btnacıkarttırma.Name = "btnacıkarttırma";
            this.btnacıkarttırma.Size = new System.Drawing.Size(159, 57);
            this.btnacıkarttırma.TabIndex = 1;
            this.btnacıkarttırma.Text = "Açık Arttırma";
            this.btnacıkarttırma.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(27, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 267);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Location = new System.Drawing.Point(71, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lbltakımadı
            // 
            this.lbltakımadı.AutoSize = true;
            this.lbltakımadı.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbltakımadı.Location = new System.Drawing.Point(59, 157);
            this.lbltakımadı.Name = "lbltakımadı";
            this.lbltakımadı.Size = new System.Drawing.Size(35, 13);
            this.lbltakımadı.TabIndex = 3;
            this.lbltakımadı.Text = "label1";
            this.lbltakımadı.Click += new System.EventHandler(this.Lbltakımadı_Click);
            // 
            // KullaniciAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(787, 339);
            this.Controls.Add(this.lbltakımadı);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnacıkarttırma);
            this.Controls.Add(this.btntransfer);
            this.Controls.Add(this.btnoyuncular);
            this.Controls.Add(this.btnTakım);
            this.Name = "KullaniciAnasayfa";
            this.Text = "KullaniciAnasayfa";
            this.Load += new System.EventHandler(this.KullaniciAnasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTakım;
        private System.Windows.Forms.Button btnoyuncular;
        private System.Windows.Forms.Button btntransfer;
        private System.Windows.Forms.Button btnacıkarttırma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbltakımadı;
    }
}