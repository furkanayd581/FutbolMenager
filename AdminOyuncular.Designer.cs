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
            ((System.ComponentModel.ISupportInitialize)(this.OyuncularDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OyuncularDataGrid
            // 
            this.OyuncularDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OyuncularDataGrid.Location = new System.Drawing.Point(4, 5);
            this.OyuncularDataGrid.Name = "OyuncularDataGrid";
            this.OyuncularDataGrid.Size = new System.Drawing.Size(793, 371);
            this.OyuncularDataGrid.TabIndex = 0;
            // 
            // AdminOyuncular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OyuncularDataGrid);
            this.Name = "AdminOyuncular";
            this.Text = "Oyuncular";
            this.Load += new System.EventHandler(this.AdminOyuncular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OyuncularDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OyuncularDataGrid;
    }
}