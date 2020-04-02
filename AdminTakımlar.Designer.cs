namespace Futbolmenager2
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
            ((System.ComponentModel.ISupportInitialize)(this.Takımlardatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Takımlardatagrid
            // 
            this.Takımlardatagrid.BackgroundColor = System.Drawing.Color.Coral;
            this.Takımlardatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Takımlardatagrid.Location = new System.Drawing.Point(1, 251);
            this.Takımlardatagrid.Name = "Takımlardatagrid";
            this.Takımlardatagrid.Size = new System.Drawing.Size(802, 128);
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
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kulüp Adı:";
            // 
            // kulupaditxt
            // 
            this.kulupaditxt.Location = new System.Drawing.Point(74, 12);
            this.kulupaditxt.Name = "kulupaditxt";
            this.kulupaditxt.Size = new System.Drawing.Size(100, 20);
            this.kulupaditxt.TabIndex = 5;
            // 
            // kuluptarihtxt
            // 
            this.kuluptarihtxt.Location = new System.Drawing.Point(74, 46);
            this.kuluptarihtxt.Name = "kuluptarihtxt";
            this.kuluptarihtxt.Size = new System.Drawing.Size(100, 20);
            this.kuluptarihtxt.TabIndex = 6;
            // 
            // kulupsampiyonluktxt
            // 
            this.kulupsampiyonluktxt.Location = new System.Drawing.Point(74, 121);
            this.kulupsampiyonluktxt.Name = "kulupsampiyonluktxt";
            this.kulupsampiyonluktxt.Size = new System.Drawing.Size(100, 20);
            this.kulupsampiyonluktxt.TabIndex = 8;
            // 
            // kulupdegertxt
            // 
            this.kulupdegertxt.Location = new System.Drawing.Point(74, 153);
            this.kulupdegertxt.Name = "kulupdegertxt";
            this.kulupdegertxt.Size = new System.Drawing.Size(100, 20);
            this.kulupdegertxt.TabIndex = 9;
            // 
            // kulupligtxt
            // 
            this.kulupligtxt.Location = new System.Drawing.Point(74, 187);
            this.kulupligtxt.Name = "kulupligtxt";
            this.kulupligtxt.Size = new System.Drawing.Size(100, 20);
            this.kulupligtxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kulüp Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Şampiyonluk:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kulüp Değer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 187);
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
            this.resimekletxt.Location = new System.Drawing.Point(74, 85);
            this.resimekletxt.Name = "resimekletxt";
            this.resimekletxt.Size = new System.Drawing.Size(100, 20);
            this.resimekletxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kulüp Foto";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 85);
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
            this.pictureBox1.Location = new System.Drawing.Point(395, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Stadyum";
            // 
            // stadyumtxt
            // 
            this.stadyumtxt.Location = new System.Drawing.Point(74, 217);
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
            this.label8.Location = new System.Drawing.Point(201, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Arama Yap";
//            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // aramatxt
            // 
            this.aramatxt.Location = new System.Drawing.Point(257, 16);
            this.aramatxt.Name = "aramatxt";
            this.aramatxt.Size = new System.Drawing.Size(100, 20);
            this.aramatxt.TabIndex = 23;
            this.aramatxt.TextChanged += new System.EventHandler(this.Aramatxt_TextChanged);
            // 
            // AdminTakımlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(804, 376);
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
            this.Load += new System.EventHandler(this.AdminTakımlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Takımlardatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}