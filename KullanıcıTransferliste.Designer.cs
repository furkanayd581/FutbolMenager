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
            ((System.ComponentModel.ISupportInitialize)(this.transferlistedatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // transferlistedatagrid
            // 
            this.transferlistedatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transferlistedatagrid.Location = new System.Drawing.Point(12, 12);
            this.transferlistedatagrid.Name = "transferlistedatagrid";
            this.transferlistedatagrid.Size = new System.Drawing.Size(785, 167);
            this.transferlistedatagrid.TabIndex = 0;
            // 
            // KullanıcıTransferliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transferlistedatagrid);
            this.Name = "KullanıcıTransferliste";
            this.Text = "KullanıcıTransferliste";
            this.Load += new System.EventHandler(this.KullanıcıTransferliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transferlistedatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView transferlistedatagrid;
    }
}