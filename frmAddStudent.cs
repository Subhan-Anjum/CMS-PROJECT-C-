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
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnaddintolist_Click(object sender, EventArgs e)
        {
            string name1, course1;
            float matric1;
            long cnic1;
            int age1;
            if (txtaddst.Text == "" || txtmmarks.Text == "" || txtcnic.Text == "" || txtage.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Enter All Credentials");
            }
            else if (student.checkalphabet(txtaddst.Text) == false)
            {
                MessageBox.Show("Do not  use special characters");
            }

            else if (int.Parse(txtage.Text)==0|| int.Parse(txtage.Text)==-1)
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
            else if (txtmmarks.ForeColor == Color.Black && txtage.ForeColor == Color.Black)
            {
                name1 = txtaddst.Text;
                matric1 = float.Parse(txtmmarks.Text);
                cnic1 = long.Parse(txtcnic.Text);
                age1 = int.Parse(txtage.Text);
                course1 = comboBox1.Text;
                student data = new student(name1, matric1, cnic1, age1, course1);
                if (student.isValidStudent(data) == true)
                {
                    MessageBox.Show("Student data already Exists");
                    txtaddst.Clear();
                    txtmmarks.Clear();
                    txtcnic.Clear();
                    txtage.Clear();
                    comboBox1.Text = "";
                }
                else
                {
                    studentDL.Studentlist.Add(data);
                    MessageBox.Show("Data Submitted");
                    studentDL.store(data);
                    txtaddst.Clear();
                    txtmmarks.Clear();
                    txtcnic.Clear();
                    txtage.Clear();
                    comboBox1.Text = "";
                }
              
            }
            else
            {
                MessageBox.Show("Not Submitted");
            }
                //this.Hide(); 
                //frmadmin a = new frmadmin();
                //a.Show();
         //   }
          



        }

        private void txtaddst_TextChanged(object sender, EventArgs e)
        {
           /* if (txtaddst.Text == "")
            {
                txtaddst.Text = "Enter Your Name";
            }
            else
            {
                txtaddst.Text = "";
            }*/
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {

        }

        private void txtcnic_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtmmarks_TextChanged(object sender, EventArgs e)
        {
            decimal a;
            bool isValid = decimal.TryParse(txtmmarks.Text, out a);
            if (isValid)
            {
                txtmmarks.ForeColor = Color.Black;
            }
            else
            {
                txtmmarks.ForeColor = Color.Red;
            }
        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {
            decimal a;
            bool isValid = decimal.TryParse(txtage.Text, out a);
            if (isValid)
            {
                txtage.ForeColor = Color.Black;
            }
            else
            {
               txtage.ForeColor = Color.Red;
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
