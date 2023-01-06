using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using signupapp;

namespace signupapp
{
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            InitializeComponent();
        }

        private void btnaddstudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddStudent a = new frmAddStudent();
            a.Show();
        }

        private void btnaddfaculty_Click(object sender, EventArgs e)
        {
           
        }

        private void btndmc_Click(object sender, EventArgs e)
        {

        }

        private void btndispst_Click(object sender, EventArgs e)
        {
            
        }

        private void dispfct_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btngeneratefeechallan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fee challan Created for Students");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {

        }

        private void btnrmst_Click(object sender, EventArgs e)
        {

        }

        private void btnupdatemarks_Click(object sender, EventArgs e)
        {

        }

        private void btnviewsurvey_Click(object sender, EventArgs e)
        {

        }

        private void btnviewforms_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdatestinfo_Click(object sender, EventArgs e)
        {

        }

        private void btnrmfct_Click(object sender, EventArgs e)
        {

        }

        private void btnsorting_Click(object sender, EventArgs e)
        {

        }

        private void btnviewregisterd_Click(object sender, EventArgs e)
        {

        }

        private void frmadmin_Load(object sender, EventArgs e)
        {

        }

        private void btnsorting_Click_1(object sender, EventArgs e)
        {

        }

        private void btnrmst_Click_1(object sender, EventArgs e)
        {

        }

        private void btnaddfaculty_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUpdatestinfo_Click_1(object sender, EventArgs e)
        {

        }

        private void btnrmfct_Click_1(object sender, EventArgs e)
        {

        }

        private void btnaddstudent_Click_1(object sender, EventArgs e)
        {

        }

        private void btndispst_Click_1(object sender, EventArgs e)
        {

        }

        private void dispfct_Click_1(object sender, EventArgs e)
        {

        }

        private void btnviewregisterd_Click_1(object sender, EventArgs e)
        {

        }

        private void btndmc_Click_1(object sender, EventArgs e)
        {

        }

        private void btnaddstudent_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            frmAddStudent a = new frmAddStudent();
            a.Show();
        }

        private void btndmc_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            GenerateMarks a = new GenerateMarks();
            a.Show();
            
        }

        private void btnaddfaculty_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            frmaddfaculty a = new frmaddfaculty();
            a.Show();
        }

        private void btndispst_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            DisplayStu a = new DisplayStu();
            a.Show();
        }

        private void dispfct_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Displayfct a = new Displayfct();
            a.Show();
        }

        private void btnsorting_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            frmsorting a = new frmsorting();
            a.Show();
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmclg a = new frmclg();
            a.Show();
        }

        private void btnviewsurvey_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmviewsurveys a = new frmviewsurveys();
            a.Show();
        }

        private void btnviewforms_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            viewscholarships a = new viewscholarships();
            a.Show();
        }

        private void btnupdatemarks_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            updatemarks a = new updatemarks();
            a.Show();

        }

        private void btnrmst_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            frmdelst a = new frmdelst();
            a.Show();
        }

        private void btngeneratefeechallan_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Fee challan of Rs 57,278 has been created for students");
        }

        private void btnrmfct_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            frmdelfct a = new frmdelfct();
            a.Show();
        }

        private void btnUpdatestinfo_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            frmupdateStudent a = new frmupdateStudent();
            a.Show();
        }

        private void btnviewregisterd_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form2 a = new Form2();
            a.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
