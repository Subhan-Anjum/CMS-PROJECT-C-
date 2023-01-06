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
    public partial class scolarshipdata : Form
    {
        public scolarshipdata()
        {
            InitializeComponent();
        }

        private void txtaddstf_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtgpa_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtfather_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txttype_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnaddsco_Click(object sender, EventArgs e)
        {
            
            string n, f, t,i;
            float g;
            if (txtaddstf.Text == "" || txtgpa.Text == "" || txtfather.Text == "" || txttype.Text == "")
            {
                MessageBox.Show("Enter All Information");
            }
            else if (student.checkalphabet(txtaddstf.Text) == false)
            {
                MessageBox.Show("Enter name in correct form");
            }
            else if(txtaddstf.Text!= username.name)
            {
                MessageBox.Show("you can apply only by your name");
            }
            else
            {
                try
                {
                    n = txtaddstf.Text;
                    g = float.Parse(txtgpa.Text);
                    f = txtfather.Text;
                    t = txttype.Text;
                    i = "has applied for scholarship";
                    scolarship data = new scolarship(n, g, f, t, i);
                    if (scolarship.isValidname(data) == true)
                    {
                        MessageBox.Show("You have applied for it already");
                    }
                    else
                    {
                        scolarshipDL.Scolarshiplist.Add(data);
                        scolarshipDL.store(data);
                    }
                   
                }
                catch(Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
               
            }
            
         
            txtaddstf.Clear();
            txtgpa.Clear();
            txtfather.Text = "";
            txttype.Text = "";

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmadmin a = new frmadmin();
            a.Show();
        }
    }
}
