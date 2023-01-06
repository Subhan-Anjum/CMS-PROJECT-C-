using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using signupapp.DL;

namespace signupapp
{
    public partial class viewscholarships : Form
    {
        public viewscholarships()
        {
            InitializeComponent();
        }

        private void viewscholarships_Load(object sender, EventArgs e)
        {
            dataGridView6.DataSource = scolarshipDL.Scolarshiplist;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmadmin a = new frmadmin();
            a.Show();
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
