using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using signupapp.DL;

namespace signupapp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string signpath = "login.txt";
            SignupDL.read(signpath);
            string path = "students.txt";
            string path1 = "faculty.txt";
           // string path2 = "marks.txt";
            string path3 = "survey.txt";
            string path4 = "scholarship.txt";
            string path5 = "subjects.txt";
            studentDL.read(path); 
            facultyDL.read(path1);
            //MarksDL.read(path2);
            surveyDL.read(path3);
            scolarshipDL.read(path4);
            subjectsDL.read(path5);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmclg());
        }
    }
}
