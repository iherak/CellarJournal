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

namespace CellarJournal.App
{
    public partial class SearchWineForm : Form, ISearchWineFrm
    {
        private MainController _mainController;
        private List<Wine> list = null;
        private WineTypes typeSelected;
        private bool _initialize = true;

        private SearchWineForm()
        {
            InitializeComponent();
        }

        public SearchWineForm(MainController mainController)
        {
            InitializeComponent();
            _mainController = mainController;
            UpdateEx();
        }

        public int ShowEx()
        {
            this.Show();
            return 0;
        }

        public void UpdateEx()
        {
            if (_initialize)
            {
                cmBoxWineType.DataSource = Enum.GetValues(typeof (WineTypes));
                _initialize = false;
            }

            listWines.Items.Clear();
            if (list == null) return;
            list = _mainController.GetWineByType(typeSelected);
            foreach (Wine wine in list)
            {
                ListViewItem listItem = new ListViewItem(wine.Name);
                listItem.SubItems.Add(wine.Type.ToString());
                listItem.SubItems.Add(wine.getLastContainer().ID.ToString());
                listItem.SubItems.Add(wine.Description);

                listWines.Items.Add(listItem);
            }
        }

        private void cmBoxWineType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<WineTypes>(cmBoxWineType.SelectedValue.ToString(), out typeSelected);
            list = _mainController.GetWineByType(typeSelected);
            UpdateEx();
        }

        private void SearchWineForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _initialize = true;
        }
    }
}
