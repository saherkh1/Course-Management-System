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
    public partial class ManagerShowCoursesInDepartment : Form
    {
        public ManagerShowCoursesInDepartment()
        {
            InitializeComponent();
            showData(getData("user.txt"));
        }

        private void showData(string[] userDetails)
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("course.txt");
            //Read the first line of text
            string line = sr.ReadLine();
            //DataGridView dt = new DataGridView();
            DataTable dt = new DataTable();
            InitializeGridView(dt);//does as the name say
            //Continue to read until you reach end of file
            while (line != null)
            {
                string[] courseDetails = line.Split(' ');

                if (userDetails[5] == courseDetails[5])
                {

                    dt.Rows.Add(getData("course.txt", courseDetails[0]));

                }
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            Courses_grd.DataSource = dt;

        }
       
        private string[] getData(string path, string key = null)
        {
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            string[] details = line.Split(' ');
            while (line != null && key != null)
            {
                details = line.Split(' ');
                foreach (string c in details)
                    if (c == key)
                    {
                        sr.Close();
                        return details;

                    }
                line = sr.ReadLine();
            }
            sr.Close();
            if (key == null)
                return details;

            return null;
        }
        private void InitializeGridView(DataTable dt)
        {
            string[] columnnames = { "Course Name", "Points", "Instructor First Name", "Day", "Hour", "Department" };
            foreach (string c in columnnames)
                dt.Columns.Add(c);
        }

        private bool doesntExist(string path, string key1, string key2)
        {
            StreamReader sr = new StreamReader(path);

            string line = sr.ReadLine();
            while (line != null)
            {
                string[] details = line.Split(' ');
                if (details[0] == key1 && details[1] == key2)
                {
                    sr.Close();
                    return false;
                }

                line = sr.ReadLine();

            }
            sr.Close();
            return true;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerMain f1 = new ManagerMain();
            f1.Show();
        }
    }
}
