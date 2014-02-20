using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CellarJournal.Controllers;

namespace CellarJournal.App
{
    public partial class AddWoodenBarrelForm : Form, IAddNewWoodenBarrelFrm
    {
        public AddWoodenBarrelForm()
        {
            InitializeComponent();
        }

        public int ShowEx()
        {
            DialogResult result = this.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (!ValidateChildren())
                    return 0;
                return 1;
            }
            return 0;
        }

        public int GetVolume()
        {
            if (txtBoxVolume.Text == "")
                return -1;
            return Convert.ToInt32(txtBoxVolume.Text);
        }

        public int GetMakeYear()
        {
            if (txtBoxYear.Text == "")
                return -1;
            else
                return Convert.ToInt32(txtBoxYear.Text);
        }

        public string GetWoodType()
        {
            return txtBoxWood.Text;
        }

        private void txtBoxVolume_Validating(object sender, CancelEventArgs e)
        {
            if (GetVolume() <= 0)
            {
                MessageBox.Show("Zapremnina mora biti veća od 0!", "Pogreška!");
                this.ActiveControl = txtBoxVolume;
            }
        }

        private void txtBoxYear_Validating(object sender, CancelEventArgs e)
        {
            if (GetMakeYear() <= 0)
            {
                MessageBox.Show("Neispravna godina!", "Pogreška!");
                this.ActiveControl = txtBoxYear;
            }
        }

        private void txtBoxWood_Validating(object sender, CancelEventArgs e)
        {
            if (GetWoodType() == "")
            {
                MessageBox.Show("Upisite tip drveta!", "Pogreška!");
                this.ActiveControl = txtBoxWood;
            }

        }
    }
}
