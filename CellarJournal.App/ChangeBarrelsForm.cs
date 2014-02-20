using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CellarJournal.Controllers;
using CellarJournal.Controllers.Interfaces;
using CellarJournal.Model;
using Container = CellarJournal.Model.Container;

namespace CellarJournal.App
{
    public class ChangeBarrelsForm : Form, IChangeBarrelsFrm
    {
        private MainController _mainController;

        public ChangeBarrelsForm(MainController mainController)
        {
            InitializeComponent();
            _mainController = mainController;
        }

        public int ShowEx()
        {
            cmbBoxType.Items.Add("Otvoreni");
            cmbBoxType.Items.Add("Zatvoreni");

            List <Wine> wines = _mainController.GetAllWine();

            listWines.Items.Clear();
            foreach (Wine wine in wines)
            {
                ListViewItem listItem = new ListViewItem(wine.Name);
                listItem.SubItems.Add(wine.Type.ToString());
                listItem.SubItems.Add(wine.getLastContainer().ID.ToString());
                listItem.SubItems.Add(wine.Description);

                listWines.Items.Add(listItem);
            }

            List<Container> list = _mainController.GetEmptyContainers();
            List<Barrel> listEmptyBarrels = new List<Barrel>();
            foreach (Container container in list)
            {
                if (container is InoxBarrel || container is WoodenBarrel)
                {
                    listEmptyBarrels.Add(container as Barrel);
                }
            }

            listEmptyCont.Items.Clear();

            foreach (Barrel emptyBarrel in listEmptyBarrels)
            {
                ListViewItem listItem = new ListViewItem(emptyBarrel.ID.ToString());
                listItem.SubItems.Add(emptyBarrel.Manufacturer);
                listItem.SubItems.Add(emptyBarrel.Volume.ToString());

                listEmptyCont.Items.Add(listItem);
            }
            
            DialogResult result = this.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (listWines.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("Niste dobro definirali postavke za pretok.\nPokusajte ponovo", "Pogreška!");
                    return 0;
                }
                else if (listEmptyCont.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("Niste dobro definirali postavke za pretok.\nPokusajte ponovo", "Pogreška!");
                    return 0;
                }
                return 1;
            }
            return 0;
        }

        public string GetWineName()
        {
            string wineName = listWines.SelectedItems[0].Text;
            return wineName;
        }

        public int GetBarrel()
        {
            string barrelID = listEmptyCont.SelectedItems[0].Text;
            return Convert.ToInt32(barrelID);
        }

        public string GetChangeType()
        {
            return cmbBoxType.SelectedItem.ToString();
        }

        private void cmbBoxType_Validating(object sender, CancelEventArgs e)
        {
            if (cmbBoxType.SelectedIndex == -1)
            {
                MessageBox.Show("Odaberite tip pretoka");
                this.ActiveControl = cmbBoxType;
            }
        }

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
            this.cmbBoxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listWines = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listEmptyCont = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBoxType
            // 
            this.cmbBoxType.FormattingEnabled = true;
            this.cmbBoxType.Location = new System.Drawing.Point(12, 34);
            this.cmbBoxType.Name = "cmbBoxType";
            this.cmbBoxType.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxType.TabIndex = 0;
            this.cmbBoxType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbBoxType_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tip pretoka";
            // 
            // listWines
            // 
            this.listWines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.columnHeader1,
                this.columnHeader2,
                this.columnHeader3});
            this.listWines.FullRowSelect = true;
            this.listWines.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listWines.HideSelection = false;
            this.listWines.Location = new System.Drawing.Point(12, 62);
            this.listWines.Name = "listWines";
            this.listWines.Size = new System.Drawing.Size(173, 152);
            this.listWines.TabIndex = 2;
            this.listWines.UseCompatibleStateImageBehavior = false;
            this.listWines.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Bačva";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv vina";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sorta";
            // 
            // listEmptyCont
            // 
            this.listEmptyCont.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.columnHeader4,
                this.columnHeader5,
                this.columnHeader6});
            this.listEmptyCont.FullRowSelect = true;
            this.listEmptyCont.HideSelection = false;
            this.listEmptyCont.Location = new System.Drawing.Point(193, 62);
            this.listEmptyCont.Name = "listEmptyCont";
            this.listEmptyCont.Size = new System.Drawing.Size(173, 152);
            this.listEmptyCont.TabIndex = 3;
            this.listEmptyCont.UseCompatibleStateImageBehavior = false;
            this.listEmptyCont.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Proizvođač";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Zapremnina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "------->";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(193, 220);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Izvrši";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(291, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ChangeBarrelsForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(378, 252);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listEmptyCont);
            this.Controls.Add(this.listWines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxType);
            this.Name = "ChangeBarrelsForm";
            this.Text = "Pretakanje vina...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listWines;
        private System.Windows.Forms.ListView listEmptyCont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
