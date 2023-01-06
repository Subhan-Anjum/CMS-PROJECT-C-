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
    public partial class studentviewForm : Form
    {
        private string path = "students.txt";
        public studentviewForm()
        {
            InitializeComponent();
        }

        private void studentviewForm_Load(object sender, EventArgs e)
        {
            studentDL.read(path);
            dataGridView1.DataSource = studentDL.Studentlist;


        }
        public void databind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = studentDL.Studentlist;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
