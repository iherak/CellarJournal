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
    public partial class JournalForm : Form, IJournalForm
    {
        private MainController _mainController;
        private string _wineName;

        private JournalForm()
        {
            InitializeComponent();
        }

        public JournalForm(MainController _mainController)
        {
            this._mainController = _mainController;
            InitializeComponent();
        }

        public int ShowEx()
        {
            Show();
            return 0;
        }

        public void UpdateEx()
        {
            List<KeyValuePair<DateTime, string>> activites = _mainController.GetActivites(_wineName);
            activites = activites.OrderByDescending(a => a.Key).ToList();

            dgvJournal.DataSource = activites;
        }

        public void ShowActivity()
        {
            dgvJournal.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.DataPropertyName = "Key";
            dateColumn.HeaderText = "Vrijeme";

            DataGridViewTextBoxColumn activityColumn = new DataGridViewTextBoxColumn();
            activityColumn.DataPropertyName = "Value";
            activityColumn.HeaderText = "Zapis";
            activityColumn.Width = 315;

            dgvJournal.Columns.Add(dateColumn);
            dgvJournal.Columns.Add(activityColumn);

            List<KeyValuePair<DateTime, string>> activites = _mainController.GetActivites(_wineName);
            activites = activites.OrderByDescending(a => a.Key).ToList();
            BindingList<KeyValuePair<DateTime, string>> bindingList = new BindingList<KeyValuePair<DateTime, string>>();
            foreach (KeyValuePair<DateTime, string> keyValuePair in activites)
            {
                bindingList.Add(keyValuePair);
            }
            dgvJournal.DataSource = bindingList;
        }

        public void ShowEx(string wineName)
        {
            _wineName = wineName;
            //ShowActivity();
            ShowEx();
        }

        private void JournalForm_Load(object sender, EventArgs e)
        {
            ShowActivity();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _mainController.AddActivity(_wineName, txtBoxNewEntry.Text);
            txtBoxNewEntry.Text = "";
        }
    }
}
