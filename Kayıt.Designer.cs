namespace Futbolmenager2
{
    partial class Kayıt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayıt));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kayıtbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.şifre = new System.Windows.Forms.Label();
            this.kullanıcı = new System.Windows.Forms.Label();
            this.kullanıcıadıtxt = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.kulüptxt = new System.Windows.Forms.TextBox();
            this.mailtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.kullanıcılbl = new System.Windows.Forms.Label();
            this.sifrelbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.kulüplbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sifretekrar = new System.Windows.Forms.TextBox();
            this.sifretekrarlbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.kullanıcıhatalbl = new System.Windows.Forms.Label();
            this.kuluphatalbl = new System.Windows.Forms.Label();
            this.sifrehatalbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kuruluştarih = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(841, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // kayıtbutton
            // 
            this.kayıtbutton.BackColor = System.Drawing.Color.DarkGray;
            this.kayıtbutton.Location = new System.Drawing.Point(441, 276);
            this.kayıtbutton.Name = "kayıtbutton";
            this.kayıtbutton.Size = new System.Drawing.Size(75, 30);
            this.kayıtbutton.TabIndex = 10;
            this.kayıtbutton.Text = "Kayıt Ol";
            this.kayıtbutton.UseVisualStyleBackColor = false;
            this.kayıtbutton.Click += new System.EventHandler(this.Giriş_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kulüp:";
            // 
            // şifre
            // 
            this.şifre.AutoSize = true;
            this.şifre.Location = new System.Drawing.Point(342, 110);
            this.şifre.Name = "şifre";
            this.şifre.Size = new System.Drawing.Size(31, 13);
            this.şifre.TabIndex = 8;
            this.şifre.Text = "Şifre:";
            // 
            // kullanıcı
            // 
            this.kullanıcı.AutoSize = true;
            this.kullanıcı.Location = new System.Drawing.Point(337, 71);
            this.kullanıcı.Name = "kullanıcı";
            this.kullanıcı.Size = new System.Drawing.Size(67, 13);
            this.kullanıcı.TabIndex = 9;
            this.kullanıcı.Text = "Kullanıcı Adı:";
            // 
            // kullanıcıadıtxt
            // 
            this.kullanıcıadıtxt.Location = new System.Drawing.Point(435, 68);
            this.kullanıcıadıtxt.MaxLength = 15;
            this.kullanıcıadıtxt.Name = "kullanıcıadıtxt";
            this.kullanıcıadıtxt.Size = new System.Drawing.Size(100, 20);
            this.kullanıcıadıtxt.TabIndex = 1;
            this.kullanıcıadıtxt.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(831, 433);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(10, 60);
            this.axWindowsMediaPlayer1.TabIndex = 11;
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(435, 107);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(100, 20);
            this.sifretxt.TabIndex = 2;
            this.sifretxt.UseSystemPasswordChar = true;
            this.sifretxt.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // kulüptxt
            // 
            this.kulüptxt.Location = new System.Drawing.Point(435, 167);
            this.kulüptxt.Name = "kulüptxt";
            this.kulüptxt.Size = new System.Drawing.Size(100, 20);
            this.kulüptxt.TabIndex = 4;
            // 
            // mailtxt
            // 
            this.mailtxt.Location = new System.Drawing.Point(435, 196);
            this.mailtxt.Name = "mailtxt";
            this.mailtxt.Size = new System.Drawing.Size(100, 20);
            this.mailtxt.TabIndex = 5;
            this.mailtxt.Leave += new System.EventHandler(this.txtmail);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "E-mail:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(401, 403);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(456, 403);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(505, 403);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // kullanıcılbl
            // 
            this.kullanıcılbl.AutoSize = true;
            this.kullanıcılbl.Location = new System.Drawing.Point(541, 71);
            this.kullanıcılbl.Name = "kullanıcılbl";
            this.kullanıcılbl.Size = new System.Drawing.Size(0, 13);
            this.kullanıcılbl.TabIndex = 26;
            // 
            // sifrelbl
            // 
            this.sifrelbl.AutoSize = true;
            this.sifrelbl.Location = new System.Drawing.Point(541, 114);
            this.sifrelbl.Name = "sifrelbl";
            this.sifrelbl.Size = new System.Drawing.Size(0, 13);
            this.sifrelbl.TabIndex = 27;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Location = new System.Drawing.Point(541, 184);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(0, 13);
            this.emaillbl.TabIndex = 28;
            // 
            // kulüplbl
            // 
            this.kulüplbl.AutoSize = true;
            this.kulüplbl.Location = new System.Drawing.Point(550, 148);
            this.kulüplbl.Name = "kulüplbl";
            this.kulüplbl.Size = new System.Drawing.Size(0, 13);
            this.kulüplbl.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Şifre Tekrarı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(516, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 36;
            // 
            // sifretekrar
            // 
            this.sifretekrar.Location = new System.Drawing.Point(435, 141);
            this.sifretekrar.Name = "sifretekrar";
            this.sifretekrar.Size = new System.Drawing.Size(100, 20);
            this.sifretekrar.TabIndex = 37;
            this.sifretekrar.UseSystemPasswordChar = true;
            this.sifretekrar.TextChanged += new System.EventHandler(this.Sifretekrar_TextChanged);
            // 
            // sifretekrarlbl
            // 
            this.sifretekrarlbl.AutoSize = true;
            this.sifretekrarlbl.Location = new System.Drawing.Point(550, 144);
            this.sifretekrarlbl.Name = "sifretekrarlbl";
            this.sifretekrarlbl.Size = new System.Drawing.Size(0, 13);
            this.sifretekrarlbl.TabIndex = 38;
            this.sifretekrarlbl.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // kullanıcıhatalbl
            // 
            this.kullanıcıhatalbl.AutoSize = true;
            this.kullanıcıhatalbl.Location = new System.Drawing.Point(542, 74);
            this.kullanıcıhatalbl.Name = "kullanıcıhatalbl";
            this.kullanıcıhatalbl.Size = new System.Drawing.Size(0, 13);
            this.kullanıcıhatalbl.TabIndex = 39;
            // 
            // kuluphatalbl
            // 
            this.kuluphatalbl.AutoSize = true;
            this.kuluphatalbl.Location = new System.Drawing.Point(542, 170);
            this.kuluphatalbl.Name = "kuluphatalbl";
            this.kuluphatalbl.Size = new System.Drawing.Size(0, 13);
            this.kuluphatalbl.TabIndex = 40;
            // 
            // sifrehatalbl
            // 
            this.sifrehatalbl.AutoSize = true;
            this.sifrehatalbl.ForeColor = System.Drawing.Color.Red;
            this.sifrehatalbl.Location = new System.Drawing.Point(513, 318);
            this.sifrehatalbl.Name = "sifrehatalbl";
            this.sifrehatalbl.Size = new System.Drawing.Size(0, 13);
            this.sifrehatalbl.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(435, 228);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 20);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // kuruluştarih
            // 
            this.kuruluştarih.AutoSize = true;
            this.kuruluştarih.Location = new System.Drawing.Point(332, 234);
            this.kuruluştarih.Name = "kuruluştarih";
            this.kuruluştarih.Size = new System.Drawing.Size(72, 13);
            this.kuruluştarih.TabIndex = 43;
            this.kuruluştarih.Text = "Kuruluş Tarih:";
            // 
            // Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 433);
            this.Controls.Add(this.kuruluştarih);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.sifrehatalbl);
            this.Controls.Add(this.kuluphatalbl);
            this.Controls.Add(this.kullanıcıhatalbl);
            this.Controls.Add(this.sifretekrarlbl);
            this.Controls.Add(this.sifretekrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kulüplbl);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.sifrelbl);
            this.Controls.Add(this.kullanıcılbl);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mailtxt);
            this.Controls.Add(this.kulüptxt);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.kayıtbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.şifre);
            this.Controls.Add(this.kullanıcı);
            this.Controls.Add(this.kullanıcıadıtxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Kayıt";
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kayıtbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label şifre;
        private System.Windows.Forms.Label kullanıcı;
        private System.Windows.Forms.TextBox kullanıcıadıtxt;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.TextBox kulüptxt;
        private System.Windows.Forms.TextBox mailtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label kullanıcılbl;
        private System.Windows.Forms.Label sifrelbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label kulüplbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sifretekrar;
        private System.Windows.Forms.Label sifretekrarlbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label kullanıcıhatalbl;
        private System.Windows.Forms.Label kuluphatalbl;
        private System.Windows.Forms.Label sifrehatalbl;
        private System.Windows.Forms.Label kuruluştarih;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

