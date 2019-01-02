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
    public partial class InstructorShowStudenstInCourse : Form
    {
        public InstructorShowStudenstInCourse()
        {
            InitializeComponent();
            showData(getData("user.txt"));
        }

        private void showData(string[] userDetails)
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("coursestudent.txt");
            //Read the first line of text
            string line = sr.ReadLine();
            //DataGridView dt = new DataGridView();
            DataTable dt = new DataTable();
            InitializeGridView(dt);//does as the name say
            //Continue to read until you reach end of file
            while (line != null)
            {
                string[] coursestudentDetails = line.Split(' ');
               
                if (userDetails[4] == coursestudentDetails[1])
                {

                    dt.Rows.Add(getData("student.txt", coursestudentDetails[0]));

                }
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            studentincourse_dgv.DataSource = dt;

        }
        private string[] removePass(string[] line)
        {
            string[] newline = {line[0] , line[2] , line[3] , line[4] , line[5]};
            return newline;
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
                        return removePass(details);
                    }
                line = sr.ReadLine();
            }
            sr.Close();
            if (key == null)
                return removePass(details);

            return null;
        }
        private void InitializeGridView(DataTable dt)
        {
            string[] columnnames = { "Student ID","Student First Name", "Student Last Name", "Phone Number","Department" };
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
            InstructorMain sm = new InstructorMain();
            sm.Show();
        }
    }
}
