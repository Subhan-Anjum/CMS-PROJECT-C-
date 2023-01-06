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
    public partial class DisplayStu : Form
    {
        
        public DisplayStu()
        {
            
            InitializeComponent();
        }

        private void DisplayStu_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = studentDL.Studentlist;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmadmin a = new frmadmin();
            a.Show();
        }
    }
}
