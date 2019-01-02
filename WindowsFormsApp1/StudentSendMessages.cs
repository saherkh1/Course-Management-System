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
    public partial class StudentSendMessages : Form
    {
        public StudentSendMessages()
        {
            InitializeComponent();
            messageLBL.Text = "";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentMain f8 = new studentMain();
            f8.Show();
        }
        private bool FindUser(string un, string path)
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
                {
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
        private void sendBTN_Click(object sender, EventArgs e)
        {
            studentMain st = new studentMain();
            InstructorMain ins = new InstructorMain();
            ManagerMain ma = new ManagerMain();
            int flag = 0;
            string un = textBoxun.Text;
            if (un != "" )
            {
                if (FindUser(un, "student.txt")) {  flag = 1;  }
                else if (FindUser(un, "instructor.txt")) {  flag = 1;  }
                else if (FindUser(un, "manager.txt")) {  flag = 1;  }
                if (flag == 1)
                {
                    char s = ' ';

                    StreamReader mi = new StreamReader("user.txt");
                    string line = mi.ReadLine();
                    string[] details = line.Split(' ');
                    string idM = details[0];
                    mi.Close();

                    string message = un + s + idM + s + textBoxMessage.Text + "\r\nEOMessage";
                    StreamWriter mw = new StreamWriter("messages.txt", true);
                    mw.WriteLine(message);
                    mw.Close();
                    
                    messageLBL.Text = "Message sent";
                }
                else messageLBL.Text = "Wrong password or ID";
            }
            else messageLBL.Text = "Fill in the ID or message";
        }
    }
}
