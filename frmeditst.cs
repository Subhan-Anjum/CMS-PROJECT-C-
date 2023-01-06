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
    public partial class frmeditst : Form
    {
        private student previous;
       
        public frmeditst(student previous)
        {
            InitializeComponent();
            this.previous = previous;
            //this.Close();
        }


        private void btnaddintolist_Click(object sender, EventArgs e)
        {
            if (txtaddst.Text == "" || txtmmarks.Text == "" || txtcnic.Text == "" || txtage.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Enter All Credentials");
            }
            else if (student.checkalphabet(txtaddst.Text) == false)
            {
                MessageBox.Show("Do not  use special characters");
            }

            else if (int.Parse(txtage.Text) == 0 || int.Parse(txtage.Text) == -1)
            {
                MessageBox.Show("Invalid Age");
            }
            else if (int.Parse(txtage.Text) < 15)
            {
                MessageBox.Show("Age is not valid to take admission in College");
            }

            else if (student.checkcnic(long.Parse(txtcnic.Text)) != 13)
            {
                MessageBox.Show("Enter Complete Cnic number");
            }
            else if (float.Parse(txtmmarks.Text) < 0)
            {
                MessageBox.Show("Invalid Matric Marks");
            }
            else if (float.Parse(txtmmarks.Text) < 550)
            {
                MessageBox.Show("Marks Must be atleast 50% to take admission");
            }
            else
            {
                student updated = new student(txtaddst.Text, float.Parse(txtmmarks.Text), long.Parse(txtcnic.Text), int.Parse(txtage.Text), comboBox1.Text);
                studentDL.editstudentfromlist(previous, updated);
                this.Close();
            }
           
        }

        private void frmeditst_Load(object sender, EventArgs e)
        {
            txtaddst.Text = previous.Name;
            txtmmarks.Text = previous.Matric.ToString();
            txtcnic.Text = previous.Cnic.ToString();
            txtage.Text = previous.Age.ToString();
            comboBox1.Text = previous.Course;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmadmin a = new frmadmin();
            a.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcnic_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmmarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddst_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
