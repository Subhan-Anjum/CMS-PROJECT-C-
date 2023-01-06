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
    public partial class frmstudent : Form
    {
        public frmstudent()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmclg a = new frmclg();
            a.Show();
        }

        private void btnviewChallan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChallan a = new frmChallan();
            a.Show();
        }

        private void btncheckmarks_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmviewmarks a = new frmviewmarks();
            a.Show();
        }

        private void btngivesurvey_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmsurvey a = new frmsurvey();
            a.Show();
        }

        private void btnapplyscolarship_Click(object sender, EventArgs e)
        {
            this.Hide();
            scolarshipdata a = new scolarshipdata();
            a.Show();
        }

        private void frmstudent_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterCourses_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmregidtersubjects a = new frmregidtersubjects();
            a.Show();
        }
    }
}
