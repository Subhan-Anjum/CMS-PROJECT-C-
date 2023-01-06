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
    public partial class GenerateMarks : Form
    {
        public GenerateMarks()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbltotals_Click(object sender, EventArgs e)
        {
            
        }

        public static int id(string name)
        {
            int index = 0;
            for (int i = 0; i < SignupDL.datalist.Count; i++)
            {
                if (name== SignupDL.datalist[i].UserName1)
                {
                    index = i;
                    return index;
                }
            }
            return -1;
        }
        public static int idx = 0;

        private void btnadmarksintolist_Click(object sender, EventArgs e)
        {
            
            string name;
            float m1, m2, m3, m4, m5, m6, m7, m8;
            name = txtnamemarks.Text;
            
            try
            {
                m1 = float.Parse(txtoop.Text);
                m2 = float.Parse(txtdld.Text);
                m3 = float.Parse(txtpsy.Text);
                m4 = float.Parse(txtQT.Text);
                m5 = float.Parse(txtMVC.Text);
                m6 = float.Parse(txtst.Text);
                m7 = float.Parse(txtCS.Text);
                m8 = float.Parse(txttotals.Text);
                marks data = new marks(name, m1, m2, m3, m4, m5, m6, m7, m8);
                MarksDL.addintolist(data);
                int ind = id(name);
                MarksDL.store(ind,data);
                MessageBox.Show("Data submitted");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
          
          

            //MarksDL.store(data);
            txtoop.Clear();
            txtdld.Clear();
            txtpsy.Clear();
            txtQT.Clear();
            txtMVC.Clear();
            txtst.Clear();
            txtCS.Clear();
            txttotals.Clear();
            txtnamemarks.Clear();

        }
        public static int setidx()
        {
            return idx;
        }
        private void txtAPS_Load(object sender, EventArgs e)
        {

        }

        private void txttotals_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtoop_TextChanged(object sender, EventArgs e)
        {

                
        }

        private void txtdld_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtpsy_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtQT_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMVC_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtst_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtCS_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmadmin a = new frmadmin();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sum = 0.0F;
            try
            {
                sum = float.Parse(txtoop.Text) + float.Parse(txtdld.Text) + float.Parse(txtpsy.Text) + float.Parse(txtQT.Text) + float.Parse(txtCS.Text) + float.Parse(txtst.Text) + float.Parse(txtMVC.Text);

            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                txttotals.Text = sum.ToString();
                MessageBox.Show("Total Generated");

            }
        }
    }
}
