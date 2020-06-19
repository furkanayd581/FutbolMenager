namespace Futbolmenager2
{
    partial class KullanıcıTransferliste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıTransferliste));
            this.transferlistedatagrid = new System.Windows.Forms.DataGridView();
            this.aramatxt = new System.Windows.Forms.TextBox();
            this.aramalbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kullaniciadi = new System.Windows.Forms.Label();
            this.eski_kulup_bütce = new System.Windows.Forms.Label();
            this.yenikulupdeger = new System.Windows.Forms.Label();
            this.yenikulupid = new System.Windows.Forms.Label();
            this.bütcearttırlbl = new System.Windows.Forms.Label();
            this.eskikulupid = new System.Windows.Forms.Label();
            this.transferoyuncukulup = new System.Windows.Forms.Label();
            this.transfer_oyuncu_kulupdeger = new System.Windows.Forms.Label();
            this.transfersatis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transferlistedatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // transferlistedatagrid
            // 
            this.transferlistedatagrid.AllowUserToAddRows = false;
            this.transferlistedatagrid.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.transferlistedatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.transferlistedatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transferlistedatagrid.Location = new System.Drawing.Point(3, 193);
            this.transferlistedatagrid.Name = "transferlistedatagrid";
            this.transferlistedatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transferlistedatagrid.Size = new System.Drawing.Size(865, 165);
            this.transferlistedatagrid.TabIndex = 0;
            this.transferlistedatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transferlistedatagrid_CellContentClick);
            this.transferlistedatagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transferlistedatagrid_CellDoubleClick);
            // 
            // aramatxt
            // 
            this.aramatxt.Location = new System.Drawing.Point(359, 63);
            this.aramatxt.Name = "aramatxt";
            this.aramatxt.Size = new System.Drawing.Size(121, 20);
            this.aramatxt.TabIndex = 1;
            this.aramatxt.TextChanged += new System.EventHandler(this.Transferarama_TextChanged);
            // 
            // aramalbl
            // 
            this.aramalbl.AutoSize = true;
            this.aramalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramalbl.Location = new System.Drawing.Point(248, 66);
            this.aramalbl.Name = "aramalbl";
            this.aramalbl.Size = new System.Drawing.Size(82, 17);
            this.aramalbl.TabIndex = 2;
            this.aramalbl.Text = "Arama Yap:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "ADİ",
            "SOYADİ",
            "YAS",
            "MEVKİ",
            "AYAK",
            "KULUP",
            "SATİSFİYAT",
            "BOY",
            "UYRUK"});
            this.comboBox1.Location = new System.Drawing.Point(359, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(248, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seçiniz:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(359, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Transfer Et";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.AutoSize = true;
            this.kullaniciadi.Location = new System.Drawing.Point(9, 375);
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.Size = new System.Drawing.Size(59, 13);
            this.kullaniciadi.TabIndex = 7;
            this.kullaniciadi.Text = "kullanıcıadı";
            // 
            // eski_kulup_bütce
            // 
            this.eski_kulup_bütce.AutoSize = true;
            this.eski_kulup_bütce.Location = new System.Drawing.Point(5, 489);
            this.eski_kulup_bütce.Name = "eski_kulup_bütce";
            this.eski_kulup_bütce.Size = new System.Drawing.Size(79, 13);
            this.eski_kulup_bütce.TabIndex = 8;
            this.eski_kulup_bütce.Text = "eskikulupdeger";
            // 
            // yenikulupdeger
            // 
            this.yenikulupdeger.AutoSize = true;
            this.yenikulupdeger.Location = new System.Drawing.Point(9, 465);
            this.yenikulupdeger.Name = "yenikulupdeger";
            this.yenikulupdeger.Size = new System.Drawing.Size(79, 13);
            this.yenikulupdeger.TabIndex = 10;
            this.yenikulupdeger.Text = "yenikulupdeger";
            // 
            // yenikulupid
            // 
            this.yenikulupid.AutoSize = true;
            this.yenikulupid.Location = new System.Drawing.Point(9, 406);
            this.yenikulupid.Name = "yenikulupid";
            this.yenikulupid.Size = new System.Drawing.Size(75, 13);
            this.yenikulupid.TabIndex = 11;
            this.yenikulupid.Text = "yeni_kulup ID:";
            // 
            // bütcearttırlbl
            // 
            this.bütcearttırlbl.AutoSize = true;
            this.bütcearttırlbl.Location = new System.Drawing.Point(129, 375);
            this.bütcearttırlbl.Name = "bütcearttırlbl";
            this.bütcearttırlbl.Size = new System.Drawing.Size(54, 13);
            this.bütcearttırlbl.TabIndex = 12;
            this.bütcearttırlbl.Text = "bütçearttır";
            // 
            // eskikulupid
            // 
            this.eskikulupid.AutoSize = true;
            this.eskikulupid.Location = new System.Drawing.Point(9, 435);
            this.eskikulupid.Name = "eskikulupid";
            this.eskikulupid.Size = new System.Drawing.Size(75, 13);
            this.eskikulupid.TabIndex = 13;
            this.eskikulupid.Text = "eski_kulup ID:";
            // 
            // transferoyuncukulup
            // 
            this.transferoyuncukulup.AutoSize = true;
            this.transferoyuncukulup.Location = new System.Drawing.Point(129, 406);
            this.transferoyuncukulup.Name = "transferoyuncukulup";
            this.transferoyuncukulup.Size = new System.Drawing.Size(72, 13);
            this.transferoyuncukulup.TabIndex = 14;
            this.transferoyuncukulup.Text = "Transferkulup";
            // 
            // transfer_oyuncu_kulupdeger
            // 
            this.transfer_oyuncu_kulupdeger.AutoSize = true;
            this.transfer_oyuncu_kulupdeger.Location = new System.Drawing.Point(129, 435);
            this.transfer_oyuncu_kulupdeger.Name = "transfer_oyuncu_kulupdeger";
            this.transfer_oyuncu_kulupdeger.Size = new System.Drawing.Size(163, 13);
            this.transfer_oyuncu_kulupdeger.TabIndex = 15;
            this.transfer_oyuncu_kulupdeger.Text = "Transferdeki oyuncu kulup deger";
            // 
            // transfersatis
            // 
            this.transfersatis.AutoSize = true;
            this.transfersatis.Location = new System.Drawing.Point(129, 465);
            this.transfersatis.Name = "transfersatis";
            this.transfersatis.Size = new System.Drawing.Size(97, 13);
            this.transfersatis.TabIndex = 16;
            this.transfersatis.Text = "Transfer Satış Fiyat";
            // 
            // KullanıcıTransferliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(871, 572);
            this.Controls.Add(this.transfersatis);
            this.Controls.Add(this.transfer_oyuncu_kulupdeger);
            this.Controls.Add(this.transferoyuncukulup);
            this.Controls.Add(this.eskikulupid);
            this.Controls.Add(this.bütcearttırlbl);
            this.Controls.Add(this.yenikulupid);
            this.Controls.Add(this.yenikulupdeger);
            this.Controls.Add(this.eski_kulup_bütce);
            this.Controls.Add(this.kullaniciadi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.aramalbl);
            this.Controls.Add(this.aramatxt);
            this.Controls.Add(this.transferlistedatagrid);
            this.Name = "KullanıcıTransferliste";
            this.Text = "KullanıcıTransferliste";
            this.Load += new System.EventHandler(this.KullanıcıTransferliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transferlistedatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView transferlistedatagrid;
        private System.Windows.Forms.TextBox aramatxt;
        private System.Windows.Forms.Label aramalbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label kullaniciadi;
        private System.Windows.Forms.Label eski_kulup_bütce;
        private System.Windows.Forms.Label yenikulupdeger;
        private System.Windows.Forms.Label yenikulupid;
        private System.Windows.Forms.Label bütcearttırlbl;
        private System.Windows.Forms.Label eskikulupid;
        private System.Windows.Forms.Label transferoyuncukulup;
        private System.Windows.Forms.Label transfer_oyuncu_kulupdeger;
        private System.Windows.Forms.Label transfersatis;
    }
}