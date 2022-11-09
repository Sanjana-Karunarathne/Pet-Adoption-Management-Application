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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(string user)
        {
            InitializeComponent();
            if(user== "Guest")
            {
                addbtn.Hide();
            }
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            viewUC1.Visible = true;
            viewUC1.BringToFront();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            addPetUC1.Visible = true;
            addPetUC1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            viewUC1.Visible = false;
            addPetUC1.Visible = false;
            adoptUC1.Visible = false;
            updateUC1.Visible = false;
            contactUC1.Visible = false;
        }

        private void adoptbtn_Click(object sender, EventArgs e)
        {
            adoptUC1.Visible = true;
            adoptUC1.BringToFront();
        }

        private void loglink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Loginfrm lgn = new Loginfrm();
            this.Hide();
            lgn.Show();
        }

        private void donatebtn_Click(object sender, EventArgs e)
        {
            updateUC1.Visible = true;
            updateUC1.BringToFront();
        }

        private void contactbtn_Click(object sender, EventArgs e)
        {
            contactUC1.Visible = true;
            contactUC1.BringToFront();
        }
    }
}
