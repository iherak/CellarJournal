namespace CellarJournal.App
{
    partial class ShowListEmptyCont
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
            this.gridViewEmptyBarr = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmptyBarr)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewEmptyBarr
            // 
            this.gridViewEmptyBarr.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridViewEmptyBarr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewEmptyBarr.Location = new System.Drawing.Point(0, 12);
            this.gridViewEmptyBarr.Name = "gridViewEmptyBarr";
            this.gridViewEmptyBarr.RowHeadersWidth = 20;
            this.gridViewEmptyBarr.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewEmptyBarr.Size = new System.Drawing.Size(323, 250);
            this.gridViewEmptyBarr.TabIndex = 0;
            // 
            // ShowListEmptyCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 262);
            this.Controls.Add(this.gridViewEmptyBarr);
            this.Name = "ShowListEmptyCont";
            this.Text = "Prazni spremnici";
            this.Load += new System.EventHandler(this.ShowListEmptyCont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmptyBarr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewEmptyBarr;

    }
}