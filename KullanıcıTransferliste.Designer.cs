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
            this.transferlistedatagrid = new System.Windows.Forms.DataGridView();
            this.aramatxt = new System.Windows.Forms.TextBox();
            this.aramalbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transferlistedatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // transferlistedatagrid
            // 
            this.transferlistedatagrid.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.transferlistedatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.transferlistedatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transferlistedatagrid.Location = new System.Drawing.Point(3, 193);
            this.transferlistedatagrid.Name = "transferlistedatagrid";
            this.transferlistedatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transferlistedatagrid.Size = new System.Drawing.Size(865, 165);
            this.transferlistedatagrid.TabIndex = 0;
            this.transferlistedatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transferlistedatagrid_CellContentClick);
            // 
            // aramatxt
            // 
            this.aramatxt.Location = new System.Drawing.Point(144, 60);
            this.aramatxt.Name = "aramatxt";
            this.aramatxt.Size = new System.Drawing.Size(121, 20);
            this.aramatxt.TabIndex = 1;
            this.aramatxt.TextChanged += new System.EventHandler(this.Transferarama_TextChanged);
            // 
            // aramalbl
            // 
            this.aramalbl.AutoSize = true;
            this.aramalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramalbl.Location = new System.Drawing.Point(46, 60);
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
            this.comboBox1.Location = new System.Drawing.Point(144, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 26);
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
            // KullanıcıTransferliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(871, 572);
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
    }
}