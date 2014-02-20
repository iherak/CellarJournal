using System;
using System.ComponentModel;
using System.Windows.Forms;
using CellarJournal.Controllers;
using CellarJournal.Model;

namespace CellarJournal.App
{
    public partial class AwardsForm : Form, IAwardForm
    {
        private MainController _mainController;
        private string _wineName;
        private bool _error = false;

        private AwardsForm()
        {
            InitializeComponent();
        }

        public AwardsForm(MainController _mainController)
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
            BindingList<Award> awards = new BindingList<Award>(_mainController.GetAwardsInfo(_wineName));

            dgvAwards.DataSource = awards;
        }

        public void ShowEx(string wineName)
        {
            _wineName = wineName;
            comboBox1.DataSource = Enum.GetValues(typeof(MedalTypes));
            ShowEx();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime time = dateTimePicker1.Value;
            string location = txtBoxPlace.Text;
            string info = txtBoxInfo.Text;
            MedalTypes medal;
            Enum.TryParse(comboBox1.SelectedValue.ToString(), out medal);
            
            if(!ValidateChildren())
                return;

            if(!_error)
                _mainController.AddAward(_wineName, time, location, info, medal);
        }

        private void AwardsForm_Load(object sender, EventArgs e)
        {
            ShowResults();
        }

        private void ShowResults()
        {
            dgvAwards.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.DataPropertyName = "Date";
            dateColumn.HeaderText = "Vrijeme";
            dateColumn.ReadOnly = true;

            DataGridViewTextBoxColumn locationColumn = new DataGridViewTextBoxColumn();
            locationColumn.DataPropertyName = "Location";
            locationColumn.HeaderText = "Mjesto";
            locationColumn.ReadOnly = true;

            //TODO: set it as a combobox
            /**DataGridViewTextBoxColumn medalColumn = new DataGridViewTextBoxColumn();
            medalColumn.DataPropertyName = "Medal";
            medalColumn.HeaderText = "Medalja";**/

            DataGridViewTextBoxColumn infoColumn = new DataGridViewTextBoxColumn();
            infoColumn.DataPropertyName = "OtherInfo";
            infoColumn.HeaderText = "Dodatni podaci";
            infoColumn.Width = 215;

            /*DataGridViewComboBoxColumn medalCell = new DataGridViewComboBoxColumn();
            medalCell.DataSource = Enum.GetValues(typeof(MedalTypes));
            medalCell.DisplayMember = "Medal";
            medalCell.ValueMember = "Medal";
            medalCell.HeaderText = "Medalja";*/

            dgvAwards.Columns.Add(dateColumn);
            dgvAwards.Columns.Add(locationColumn);
            //dgvAwards.Columns.Add(medalCell);
            dgvAwards.Columns.Add(infoColumn);

            BindingList<Award> awards = new BindingList<Award>(_mainController.GetAwardsInfo(_wineName));

            dgvAwards.DataSource = awards;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxPlace_Validating(object sender, CancelEventArgs e)
        {
            if (txtBoxPlace.Text == "")
            {
                MessageBox.Show("Upišite mjesto!", "Pogreška!");
                _error = true;
            }
            else
            {
                _error = false;
            }
        }
    }
}
