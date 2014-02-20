using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CellarJournal.Controllers;
using System.Windows.Forms;
using CellarJournal.Model;
using Container = CellarJournal.Model.Container;

namespace CellarJournal.App
{
    public partial class ShowListEmptyCont : Form, IListEmptyContainers
    {
        private MainController _controller;

        public ShowListEmptyCont(MainController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        public int ShowEx()
        {
            this.Show();
            return 0;
        }

        public void UpdateEx()
        {
            ShowEmptyContainers();
        }

        private void ShowEmptyContainers()
        {
            gridViewEmptyBarr.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn IDColumn = new DataGridViewTextBoxColumn();
            IDColumn.DataPropertyName = "ID";
            IDColumn.HeaderText = "ID";

            DataGridViewTextBoxColumn ManuColumn = new DataGridViewTextBoxColumn();
            ManuColumn.DataPropertyName = "Manufacturer";
            ManuColumn.HeaderText = "Proizvođač";

            DataGridViewTextBoxColumn VolumeColumn = new DataGridViewTextBoxColumn();
            VolumeColumn.DataPropertyName = "Volume";
            VolumeColumn.HeaderText = "Zapremnina";

            gridViewEmptyBarr.Columns.Add(IDColumn);
            gridViewEmptyBarr.Columns.Add(ManuColumn);
            gridViewEmptyBarr.Columns.Add(VolumeColumn);

            List<Container> emptyContainers = _controller.GetEmptyContainers();
            BindingList<Barrel> barrels =new BindingList<Barrel>();

            foreach (Container emptyContainer in emptyContainers)
            {
                if (emptyContainer is Barrel)
                    barrels.Add(emptyContainer as Barrel);
            }
            gridViewEmptyBarr.DataSource = barrels;
        }

        private void ShowListEmptyCont_Load(object sender, EventArgs e)
        {
            ShowEmptyContainers();
        }
    }
}
