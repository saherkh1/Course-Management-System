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
    public partial class InstructorAddMarks : Form
    {
        public InstructorAddMarks()
        {
            InitializeComponent();
            showData(getData("user.txt"), "coursestudent.txt");
        }

        private bool exist=false;

        private void UpdateMarkBtn_Click(object sender, EventArgs e)
        {
            string line = nameTb.Text + ' ' + getData("user.txt")[5] + ' ' + markTb.Text;
            removeStudentFromCourse(nameTb.Text, getData("user.txt")[5]);
            if (!exist)
            {
                writeToFile("greads.txt", line);
                messagelbl.Text = "Gread updated";
            }
            showData(getData("user.txt"), "coursestudent.txt");

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
            private void button1_Click(object sender, EventArgs e)
        {
            



        }

        private void writeToFile(string path, string line)
        {
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(line);
            sw.Close();
        }
        private void  removeStudentFromCourse(string id,string courseName)
        {

            if (doesntExist("coursestudent.txt", id, courseName) == true)
            {
                messagelbl.ForeColor = System.Drawing.Color.Red;
                messagelbl.Text = "Wrong Student ID";
                exist = true;
            }
            else
            {
                string[] Lines = File.ReadAllLines("coursestudent.txt");
                //start wrighting from the start
                StreamWriter sw = new StreamWriter("coursestudent.txt");



                foreach (string part in Lines)
                {

                    string[] splitLine = part.Split(' ');
                    if (splitLine[0] == id && splitLine[1] == courseName)
                    {
                        //Skip the line
                        continue;
                    }
                    else
                    {
                        sw.WriteLine(part);
                    }
                }

                sw.Close();
            }


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
       
        private void showData(string[] instructorDetails, string path)
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(path);
            //Read the first line of text
            string line = sr.ReadLine();
            int linecount = 0;
            //DataGridView dt = new DataGridView();
            DataTable dt = new DataTable();
            InitializeGridView(dt);//does as the name say
            //Continue to read until you reach end of file
            while (line != null)
            {
                string[] courseDetails = line.Split(' ');
                if (instructorDetails[5] == courseDetails[1])
                {
                    linecount++;
                    dt.Rows.Add(courseDetails);

                }
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            dataGridViewMarks.DataSource = dt;

        }
        private void InitializeGridView(DataTable dt)
        {
            string[] columnnames = { "Student id", "course name", "Day", "Hours"};
            foreach (string c in columnnames)
                dt.Columns.Add(c);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorMain f8 = new InstructorMain();
            f8.Show();
        }
    }
}
