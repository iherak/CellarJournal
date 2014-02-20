using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CellarJournal.Controllers;
using System.Windows.Forms;

namespace CellarJournal.App
{
    public partial class AddYearForm : Form, IAddNewYearFrm
    {
        public AddYearForm()
        {
            InitializeComponent();
        }


        public int ShowEx()
        {
            DialogResult result = this.ShowDialog();

            if (result == DialogResult.OK)
                return 1;
            else
            {
                return 0;
            }
        }

        public int GetYear()
        {
            int returnYear;
            if (Int32.TryParse(txtBoxYear.Text, out returnYear))
                return returnYear;
            else throw new InvalidExpressionException();
        }

        public void Error(string p)
        {
            MessageBox.Show("Upišite godinu!", "Pogreška!");
        }

        private void AddYearForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBoxYear;
        }
    }
}
