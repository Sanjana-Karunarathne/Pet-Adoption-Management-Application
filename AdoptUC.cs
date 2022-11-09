using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loveit_Org
{
    public partial class AdoptUC : UserControl
    {
        public AdoptUC()
        {
            InitializeComponent();
        }

        private void adoptPetsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adoptPetsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petsDatabaseDataSet);

        }

        private void contact_NumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
