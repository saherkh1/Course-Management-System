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
//update
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }
        //un=user name
        //ps=password
        //path=path of the desired file
        private bool FindUser(string un, string ps, string path)
        {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(path);
                //Read the first line of text
                string line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    string[] details = line.Split(' ');
                if (details[0] == un)
                    if (details[1] == ps)
                    {
                        creatdoc(line);
                        sr.Close();
                        return true;
                    }
                //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
            return false;
        }
        private void creatdoc(string line)
        {
            //Pass the filepath and filename to the StreamWriter Constructor
            StreamWriter sw = new StreamWriter("user.txt");

            //Write a line of text
            sw.WriteLine(line);

            //Close the file
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentMain st = new studentMain();
            InstructorMain ins = new InstructorMain();
            ManagerMain ma = new ManagerMain();
            string path;
            int flag = 0;
            string un = textBoxun.Text;
            string ps = textBoxps.Text;
            if (un != "" && ps != "")
            {
                path = "student.txt";
                if (FindUser(un, ps, path)) { st.Show(); flag = 1; this.Hide(); }
                path = "instructor.txt";
                if (FindUser(un, ps, path)) { ins.Show(); flag = 1; this.Hide(); }
                path = "manager.txt";
                if (FindUser(un, ps, path)) { ma.Show(); flag = 1; this.Hide(); }
                if (flag == 0)
                    ERE.Text = "Wrong password or ID";
            }
            else ERE.Text = "Fill in the password and ID";

        }

        private void textBoxun_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
    
}
