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
    public partial class ManagerMain : Form
    {
        public ManagerMain()
        {
            InitializeComponent();
            managername_lbl.Text = "Welcome" + " " + getData("user.txt");
        }

        private string getData(string path, string key = null)
        {
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            string[] details = line.Split(' ');
            while (line != null && key != null)
            {
                details = line.Split(' ');
                foreach (string c in details)
                    if (c == key)
                        break;
                line = sr.ReadLine();
            }
            sr.Close();
            return details[2] + " " + details[3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerAddC mac = new ManagerAddC();
            mac.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void deletec_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerDeleteCourse mdc = new ManagerDeleteCourse();
            mdc.Show();
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerSendMessage f9 = new ManagerSendMessage();
            f9.Show();
        }

        private void ManageeMessage_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerMessage f10 = new ManagerMessage();
            f10.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerAddCourseDate iam = new ManagerAddCourseDate();
            iam.Show();
        }

        private void AddDatebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerAddCourseDate iam = new ManagerAddCourseDate();
            iam.Show();
        }

        private void courseindeoartment_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerShowCoursesInDepartment iam = new ManagerShowCoursesInDepartment();
            iam.Show();
        }

        private void showinstructor_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerShowInstructors iam = new ManagerShowInstructors();
            iam.Show();
        }

        private void showsutdents_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerShowStudentsInCourse iam = new ManagerShowStudentsInCourse();
            iam.Show();
        }
    }
}
