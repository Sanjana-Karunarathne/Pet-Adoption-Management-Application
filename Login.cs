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
    public partial class Loginfrm : Form
    {
        public Loginfrm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard ds = new Dashboard("Guest");
            ds.Show();
            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(usernametxt.Text=="admin" && passwordtxt.Text=="1234")
            {
                Dashboard ds = new Dashboard("admin");
                ds.Show();
                this.Hide();
            }
        }
    }
}
