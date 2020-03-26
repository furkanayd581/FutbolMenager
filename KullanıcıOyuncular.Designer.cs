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
            this.KullanıcıDatagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.KullanıcıDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // KullanıcıDatagrid
            // 
            this.KullanıcıDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KullanıcıDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KullanıcıDatagrid.Location = new System.Drawing.Point(0, 3);
            this.KullanıcıDatagrid.Name = "KullanıcıDatagrid";
            this.KullanıcıDatagrid.Size = new System.Drawing.Size(804, 200);
            this.KullanıcıDatagrid.TabIndex = 0;
            // 
            // KullanıcıOyuncular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 348);
            this.Controls.Add(this.KullanıcıDatagrid);
            this.Name = "KullanıcıOyuncular";
            this.Text = "KullanıcıOyuncular";
            this.Load += new System.EventHandler(this.KullanıcıOyuncular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KullanıcıDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView KullanıcıDatagrid;
    }
}