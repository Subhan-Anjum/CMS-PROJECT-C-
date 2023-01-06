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
    public partial class updatemarks : Form
    {
        public updatemarks()
        {
            InitializeComponent();
        }

        private void btnadmarksintolist_Click(object sender, EventArgs e)
        {
            //string name;
            //float m1, m2, m3, m4, m5, m6, m7, m8;
            //name = txtnamemarks.Text;
            //m1 = float.Parse(txtoop.Text);
            //m2 = float.Parse(txtdld.Text);
            //m3 = float.Parse(txtpsy.Text);
            //m4 = float.Parse(txtQT.Text);
            //m5 = float.Parse(txtMVC.Text);
            //m6 = float.Parse(txtst.Text);
            //m7 = float.Parse(txtCS.Text);
            //m8 = float.Parse(txttotals.Text);
            //marks data = new marks(name, m1, m2, m3, m4, m5, m6, m7, m8);
            //MarksDL.Markslist.Add(data);
            //dataGridView7.Rows.Add(name, m1, m2, m3, m4, m5, m6, m7, m8);   
            
            //txtnamemarks.Text = "";
            //txtoop.Text = "";
            //txtdld.Text = "";
            //txtpsy.Text = "";
            //txtQT.Text = "";
            //txtMVC.Text = "";
            //txtst.Text = "";
            //txtCS.Text = "";
            //txttotals.Text = "";

        }
        private  void Databind()
        {
            dataGridView7.DataSource = null;
            dataGridView7.DataSource = MarksDL.Markslist;
            dataGridView7.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //float sum = 0.0F;
            //sum = float.Parse(txtoop.Text) + float.Parse(txtdld.Text) + float.Parse(txtpsy.Text) + float.Parse(txtQT.Text) + float.Parse(txtCS.Text) + float.Parse(txtst.Text) + float.Parse(txtMVC.Text);
            //txttotals.Text = sum.ToString();
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            marks marked = (marks)dataGridView7.CurrentRow.DataBoundItem;
            if (dataGridView7.Columns["Delete"].Index == e.ColumnIndex)
            {
                MarksDL.delemarks(marked);
                Databind();
            }
            else if (dataGridView7.Columns["Edit"].Index == e.ColumnIndex)
            {
               // frmupdatationmarks frm = new frmupdatationmarks(marked);
            }
        }

        private void updatemarks_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data.Columns.Add("Name");
            data.Columns.Add("Oop");
            data.Columns.Add("Dld");
            data.Columns.Add("Psy");
            data.Columns.Add("Qt");
            data.Columns.Add("MVc");
            data.Columns.Add("Aps");
            data.Columns.Add("Cs");
            data.Columns.Add("Total");
            for(int i=0; i<SignupDL.datalist[signupBL.dataindex].studentsdata.Count; i++)
            {
                data.Rows.Add(MarksDL.Markslist[i].Name, MarksDL.Markslist[i].Oop, MarksDL.Markslist[i].Dld, MarksDL.Markslist[i].Psychology, MarksDL.Markslist[i].Qt, MarksDL.Markslist[i].Mvc, MarksDL.Markslist[i].Aps, MarksDL.Markslist[i].Cs, MarksDL.Markslist[i].Total);
            }






            // dataGridView3.DataSource = SignupDL.datalist[signupBL.idx].studentsdata;
            //dataGridView7.DataSource = SignupDL.datalist[GenerateMarks.setidx()].studentsdata;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmadmin a = new frmadmin();
            a.Show();
        }
    }
}
