using System.Windows.Forms;
using CellarJournal.Controllers;

namespace CellarJournal.App
{
    public partial class AddDescriptionForm : Form, IAddDescriptionFrm
    {
        public AddDescriptionForm()
        {
            InitializeComponent();
        }

        public int ShowEx()
        {
            this.ActiveControl = txtBoxDesc;

            DialogResult result = this.ShowDialog();

            if (result == DialogResult.OK)
                return 1;
            else
            {
                return 0;
            }
        }

        public string GetDescription()
        {
            return txtBoxDesc.Text;
        }
    }
}
