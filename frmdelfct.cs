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
    public partial class frmdelfct : Form
    {
        public frmdelfct()
        {
            InitializeComponent();
        }

        private void frmdelfct_Load(object sender, EventArgs e)
        {
            dataGridView9.DataSource = facultyDL.Facultylist;
        }
        private void Databind()
        {
            dataGridView9.DataSource = null;
            dataGridView9.DataSource = facultyDL.Facultylist;
            dataGridView9.Refresh();
        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            faculty b = (faculty)dataGridView9.CurrentRow.DataBoundItem;
            if (dataGridView9.Columns["Delete"].Index == e.ColumnIndex)
            {
                facultyDL.deletefacultyfromfile(b);
                facultyDL.storealldataintofile();
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
