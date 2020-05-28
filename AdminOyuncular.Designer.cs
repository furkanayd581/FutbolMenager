namespace Futbolmenager2
{
    partial class AdminOyuncular
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
            this.OyuncularDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.aramatxt = new System.Windows.Forms.TextBox();
            this.ayak = new System.Windows.Forms.TextBox();
            this.no = new System.Windows.Forms.TextBox();
            this.adi = new System.Windows.Forms.TextBox();
            this.soyadi = new System.Windows.Forms.TextBox();
            this.yas = new System.Windows.Forms.TextBox();
            this.mevki = new System.Windows.Forms.TextBox();
            this.satış = new System.Windows.Forms.TextBox();
            this.kulüp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.durum = new System.Windows.Forms.TextBox();
            this.boy = new System.Windows.Forms.TextBox();
            this.uyruk = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OyuncularDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OyuncularDataGrid
            // 
            this.OyuncularDataGrid.BackgroundColor = System.Drawing.Color.Khaki;
            this.OyuncularDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OyuncularDataGrid.Location = new System.Drawing.Point(4, 324);
            this.OyuncularDataGrid.Name = "OyuncularDataGrid";
            this.OyuncularDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OyuncularDataGrid.Size = new System.Drawing.Size(843, 218);
            this.OyuncularDataGrid.TabIndex = 0;
            this.OyuncularDataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OyuncularDataGrid_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(562, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seçiniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(562, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arama Yap:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ADI",
            "SOYADI",
            "YAS",
            "MEVKİ",
            "AYAK",
            "KULUP",
            "SATISFİYAT",
            "SATISDURUM",
            "BOY",
            "UYRUK"});
            this.comboBox1.Location = new System.Drawing.Point(662, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // aramatxt
            // 
            this.aramatxt.Location = new System.Drawing.Point(662, 61);
            this.aramatxt.Name = "aramatxt";
            this.aramatxt.Size = new System.Drawing.Size(121, 20);
            this.aramatxt.TabIndex = 3;
            this.aramatxt.TextChanged += new System.EventHandler(this.aramatxt_TextChanged);
            // 
            // ayak
            // 
            this.ayak.Location = new System.Drawing.Point(116, 196);
            this.ayak.Name = "ayak";
            this.ayak.Size = new System.Drawing.Size(100, 20);
            this.ayak.TabIndex = 4;
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(116, 26);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(100, 20);
            this.no.TabIndex = 4;
            // 
            // adi
            // 
            this.adi.Location = new System.Drawing.Point(116, 56);
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(100, 20);
            this.adi.TabIndex = 4;
            // 
            // soyadi
            // 
            this.soyadi.Location = new System.Drawing.Point(116, 92);
            this.soyadi.Name = "soyadi";
            this.soyadi.Size = new System.Drawing.Size(100, 20);
            this.soyadi.TabIndex = 4;
            // 
            // yas
            // 
            this.yas.Location = new System.Drawing.Point(116, 129);
            this.yas.Name = "yas";
            this.yas.Size = new System.Drawing.Size(100, 20);
            this.yas.TabIndex = 4;
            // 
            // mevki
            // 
            this.mevki.Location = new System.Drawing.Point(116, 161);
            this.mevki.Name = "mevki";
            this.mevki.Size = new System.Drawing.Size(100, 20);
            this.mevki.TabIndex = 4;
            // 
            // satış
            // 
            this.satış.Location = new System.Drawing.Point(393, 59);
            this.satış.Name = "satış";
            this.satış.Size = new System.Drawing.Size(100, 20);
            this.satış.TabIndex = 4;
            // 
            // kulüp
            // 
            this.kulüp.Location = new System.Drawing.Point(393, 26);
            this.kulüp.Name = "kulüp";
            this.kulüp.Size = new System.Drawing.Size(100, 20);
            this.kulüp.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sporcu No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(-1, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sporcu Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(-1, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sporcu Soyadı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(-1, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sporcu Yaş:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Sporcu Mevki:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(1, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Sporcu Ayak:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(261, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Sporcu Kulüp:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(261, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Sporcu Satış:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(261, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Sporcu Durumu:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(261, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Sporcu Boy:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(255, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Sporcu Uyruk:";
            // 
            // durum
            // 
            this.durum.Location = new System.Drawing.Point(393, 95);
            this.durum.Name = "durum";
            this.durum.Size = new System.Drawing.Size(100, 20);
            this.durum.TabIndex = 4;
            // 
            // boy
            // 
            this.boy.Location = new System.Drawing.Point(393, 129);
            this.boy.Name = "boy";
            this.boy.Size = new System.Drawing.Size(100, 20);
            this.boy.TabIndex = 4;
            // 
            // uyruk
            // 
            this.uyruk.Location = new System.Drawing.Point(393, 164);
            this.uyruk.Name = "uyruk";
            this.uyruk.Size = new System.Drawing.Size(100, 20);
            this.uyruk.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(258, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Oyuncu Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(369, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminOyuncular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(857, 694);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mevki);
            this.Controls.Add(this.yas);
            this.Controls.Add(this.soyadi);
            this.Controls.Add(this.adi);
            this.Controls.Add(this.no);
            this.Controls.Add(this.kulüp);
            this.Controls.Add(this.uyruk);
            this.Controls.Add(this.boy);
            this.Controls.Add(this.durum);
            this.Controls.Add(this.satış);
            this.Controls.Add(this.ayak);
            this.Controls.Add(this.aramatxt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OyuncularDataGrid);
            this.Name = "AdminOyuncular";
            this.Text = "Oyuncular";
            this.Load += new System.EventHandler(this.AdminOyuncular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OyuncularDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OyuncularDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox aramatxt;
        private System.Windows.Forms.TextBox ayak;
        private System.Windows.Forms.TextBox no;
        private System.Windows.Forms.TextBox adi;
        private System.Windows.Forms.TextBox soyadi;
        private System.Windows.Forms.TextBox yas;
        private System.Windows.Forms.TextBox mevki;
        private System.Windows.Forms.TextBox satış;
        private System.Windows.Forms.TextBox kulüp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox durum;
        private System.Windows.Forms.TextBox boy;
        private System.Windows.Forms.TextBox uyruk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}