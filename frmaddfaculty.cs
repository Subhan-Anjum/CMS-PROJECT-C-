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
    public partial class frmaddfaculty : Form
    {
        public frmaddfaculty()
        {
            InitializeComponent();
        }

        private void btnaddintolist_Click(object sender, EventArgs e)
        {
            string name, qualification, subject;
            int  age;
            if (txtaddfct.Text == "" || txtqual.Text == "" || txtsubject.Text == "" || txtagefct.Text == "")
            {
                MessageBox.Show("Enter All Credentials");
            }
            else if (faculty.checkalphabet(txtaddfct.Text) == false||faculty.checkalphabet(txtqual.Text)==false||faculty.checkalphabet(txtsubject.Text)==false)
            {
                MessageBox.Show("Enter Credentials in Correct Format");
            }
            else if(txtaddfct.Text != "" || txtqual.Text != "" || txtsubject.Text != "" || txtagefct.Text != "")
            {
                try
                {
                    name = txtaddfct.Text;
                    qualification = txtqual.Text;
                    subject = txtsubject.Text;
                    age = int.Parse(txtagefct.Text);
                    faculty datas = new faculty(name, qualification, subject, age);
                    if (faculty.isValidFaculty(datas) == true)
                    {
                        MessageBox.Show("Faculty data already Exists");
                    }
                    facultyDL.Facultylist.Add(datas);
                    MessageBox.Show("Data Submitted");
                    facultyDL.store(datas);
                }
                catch(Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            txtaddfct.Clear();
            txtqual.Clear();
            txtsubject.Clear();
            txtagefct.Clear();
           

        }

        private void frmaddfaculty_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgefct_Click(object sender, EventArgs e)
        {

        }

        private void txtaddfct_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtqual_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtagefct_TextChanged(object sender, EventArgs e)
        {
            decimal a;
            bool isValid = decimal.TryParse(txtagefct.Text, out a);
            if (isValid)
            {
                txtagefct.ForeColor = Color.Black;
            }
            else
            {
                txtagefct.ForeColor = Color.Red;
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
