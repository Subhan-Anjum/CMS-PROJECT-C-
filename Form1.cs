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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text == "" || txtPassword.Text == "" || comboBoxsignup.Text == "")
            {
                MessageBox.Show("Enter All Credentials");
            }
            else
            {
                string UserName = txtUserName.Text;
                string Password = txtPassword.Text;
                string Role = comboBoxsignup.Text;

                signupBL obj = new signupBL(UserName, Password, Role);
                if (signupBL.isValid(obj) == true)
                {
                    MessageBox.Show("User Already Exists");
                }

                else
                {      
                    MessageBox.Show("You have registered Successfully");
                    SignupDL.adduserintolist(obj);
                    SignupDL.store(obj);
                    this.Show();

                }
                txtUserName.Clear();
                txtPassword.Clear();
                comboBoxsignup.Text="";


            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lblshowreg_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signin ob = new signin();
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

        private void lblfillall_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmclg o = new frmclg();
            o.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
