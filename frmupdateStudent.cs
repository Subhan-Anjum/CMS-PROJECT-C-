using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using signupapp.BL;
using signupapp.DL;

namespace signupapp
{
    public partial class frmupdateStudent : Form
    {
        private string path = "students.txt";
        public frmupdateStudent()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            student a = (student)dataGridView9.CurrentRow.DataBoundItem;
            if (dataGridView9.Columns["Edit"].Index == e.ColumnIndex)
            {
                try
                {
                    frmeditst b = new frmeditst(a);

                    b.ShowDialog();
                    studentDL.storealldataintofile(path);
                    Databind();
                }
                catch(Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
                
            }
        }

        private void frmupdateStudent_Load(object sender, EventArgs e)
        {
           // studentDL.read("students.txt");
            dataGridView9.DataSource = studentDL.Studentlist;
        }
        private void Databind()
        {
            dataGridView9.DataSource = null;
            dataGridView9.DataSource = studentDL.Studentlist;
            dataGridView9.Refresh();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            //frmnewsts a = new frmnewsts();
            //a.ShowDialog();
            //studentDL.storealldataintofile(path);
            //Databind();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmadmin a = new frmadmin();
            a.Show();
        }
        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
