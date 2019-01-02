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
    public partial class StudentViewGreads : Form
    {
        public StudentViewGreads()
        {
            InitializeComponent();
            if (doesntExist("greads.txt", getData("user.txt")[0]))
                messagelbl.Text="no grades for you";
            else showData(getData("user.txt"), "greads.txt");
        }
        private void InitializeGridView(DataTable dt)
        {
            string[] columnnames = { "student name", "course name", "mark "};
            foreach (string c in columnnames)
                dt.Columns.Add(c);
        }
        private bool doesntExist(string path, string key1)
        {
            StreamReader sr = new StreamReader(path);

            string line = sr.ReadLine();
            while (line != null)
            {
                string[] details = line.Split(' ');
                if (details[0] == key1 )
                    return false;
                line = sr.ReadLine();

            }
            sr.Close();
            return true;
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
        //data in tha tabel will be exported from path
        private void showData(string[] userDetails, string path)
        {
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            DataTable dt = new DataTable();
            InitializeGridView(dt);

            while (line != null)
            {
                string[] courseDetails = line.Split(' ');
                if (userDetails[0] == courseDetails[0])
                    dt.Rows.Add(courseDetails);
                line = sr.ReadLine();
            }

            sr.Close();
            dataGridViewCourses.DataSource = dt;

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentMain f8 = new studentMain();
            f8.Show();
        }
    }

}
