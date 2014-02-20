namespace CellarJournal.App
{
    partial class AddYearForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Odustani = new System.Windows.Forms.Button();
            this.txtBoxYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite godinu:";
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(29, 65);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // Odustani
            // 
            this.Odustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Odustani.Location = new System.Drawing.Point(131, 65);
            this.Odustani.Name = "Odustani";
            this.Odustani.Size = new System.Drawing.Size(75, 23);
            this.Odustani.TabIndex = 2;
            this.Odustani.Text = "Odustani";
            this.Odustani.UseVisualStyleBackColor = true;
            // 
            // txtBoxYear
            // 
            this.txtBoxYear.Location = new System.Drawing.Point(110, 27);
            this.txtBoxYear.Name = "txtBoxYear";
            this.txtBoxYear.Size = new System.Drawing.Size(100, 20);
            this.txtBoxYear.TabIndex = 3;
            // 
            // AddYearForm
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Odustani;
            this.ClientSize = new System.Drawing.Size(254, 100);
            this.Controls.Add(this.txtBoxYear);
            this.Controls.Add(this.Odustani);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label1);
            this.Name = "AddYearForm";
            this.Text = "Dodaj godinu...";
            this.Load += new System.EventHandler(this.AddYearForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Odustani;
        private System.Windows.Forms.TextBox txtBoxYear;
    }
}