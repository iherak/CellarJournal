using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CellarJournal.Controllers;
using CellarJournal.Model;

namespace CellarJournal.App
{
    public partial class MainWindowForm : Form, IMainForm
    {
        private MainController _mainController;

        public MainWindowForm()
        {
            InitializeComponent();
            _mainController = new MainController(this);
            _mainController.DefaultModel();
            panelGroups.Visible = false;
            panelGroups.Location = new Point(12, 79);
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            PrepareList();
            UpdateEx();
        }

        internal void PrepareList()
        {
            _mainController.UpdateList(this);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = _mainController._years;
            comboBoxYears.DataSource = bindingSource;
        }

        public void UpdateEx()
        {
            _mainController.UpdateList(this);
            UpdateGroup();
            _mainController.UpdateLabel(this);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = _mainController.GetGroupNames();
            comboBoxGroups.DataSource = bindingSource;
            
        }

        private void UpdateGroup()
        {
            List<Wine> wines = _mainController.GetGroupWines();
            if (wines != null)
            {
                listGroup.Items.Clear();
                foreach (Wine wine in wines)
                {
                    ListViewItem listItem = new ListViewItem(wine.Name);
                    listItem.SubItems.Add(wine.Type.ToString());
                    listItem.SubItems.Add(wine.getLastContainer().ID.ToString());
                    listItem.SubItems.Add(wine.Description);

                    listGroup.Items.Add(listItem);
                }
            }
        }

        public void Update(List<Wine> wines)
        {
            listWines.Items.Clear();
            foreach (Wine wine in wines)
            {
                ListViewItem listItem = new ListViewItem(wine.Name);
                listItem.SubItems.Add(wine.Type.ToString());
                listItem.SubItems.Add(wine.getLastContainer().ID.ToString());
                listItem.SubItems.Add(wine.Description);

                listWines.Items.Add(listItem);
            }
        }

        public void UpdateLabel(int emptyCont)
        {
            label1.Text = "Broj prazni bačvi: " + emptyCont.ToString();
        }

        private void comboBoxYears_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Int32.TryParse(comboBoxYears.SelectedItem.ToString(), out _mainController.activeYear);
            UpdateEx();
        }

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            _mainController.selectedGroup = comboBoxGroups.SelectedItem.ToString();
            UpdateGroup();
            if (_mainController.selectedGroup == "")
            {
                panel1.Visible = true;
                panelGroups.Visible = false;
            }
            else
            {
                panel1.Visible = false;
                panelGroups.Visible = true;
            }

        }

        private void novaBerbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddYearForm yearForm = new AddYearForm();
            _mainController.AddNewYear(yearForm);
            PrepareList();
            UpdateEx();
        }

        private void inoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInoxBarrelForm newInoxForm = new AddInoxBarrelForm();

            _mainController.AddInoxBarrel(newInoxForm);
        }

        private void drvenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWoodenBarrelForm newWoodenForm = new AddWoodenBarrelForm();

            _mainController.AddWoodenBarrel(newWoodenForm);
        }

        private void dodajVinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWineForm addWineForm = new AddWineForm();

            _mainController.AddWine(addWineForm);
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (listWines.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void dodajOpisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDescriptionForm addDescFrm = new AddDescriptionForm();

            string wineName = listWines.SelectedItems[0].Text;

            _mainController.AddDescription(addDescFrm, wineName);
        }

        private void label_Click(object sender, EventArgs e)
        {
            ShowListEmptyCont listForm = new ShowListEmptyCont(_mainController);

            _mainController.ShowList(listForm);
        }

        private void stvoriGrupuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGroupForm groupForm = new AddGroupForm();

            _mainController.CreateGroup(groupForm, this);
        }

        private void dnevnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string wineName = listWines.SelectedItems[0].Text;
            JournalForm journalForm = new JournalForm(_mainController);

            _mainController.Journal(journalForm, wineName);
        }

        private void nagradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string wineName = listWines.SelectedItems[0].Text;
            AwardsForm awardForm = new AwardsForm(_mainController);

            _mainController.Awards(awardForm, wineName);
        }

        private void poVinuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWineForm searchWineForm = new SearchWineForm(_mainController);

            _mainController.SearchWines(searchWineForm);
        }

        private void pretokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeBarrelsForm changeBarrelsForm = new ChangeBarrelsForm(_mainController);

            _mainController.ChangeBarrels(changeBarrelsForm);
        }

        private void listWines_DoubleClick(object sender, EventArgs e)
        {
            string wineName = listWines.SelectedItems[0].Text;
            JournalForm journalForm = new JournalForm(_mainController);

            _mainController.Journal(journalForm, wineName);
        }
    }
}
