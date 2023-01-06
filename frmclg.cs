using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signupapp
{
    public partial class frmclg : Form
    {
        public frmclg()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 b = new Form1();
            b.Show();

        }

        private void Loginbtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signin s = new signin();
            s.Show();
        }

        private void frmclg_Load(object sender, EventArgs e)
        {

        }
    }
}
