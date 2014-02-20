namespace CellarJournal.App
{
    partial class JournalForm
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
            this.dgvJournal = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxNewEntry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJournal
            // 
            this.dgvJournal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournal.Location = new System.Drawing.Point(15, 12);
            this.dgvJournal.MultiSelect = false;
            this.dgvJournal.Name = "dgvJournal";
            this.dgvJournal.Size = new System.Drawing.Size(462, 185);
            this.dgvJournal.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(402, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 53);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj zapis";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxNewEntry
            // 
            this.txtBoxNewEntry.Location = new System.Drawing.Point(15, 220);
            this.txtBoxNewEntry.Multiline = true;
            this.txtBoxNewEntry.Name = "txtBoxNewEntry";
            this.txtBoxNewEntry.Size = new System.Drawing.Size(372, 53);
            this.txtBoxNewEntry.TabIndex = 2;
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 286);
            this.Controls.Add(this.txtBoxNewEntry);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvJournal);
            this.Name = "JournalForm";
            this.Text = "Dnevnik";
            this.Load += new System.EventHandler(this.JournalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJournal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBoxNewEntry;
    }
}