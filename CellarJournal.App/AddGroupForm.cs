using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CellarJournal.Controllers;
using CellarJournal.Model;
using CellarJournal.Utility;

namespace CellarJournal.App
{
    public partial class AddGroupForm : Form, IAddGroupForm
    {
        public AddGroupForm()
        {
            InitializeComponent();

            this.ActiveControl = txtBoxName;

            comboBoxWine.DataSource = Helper.GetEnumValues<WineTypes>(true);
            
            comboBoxBarrel.Items.Add("Inox");
            comboBoxBarrel.Items.Add("Drvena");
        }

        public int ShowEx()
        {
            DialogResult result = this.ShowDialog();

            if (result == DialogResult.OK)
            {
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
            if (comboBoxWine.SelectedItem != null)
            {
                WineTypes type;
                Enum.TryParse<WineTypes>(comboBoxWine.SelectedValue.ToString(), out type);
                return type;
            }
            else
                return WineTypes.NONE;

        }

        public string GetBarrelType()
        {
            if (comboBoxBarrel.SelectedItem == null)
                return "";
            return comboBoxBarrel.SelectedItem.ToString();
        }

        private void txtBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (txtBoxName.Text == "")
            {
                MessageBox.Show("Molimo upišite ime!", "Pogreška!", MessageBoxButtons.OK);
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtBoxName.Text == "")
            {
                MessageBox.Show("Molimo upišite ime!", "Pogreška!", MessageBoxButtons.OK);
            }
        }
    }
}
