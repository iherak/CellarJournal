using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CellarJournal.Controllers;
using CellarJournal.Model;

namespace CellarJournal.App
{
    public partial class AddWineForm : Form, IAddNewWineFrm
    {
        public AddWineForm()
        {
            InitializeComponent();
        }

        public int ShowEx()
        {
            throw new Exception();
        }

        public int ShowEx(List<Container> emptyContainers)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = emptyContainers;
            cmbBoxContainer.DisplayMember = "ID";
            cmbBoxContainer.DataSource = bindingSource;

            this.ActiveControl = txtBoxName;

            cmbBoxType.DataSource = Enum.GetValues(typeof (WineTypes));

            DialogResult result = this.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (GetWineType() == WineTypes.NONE)
                {
                    throw new NoWineTypeSelectedException();
                }
                return 1;
            }
            return 0;
        }

        public string GetName()
        {
            return txtBoxName.Text;
        }

        public WineTypes GetWineType()
        {
            WineTypes type;
            Enum.TryParse<WineTypes>(cmbBoxType.SelectedValue.ToString(), out type);
            return type;
        }

        public Container GetContainer()
        {
            return cmbBoxContainer.SelectedItem as Container;
        }

        public string GetDescription()
        {
            return txtBoxDescription.Text;
        }

        public void ErrorReport(Exception ex)
        {
            MessageBox.Show("Pogreska!\nPogledati log za detalje", "Pogreska!");

            //TODO: dodati logger klasu!
        }

        private void txtBoxName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (GetName() == "")
            {
                MessageBox.Show("Upisite zeljeni naziv.", "Pogreška!");
                this.ActiveControl = txtBoxName;
            }
        }

        private void cmbBoxType_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (GetWineType() == WineTypes.NONE)
            {
                MessageBox.Show("Odaberite sortu!", "Pogreška!");
                this.ActiveControl = cmbBoxType;
            }
        }
    }
}
