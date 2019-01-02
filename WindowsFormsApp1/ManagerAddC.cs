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
    public partial class ManagerAddC : Form
    {
        public ManagerAddC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void writeToManagerFile(string line)
        {
            StreamWriter sw = new StreamWriter("instructor.txt",true);
            sw.WriteLine(line);
            sw.Close();
        }

        private void writeToCourseFile(string line)
        {
            StreamWriter sw = new StreamWriter("course.txt", true);
            sw.WriteLine(line);
            sw.Close();
        }
        private bool ifID(string i)
        {
            StreamReader sr = new StreamReader("instructor.txt");

            string line = sr.ReadLine();
            string[] details = line.Split(' ');
            while (line != null)
            {
                if (i == details[0])
                {
                    sr.Close();
                    return false;
                }
                line = sr.ReadLine();
                if (line!=""  && line!=null)
                {
                    details = line.Split(' ');
                }
              
            }
            sr.Close();
            return true; 
        }
        private void addbut_Click(object sender, EventArgs e)
        {
            int flag = 1;
            string id = idbox.Text;
            if (id=="")
                flag = 0;
            string pass = passbox.Text;
            if (pass == "")
                flag = 0;
            string name = namebox.Text;
            if (name == "")
                flag = 0;
            string last = lastnbox.Text;
            if (last == "")
                flag = 0;
            string dep = depbox.Text;
            if (dep == "")
                flag = 0;
            string phn = txtphn.Text;
            if (phn == "")
                flag = 0;
            string cname = cnamebox.Text;
            if (cname == "")
                flag = 0;
            string day = daybox.Text;
            if (day == "")
                flag = 0;
            string time = timebox.Text;
            if (time == "")
                flag = 0;
            string points = points_txt.Text;
            if (points == "")
                flag = 0;


            char s = ' ';
            if (flag != 0 && ifID(id)==true)
            {
                string line = (id + s + pass + s + name + s + last + s + dep + s  + cname + s + day + s + time + s + phn);

                writeToManagerFile(line);
                line = (cname + s + points + s + name + s + day + s + time + s + dep); 
                writeToCourseFile(line);
                lblero.Text = "added ☺";
            }
            else
            {
                lblero.Text = "Error something went wrong 🍑";
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerMain f4 = new ManagerMain();
            f4.Show();
        }
    }
}
