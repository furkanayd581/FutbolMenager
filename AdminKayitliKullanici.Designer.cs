namespace Futbolmenager2
{
    partial class AdminKayitliKullanici
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
            this.Adminkayitdatagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Silbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aramatxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Adminkayitdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Adminkayitdatagrid
            // 
            this.Adminkayitdatagrid.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.Adminkayitdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Adminkayitdatagrid.Location = new System.Drawing.Point(26, 177);
            this.Adminkayitdatagrid.Name = "Adminkayitdatagrid";
            this.Adminkayitdatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Adminkayitdatagrid.Size = new System.Drawing.Size(1020, 208);
            this.Adminkayitdatagrid.TabIndex = 0;
            this.Adminkayitdatagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Adminkayitdatagrid_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(505, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "KAYITLI KULLANICILAR";
            // 
            // Silbtn
            // 
            this.Silbtn.BackColor = System.Drawing.Color.Cyan;
            this.Silbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Silbtn.Location = new System.Drawing.Point(510, 391);
            this.Silbtn.Name = "Silbtn";
            this.Silbtn.Size = new System.Drawing.Size(75, 46);
            this.Silbtn.TabIndex = 2;
            this.Silbtn.Text = "SİL";
            this.Silbtn.UseVisualStyleBackColor = false;
            this.Silbtn.Click += new System.EventHandler(this.Silbtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // aramatxt
            // 
            this.aramatxt.AutoSize = true;
            this.aramatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramatxt.Location = new System.Drawing.Point(69, 103);
            this.aramatxt.Name = "aramatxt";
            this.aramatxt.Size = new System.Drawing.Size(82, 17);
            this.aramatxt.TabIndex = 4;
            this.aramatxt.Text = "Arama Yap:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(69, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seçiniz:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "KULLANICIADI",
            "KULLANICIKULUP"});
            this.comboBox1.Location = new System.Drawing.Point(157, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // AdminKayitliKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1058, 449);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aramatxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Silbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Adminkayitdatagrid);
            this.Name = "AdminKayitliKullanici";
            this.Text = "AdminKayitliKullanici";
            this.Load += new System.EventHandler(this.AdminKayitliKullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Adminkayitdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Adminkayitdatagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Silbtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label aramatxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}