namespace CellarJournal.App
{
    partial class SearchWineForm
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
            this.cmBoxWineType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listWines = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmBoxWineType
            // 
            this.cmBoxWineType.FormattingEnabled = true;
            this.cmBoxWineType.Location = new System.Drawing.Point(12, 25);
            this.cmBoxWineType.Name = "cmBoxWineType";
            this.cmBoxWineType.Size = new System.Drawing.Size(121, 21);
            this.cmBoxWineType.TabIndex = 0;
            this.cmBoxWineType.SelectedIndexChanged += new System.EventHandler(this.cmBoxWineType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pretraži po sorti:";
            // 
            // listWines
            // 
            this.listWines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.listWines.FullRowSelect = true;
            this.listWines.Location = new System.Drawing.Point(12, 78);
            this.listWines.MultiSelect = false;
            this.listWines.Name = "listWines";
            this.listWines.Size = new System.Drawing.Size(409, 254);
            this.listWines.TabIndex = 3;
            this.listWines.UseCompatibleStateImageBehavior = false;
            this.listWines.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Naziv vina";
            this.ColumnHeader1.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sorta";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Bačva";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Napomena";
            this.columnHeader6.Width = 173;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rezultati pretrage:";
            // 
            // SearchWineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 339);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listWines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmBoxWineType);
            this.Name = "SearchWineForm";
            this.Text = "SearchWineForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchWineForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBoxWineType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listWines;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
    }
}