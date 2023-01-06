using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signupapp
{
    public partial class frmupdatationmarks : Form
    {
        public frmupdatationmarks()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmadmin a = new frmadmin();
            a.Show();
        }

        private void frmupdatationmarks_Load(object sender, EventArgs e)
        {

        }
    }
}
