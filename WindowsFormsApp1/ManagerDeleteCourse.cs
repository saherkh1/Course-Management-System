using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class ManagerDeleteCourse : Form
    {
        public ManagerDeleteCourse()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerMain mm= new ManagerMain();
            mm.Show();
        }
        private bool iscourse(string course_name)
        {
            StreamReader sr = new StreamReader("course.txt");

            string line = sr.ReadLine();
            string[] details = line.Split(' ');
            while (line != null)
            {
                if (course_name == details[0])
                {
                    sr.Close();
                    return false;
                }
                line = sr.ReadLine();
                if (line != "" && line != null)
                {
                    details = line.Split(' ');
                }

            }
            sr.Close();
            return true;
        }

        private void Deletecourse_btn_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("course.txt");
            string line1 = sr.ReadLine();
            if (line1 == null)
            {
                wrongname_lbl.ForeColor = System.Drawing.Color.Red;
                wrongname_lbl.Text = "File Empty";

            }
            string[] details = line1.Split(' ');
            string[] cs_details = line1.Split();
            sr.Close();
            string course_name = coursename_txt.Text;

            if (!(iscourse(course_name)))
            {

                string[] Lines = File.ReadAllLines("course.txt");

                File.Delete("course.txt");// Deleting the file
                using (StreamWriter sw = File.AppendText("course.txt"))


                    foreach (string line in Lines)
                    {
                        if (line.IndexOf(course_name) >= 0)
                        {
                            //Skip the line
                            continue;
                        }
                        else
                        {
                            sw.WriteLine(line);
                        }
                    }
                wrongname_lbl.ForeColor = System.Drawing.Color.Black;
                wrongname_lbl.Text = "Deleted";
            }
            else
            {
                wrongname_lbl.ForeColor = System.Drawing.Color.Red;
                wrongname_lbl.Text = "Wrong course name";
            }
        }

        private void ManagerDeleteCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
