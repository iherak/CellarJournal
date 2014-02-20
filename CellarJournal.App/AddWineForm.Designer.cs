namespace CellarJournal.App
{
    partial class AddWineForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.cmbBoxType = new System.Windows.Forms.ComboBox();
            this.cmbBoxContainer = new System.Windows.Forms.ComboBox();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(41, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.CausesValidation = false;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(155, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Odustani";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(155, 24);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxName.TabIndex = 2;
            this.txtBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxName_Validating);
            // 
            // cmbBoxType
            // 
            this.cmbBoxType.FormattingEnabled = true;
            this.cmbBoxType.Location = new System.Drawing.Point(151, 71);
            this.cmbBoxType.Name = "cmbBoxType";
            this.cmbBoxType.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxType.TabIndex = 3;
            this.cmbBoxType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbBoxType_Validating);
            // 
            // cmbBoxContainer
            // 
            this.cmbBoxContainer.FormattingEnabled = true;
            this.cmbBoxContainer.Location = new System.Drawing.Point(151, 120);
            this.cmbBoxContainer.Name = "cmbBoxContainer";
            this.cmbBoxContainer.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxContainer.TabIndex = 4;
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(155, 165);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDescription.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sorta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bačva:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Opis:";
            // 
            // AddWineForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.cmbBoxContainer);
            this.Controls.Add(this.cmbBoxType);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AddWineForm";
            this.Text = "AddWineForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.ComboBox cmbBoxType;
        private System.Windows.Forms.ComboBox cmbBoxContainer;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}