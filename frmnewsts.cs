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
    public partial class frmnewsts : Form
    {
        public frmnewsts()
        {
            InitializeComponent();
        }

        private void btnaddintolist_Click(object sender, EventArgs e)
        {
            student a = new student(txtaddst.Text, float.Parse(txtmmarks.Text), long.Parse(txtcnic.Text), int.Parse(txtage.Text), comboBox1.Text);
            studentDL.Studentlist.Add(a);
        }
    }
}
