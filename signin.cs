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
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
        public static int index=0;
        private void btnSignIn_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter All Credentials");
            }
            else
            {
                string UserName = txtUserName.Text;
                username.name = UserName;
                for (int i = 0; i < SignupDL.datalist.Count; i++)
                {
                    if (UserName == SignupDL.datalist[i].UserName1)
                    {
                        index = i;
                        break;
                    }
                }
                string Password = txtPassword.Text;

                signupBL obj = new signupBL(UserName, Password);
                //signupBL.isValid(obj);
                if (signupBL.Checksignin(obj) == 1)
                {
                  //  lblcrud.ForeColor = Color.Green;
                    MessageBox.Show("Congrats for logging in for admin") ;
                    this.Hide();
                    frmadmin a = new frmadmin();
                    a.Show();
                }
                if (signupBL.Checksignin(obj) == 2)
                {
                    // lblcrud.ForeColor = Color.Green;
                    MarksDL.read(signupBL.dataindex);
                    MessageBox.Show("Congrats for logging in for student");
                    this.Hide();
                    frmstudent b = new frmstudent();
                    b.Show();
                }
                if (signupBL.Checksignin(obj) !=1 && signupBL.Checksignin(obj)!=2)
                {
                    MessageBox.Show("Incorrect Id or Password");
                }
                txtUserName.Clear();
                txtPassword.Clear();
            }
        }

        private void lblshowreg_Click(object sender, EventArgs e)
        {
           
        }

        private void lblnavigation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 ob = new Form1();
            ob.Show();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnview.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
            else if (txtPassword.PasswordChar == '\0')
            {
                btnview.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmclg o = new frmclg();
            o.Show();
        }

        private void signin_Load(object sender, EventArgs e)
        {

        }
    }
    }

