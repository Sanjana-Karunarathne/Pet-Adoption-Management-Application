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
    public partial class AddPetUC : UserControl
    {
        public AddPetUC()
        {
            InitializeComponent();
        }

        private void addPetsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addPetsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petsDatabaseDataSet);

        }

        private void addPetsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.addPetsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petsDatabaseDataSet);

        }

        private void photobtn_Click(object sender, EventArgs e)
        {
            photoOpenDialog.FileName = "";
            if (photoOpenDialog.ShowDialog() == DialogResult.OK)
            {
                photoPictureBox.Image = Image.FromFile(photoOpenDialog.FileName);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            addPetsBindingSource.CancelEdit();
        }

        private void addPetsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
