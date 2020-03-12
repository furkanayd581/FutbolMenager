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
            this.Takımlardatagrid = new System.Windows.Forms.DataGridView();
            this.Takımbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Takımeklebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Takımlardatagrid)).BeginInit();
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
            this.Takımlardatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Takımlardatagrid_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kulüp Adı:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(74, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(74, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(74, 154);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(74, 189);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(74, 225);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kulüp Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kulüp Foto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Şampiyonluk:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kulüp Değer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 232);
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
            // AdminTakımlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(804, 376);
            this.Controls.Add(this.Takımeklebtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Takımbtn);
            this.Controls.Add(this.Takımlardatagrid);
            this.Name = "AdminTakımlar";
            this.Text = "AdminTakımlar";
            this.Load += new System.EventHandler(this.AdminTakımlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Takımlardatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Takımlardatagrid;
        private System.Windows.Forms.Button Takımbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Takımeklebtn;
    }
}