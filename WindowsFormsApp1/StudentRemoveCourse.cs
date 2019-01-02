using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentRemoveCourse : Form
    {
        public StudentRemoveCourse()
        {
            InitializeComponent();
            showData(getData("user.txt"), "coursestudent.txt");
        }
        private int deleteRow = -1;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool doesntExist(string path, string key1, string key2)
        {
            StreamReader sr = new StreamReader(path);

            string line = sr.ReadLine();
            while (line != null)
            {
                deleteRow += 1;
                string[] details = line.Split(' ');
                if (details[0] == key1 && details[1] == key2) {
                    sr.Close();
                    return false;
                }
                line = sr.ReadLine();

            }
            sr.Close();
            return true;
        }

        private void RemoveCourse_Click(object sender, EventArgs e)
        {
            StreamReader stc = new StreamReader("user.txt");
            string line = stc.ReadLine();
            string[] details = line.Split(' ');
            stc.Close();
            if (doesntExist("coursestudent.txt", details[0], textcourse.Text) == true)
            {
                label2.ForeColor = System.Drawing.Color.Red;
                label2.Text = "Course not found ";
            }
            else if (deleteRow != -1)
            {
                string[] Lines = File.ReadAllLines("coursestudent.txt");
                //start righting from the start
                StreamWriter sw = new StreamWriter("coursestudent.txt");



                foreach (string part in Lines)
                {

                    string[] splitLine = part.Split(' ');
                    if (splitLine[0] == details[0] && splitLine[1] == textcourse.Text)
                    {
                        //Skip the line
                        continue;
                    }
                    else
                    {
                        sw.WriteLine(part);
                    }
                }
                label2.ForeColor = System.Drawing.Color.Black;
                label2.Text = "Deleted";
                sw.Close();
            }
            
            

            showData(getData("user.txt"), "coursestudent.txt");

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentMain f8 = new studentMain();
            f8.Show();
        }

        private void StudentRemoveCourse_Load(object sender, EventArgs e)
        {

        }
        private void showData(string[] userDetails, string path)
        {
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            int linecount = 0;
            DataTable dt = new DataTable();
            InitializeGridView(dt);//does as the name say
            while (line != null)
            {
                string[] courseDetails = line.Split(' ');
                if (userDetails[0] == courseDetails[0])
                {
                    linecount++;
                    dt.Rows.Add(courseDetails);

                }
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            courses_dgv.DataSource = dt;

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
                        break;
                line = sr.ReadLine();
            }
            sr.Close();
            return details;
        }
        private void InitializeGridView(DataTable dt)
        {
            string[] columnnames = { "Student ID","Course name", "Day", "Hours"};
            foreach (string c in columnnames)
                dt.Columns.Add(c);
        }
    }
}
