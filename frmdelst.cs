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
    public partial class frmdelst : Form
    {
        public string path = "students.txt";
        public frmdelst()
        {
            InitializeComponent();
        }

        private void frmdelst_Load(object sender, EventArgs e)
        {
            dataGridView8.DataSource = studentDL.Studentlist;
        }
        private void Databind()
        {
            dataGridView8.DataSource = null;
            dataGridView8.DataSource = studentDL.Studentlist;
            dataGridView8.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            student a = (student)dataGridView8.CurrentRow.DataBoundItem;
            if (dataGridView8.Columns["Delete"].Index == e.ColumnIndex)
            {
                studentDL.deletestudentfromfile(a);
                studentDL.storealldataintofile(path);
                Databind();
                MessageBox.Show("Deleted Successfully");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmadmin a = new frmadmin();
            a.Show();
        }
    }
}
