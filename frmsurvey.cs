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
    public partial class frmsurvey : Form
    {
        public frmsurvey()
        {
            InitializeComponent();
        }

        private void btnsur_Click(object sender, EventArgs e)
        {
            string n, s;
            if (student.checkalphabet(txtns.Text) == false||student.checkalphabet(txtsurvey.Text)==false)
            {
                MessageBox.Show("Enter Name in correct format");
            }
            else if (txtns.Text != username.name)
            {
                MessageBox.Show("You can give survey by only your name");
            }
            else
            {
                try
                {
                    n = txtns.Text;
                    s = txtsurvey.Text;
                    survey data = new survey(n, s);
                    if (survey.isValidname(data) == true)
                    {
                        MessageBox.Show("You have already given survey try later");
                    }
                    else
                    {
                        surveyDL.SurveyList.Add(data);
                        surveyDL.store(data);
                        MessageBox.Show("Submitted");
                    }
                    
                }
                catch(Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
           
            txtns.Clear();
            txtsurvey.Clear();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmstudent a = new frmstudent();
            a.Show();
        }

        private void frmsurvey_Load(object sender, EventArgs e)
        {

        }

        private void txtns_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
