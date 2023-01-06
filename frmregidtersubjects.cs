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
    public partial class frmregidtersubjects : Form
    {
        public frmregidtersubjects()
        {
            InitializeComponent();
        }

        private void frmregidtersubjects_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string n, s1, s2, s3, s4, s5, s6, s7;
            if (txtnamerst.Text == "")
            {
                MessageBox.Show("Enter Name plz");
            }
            else if (student.checkalphabet(txtnamerst.Text) == false)
            {
                MessageBox.Show("Enter Nmae in Correct Format");
            }
             else if (txtnamerst.Text != username.name)
            {
                MessageBox.Show("You can register by only your name");
            }
            else if (chckoop.Checked == false || chckdld.Checked == false || chckpsy.Checked == false || chckmvc.Checked == false || chckqt.Checked == false || chckaps.Checked == false || chckcs.Checked == false)
            {
                MessageBox.Show("You have to register All Subjects");
            }
            else
            {


                n = txtnamerst.Text;
                s1 = chckoop.Text;
                s2 = chckdld.Text;
                s3 = chckpsy.Text;
                s4 = chckmvc.Text;
                s5 = chckqt.Text;
                s6 = chckaps.Text;
                s7 = chckcs.Text;
                subjects data = new subjects(n, s1, s2, s3, s4, s5, s6, s7);
                subjectsDL.Subjectlist.Add(data);
                MessageBox.Show("Registered!");
                subjectsDL.store(data);
            }

        }

        private void btnprvs_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmstudent a = new frmstudent();
            a.Show();
        }
    }
}
