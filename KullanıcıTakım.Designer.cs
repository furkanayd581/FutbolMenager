namespace Futbolmenager2
{
    partial class KullanıcıTakım
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
            this.Takımdatagridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Takımdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Takımdatagridview
            // 
            this.Takımdatagridview.BackgroundColor = System.Drawing.Color.Cyan;
            this.Takımdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Takımdatagridview.Location = new System.Drawing.Point(1, 3);
            this.Takımdatagridview.Name = "Takımdatagridview";
            this.Takımdatagridview.Size = new System.Drawing.Size(862, 285);
            this.Takımdatagridview.TabIndex = 0;
            // 
            // KullanıcıTakım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 353);
            this.Controls.Add(this.Takımdatagridview);
            this.Name = "KullanıcıTakım";
            this.Text = "KullanıcıTakım";
            this.Load += new System.EventHandler(this.KullanıcıTakım_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Takımdatagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Takımdatagridview;
    }
}