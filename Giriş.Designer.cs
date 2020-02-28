namespace Futbolmenager2
{
    partial class Giriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giriş));
            this.kullanicigrş = new System.Windows.Forms.TextBox();
            this.şifregrş = new System.Windows.Forms.TextBox();
            this.GirişButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BeniHatirla = new System.Windows.Forms.CheckBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullanicigrş
            // 
            this.kullanicigrş.Location = new System.Drawing.Point(396, 115);
            this.kullanicigrş.Name = "kullanicigrş";
            this.kullanicigrş.Size = new System.Drawing.Size(100, 20);
            this.kullanicigrş.TabIndex = 0;
//            this.kullanicigrş.TextChanged += new System.EventHandler(this.Kullanicigrş_TextChanged);
            // 
            // şifregrş
            // 
            this.şifregrş.Location = new System.Drawing.Point(396, 156);
            this.şifregrş.Name = "şifregrş";
            this.şifregrş.Size = new System.Drawing.Size(100, 20);
            this.şifregrş.TabIndex = 1;
            this.şifregrş.UseSystemPasswordChar = true;
            // 
            // GirişButton
            // 
            this.GirişButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.GirişButton.Location = new System.Drawing.Point(403, 205);
            this.GirişButton.Name = "GirişButton";
            this.GirişButton.Size = new System.Drawing.Size(75, 33);
            this.GirişButton.TabIndex = 2;
            this.GirişButton.Text = "Giriş Yap";
            this.GirişButton.UseVisualStyleBackColor = false;
            this.GirişButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 48);
            this.panel1.TabIndex = 3;
//            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "KULLANICI GİRİŞİ";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(36, 365);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(-2, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 58);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(402, 241);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // BeniHatirla
            // 
            this.BeniHatirla.AutoSize = true;
            this.BeniHatirla.Location = new System.Drawing.Point(403, 182);
            this.BeniHatirla.Name = "BeniHatirla";
            this.BeniHatirla.Size = new System.Drawing.Size(80, 17);
            this.BeniHatirla.TabIndex = 8;
            this.BeniHatirla.Text = "Beni Hatırla";
            this.BeniHatirla.UseVisualStyleBackColor = true;
//            this.BeniHatirla.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(380, 266);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(129, 13);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Kayıt Olmak İçin Tıklayınız";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(765, 421);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.BeniHatirla);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GirişButton);
            this.Controls.Add(this.şifregrş);
            this.Controls.Add(this.kullanicigrş);
            this.Name = "Giriş";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Giriş_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullanicigrş;
        private System.Windows.Forms.TextBox şifregrş;
        private System.Windows.Forms.Button GirişButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox BeniHatirla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}