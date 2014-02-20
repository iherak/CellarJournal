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
    public partial class AddInoxBarrelForm : Form, IAddNewBarrelFrm
    {
        public AddInoxBarrelForm()
        {
            InitializeComponent();
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

        public int GetVolume()
        {
            if(txtBoxVolume.Text!="")
                return Convert.ToInt32(txtBoxVolume.Text);
            return -1;
        }

        private void AddInoxBarrelForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBoxVolume;
        }

        private void txtBoxVolume_Validating(object sender, CancelEventArgs e)
        {
            if (GetVolume() <= 0)
            {
                MessageBox.Show("Zapremnina mora biti veća od 0!", "Pogreška!");
            }
        }
    }
}
