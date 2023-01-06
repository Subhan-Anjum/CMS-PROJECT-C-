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
    public partial class frmviewmarks : Form
    {
        public frmviewmarks()
        {
            InitializeComponent();
        }

        private void frmviewmarks_Load(object sender, EventArgs e)
        {
            // label2.Text = signupBL.idx.ToString();
            //dataGridView3.DataSource=null;
            dataGridView3.DataSource = SignupDL.datalist[signupBL.dataindex].studentsdata;
        }

        private void btnprvs_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmstudent a = new frmstudent();
            a.Show();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
