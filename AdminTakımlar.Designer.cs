﻿namespace Futbolmenager2
{
    partial class AdminTakımlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTakımlar));
            this.Takımlardatagrid = new System.Windows.Forms.DataGridView();
            this.Takımbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kulupaditxt = new System.Windows.Forms.TextBox();
            this.kuluptarihtxt = new System.Windows.Forms.TextBox();
            this.kulupsampiyonluktxt = new System.Windows.Forms.TextBox();
            this.kulupdegertxt = new System.Windows.Forms.TextBox();
            this.kulupligtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Takımeklebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.resimekletxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stadyumtxt = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.aramatxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Takımlardatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Takımlardatagrid
            // 
            this.Takımlardatagrid.BackgroundColor = System.Drawing.Color.Coral;
            this.Takımlardatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Takımlardatagrid.Location = new System.Drawing.Point(1, 292);
            this.Takımlardatagrid.Name = "Takımlardatagrid";
            this.Takımlardatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Takımlardatagrid.Size = new System.Drawing.Size(802, 112);
            this.Takımlardatagrid.TabIndex = 0;
            this.Takımlardatagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Takımlardatagrid_CellDoubleClick);
            // 
            // Takımbtn
            // 
            this.Takımbtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Takımbtn.Location = new System.Drawing.Point(693, 12);
            this.Takımbtn.Name = "Takımbtn";
            this.Takımbtn.Size = new System.Drawing.Size(75, 39);
            this.Takımbtn.TabIndex = 1;
            this.Takımbtn.Text = "Takımlar";
            this.Takımbtn.UseVisualStyleBackColor = false;
            this.Takımbtn.Click += new System.EventHandler(this.Takımbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kulüp Adı:";
            // 
            // kulupaditxt
            // 
            this.kulupaditxt.Location = new System.Drawing.Point(74, 69);
            this.kulupaditxt.Name = "kulupaditxt";
            this.kulupaditxt.Size = new System.Drawing.Size(100, 20);
            this.kulupaditxt.TabIndex = 5;
            // 
            // kuluptarihtxt
            // 
            this.kuluptarihtxt.Location = new System.Drawing.Point(74, 102);
            this.kuluptarihtxt.Name = "kuluptarihtxt";
            this.kuluptarihtxt.Size = new System.Drawing.Size(100, 20);
            this.kuluptarihtxt.TabIndex = 6;
            // 
            // kulupsampiyonluktxt
            // 
            this.kulupsampiyonluktxt.Location = new System.Drawing.Point(74, 168);
            this.kulupsampiyonluktxt.Name = "kulupsampiyonluktxt";
            this.kulupsampiyonluktxt.Size = new System.Drawing.Size(100, 20);
            this.kulupsampiyonluktxt.TabIndex = 8;
            // 
            // kulupdegertxt
            // 
            this.kulupdegertxt.Location = new System.Drawing.Point(74, 203);
            this.kulupdegertxt.Name = "kulupdegertxt";
            this.kulupdegertxt.Size = new System.Drawing.Size(100, 20);
            this.kulupdegertxt.TabIndex = 9;
            // 
            // kulupligtxt
            // 
            this.kulupligtxt.Location = new System.Drawing.Point(74, 237);
            this.kulupligtxt.Name = "kulupligtxt";
            this.kulupligtxt.Size = new System.Drawing.Size(100, 20);
            this.kulupligtxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kulüp Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Şampiyonluk:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kulüp Değer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = " Lig:";
            // 
            // Takımeklebtn
            // 
            this.Takımeklebtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Takımeklebtn.Location = new System.Drawing.Point(693, 59);
            this.Takımeklebtn.Name = "Takımeklebtn";
            this.Takımeklebtn.Size = new System.Drawing.Size(75, 39);
            this.Takımeklebtn.TabIndex = 16;
            this.Takımeklebtn.Text = "Takım Ekle";
            this.Takımeklebtn.UseVisualStyleBackColor = false;
            this.Takımeklebtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // resimekletxt
            // 
            this.resimekletxt.Location = new System.Drawing.Point(74, 137);
            this.resimekletxt.Name = "resimekletxt";
            this.resimekletxt.Size = new System.Drawing.Size(100, 20);
            this.resimekletxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kulüp Foto";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 21);
            this.button2.TabIndex = 18;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(451, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Stadyum";
            // 
            // stadyumtxt
            // 
            this.stadyumtxt.Location = new System.Drawing.Point(74, 266);
            this.stadyumtxt.Name = "stadyumtxt";
            this.stadyumtxt.Size = new System.Drawing.Size(100, 20);
            this.stadyumtxt.TabIndex = 21;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "arama.png");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(229, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Arama Yap:";
            // 
            // aramatxt
            // 
            this.aramatxt.Location = new System.Drawing.Point(312, 56);
            this.aramatxt.Name = "aramatxt";
            this.aramatxt.Size = new System.Drawing.Size(121, 20);
            this.aramatxt.TabIndex = 23;
            this.aramatxt.TextChanged += new System.EventHandler(this.Aramatxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(229, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Seçiniz:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ADİ",
            "SAMPİYON",
            "LİG",
            "STADYUM"});
            this.comboBox1.Location = new System.Drawing.Point(312, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AdminTakımlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(813, 416);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.aramatxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.stadyumtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Takımeklebtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kulupligtxt);
            this.Controls.Add(this.kulupdegertxt);
            this.Controls.Add(this.kulupsampiyonluktxt);
            this.Controls.Add(this.resimekletxt);
            this.Controls.Add(this.kuluptarihtxt);
            this.Controls.Add(this.kulupaditxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Takımbtn);
            this.Controls.Add(this.Takımlardatagrid);
            this.Name = "AdminTakımlar";
            this.Text = "AdminTakımlar";
//            this.Load += new System.EventHandler(this.AdminTakımlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Takımlardatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Takımlardatagrid;
        private System.Windows.Forms.Button Takımbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kulupaditxt;
        private System.Windows.Forms.TextBox kuluptarihtxt;
        private System.Windows.Forms.TextBox kulupsampiyonluktxt;
        private System.Windows.Forms.TextBox kulupdegertxt;
        private System.Windows.Forms.TextBox kulupligtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Takımeklebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox resimekletxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stadyumtxt;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox aramatxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}