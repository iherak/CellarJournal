namespace CellarJournal.App
{
    partial class AddWoodenBarrelForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxVolume = new System.Windows.Forms.TextBox();
            this.txtBoxYear = new System.Windows.Forms.TextBox();
            this.txtBoxWood = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zapremnina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Godina proizvodnje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vrsta drveta:";
            // 
            // txtBoxVolume
            // 
            this.txtBoxVolume.Location = new System.Drawing.Point(118, 24);
            this.txtBoxVolume.Name = "txtBoxVolume";
            this.txtBoxVolume.Size = new System.Drawing.Size(100, 20);
            this.txtBoxVolume.TabIndex = 3;
            this.txtBoxVolume.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxVolume_Validating);
            // 
            // txtBoxYear
            // 
            this.txtBoxYear.Location = new System.Drawing.Point(118, 61);
            this.txtBoxYear.Name = "txtBoxYear";
            this.txtBoxYear.Size = new System.Drawing.Size(100, 20);
            this.txtBoxYear.TabIndex = 4;
            this.txtBoxYear.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxYear_Validating);
            // 
            // txtBoxWood
            // 
            this.txtBoxWood.Location = new System.Drawing.Point(118, 101);
            this.txtBoxWood.Name = "txtBoxWood";
            this.txtBoxWood.Size = new System.Drawing.Size(100, 20);
            this.txtBoxWood.TabIndex = 5;
            this.txtBoxWood.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxWood_Validating);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(23, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.CausesValidation = false;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(143, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddWoodenBarrelForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(254, 196);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxWood);
            this.Controls.Add(this.txtBoxYear);
            this.Controls.Add(this.txtBoxVolume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddWoodenBarrelForm";
            this.Text = "AddWoodenBarrel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxVolume;
        private System.Windows.Forms.TextBox txtBoxYear;
        private System.Windows.Forms.TextBox txtBoxWood;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}