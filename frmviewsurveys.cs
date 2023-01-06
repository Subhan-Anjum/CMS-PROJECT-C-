using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using signupapp.DL;

namespace signupapp
{
    public partial class frmviewsurveys : Form
    {
        public frmviewsurveys()
        {
            InitializeComponent();
        }

        private void frmviewsurveys_Load(object sender, EventArgs e)
        {
            dataGridView5.DataSource = surveyDL.SurveyList;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmadmin a = new frmadmin();
            a.Show();
        }
    }
}
