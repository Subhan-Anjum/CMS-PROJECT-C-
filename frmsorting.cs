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
using signupapp.BL;

namespace signupapp
{
    public partial class frmsorting : Form
    {
        public frmsorting()
        {
            InitializeComponent();
        }

        private void frmsorting_Load(object sender, EventArgs e)
        {
            student.sorting();
            dataGridView4.DataSource = studentDL.Studentlist;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmadmin a = new frmadmin();
            a.Show();
        }
    }
}
