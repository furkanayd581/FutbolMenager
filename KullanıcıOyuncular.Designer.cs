namespace Futbolmenager2
{
    partial class KullanıcıOyuncular
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
            this.Oyunculardatagrid = new System.Windows.Forms.DataGridView();
            this.transferbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Oyunculardatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Oyunculardatagrid
            // 
            this.Oyunculardatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Oyunculardatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Oyunculardatagrid.Location = new System.Drawing.Point(0, 3);
            this.Oyunculardatagrid.Name = "Oyunculardatagrid";
            this.Oyunculardatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Oyunculardatagrid.Size = new System.Drawing.Size(890, 285);
            this.Oyunculardatagrid.TabIndex = 0;
            this.Oyunculardatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KullanıcıDatagrid_CellContentClick);
            // 
            // transferbtn
            // 
            this.transferbtn.BackColor = System.Drawing.Color.Coral;
            this.transferbtn.Location = new System.Drawing.Point(359, 294);
            this.transferbtn.Name = "transferbtn";
            this.transferbtn.Size = new System.Drawing.Size(112, 58);
            this.transferbtn.TabIndex = 1;
            this.transferbtn.Text = "Transfer Listesine Yolla";
            this.transferbtn.UseVisualStyleBackColor = false;
            this.transferbtn.Click += new System.EventHandler(this.Transferbtn_Click);
            // 
            // KullanıcıOyuncular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(889, 400);
            this.Controls.Add(this.transferbtn);
            this.Controls.Add(this.Oyunculardatagrid);
            this.Name = "KullanıcıOyuncular";
            this.Text = "KullanıcıOyuncular";
            this.Load += new System.EventHandler(this.KullanıcıOyuncular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Oyunculardatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Oyunculardatagrid;
        private System.Windows.Forms.Button transferbtn;
    }
}