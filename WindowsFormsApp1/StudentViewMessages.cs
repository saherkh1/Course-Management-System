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
    public partial class StudentViewMessages : Form
    {
        public StudentViewMessages()
        {
            InitializeComponent();
            messageLBL.Text = "";
            fromLBL.Text = "";
            toLBL.Text = "";
            int messageCount = MessagesCounter(getData("user.txt")[0]);
            allMessage = new string[messageCount];
            Messagesfrom(getData("user.txt")[0]);
            showData(allMessage);
        }
        string[] allMessage;
       

      
        private string[] getMessage(string to, string from)
        {
            StreamReader sr = new StreamReader("messages.txt");
            string[] Message = new string[3];
            string line = sr.ReadLine();
            bool massageStart = false;
            while (line != null)
            {
                string[] details = line.Split(' ');
                if (details[0] == "EOMessage")
                    massageStart = false;
                else if (massageStart)
                {
                    messageLBL.Text += "\r\n";
                    messageLBL.Text += line;
                }
                else if (details[0] == to && details[1] == from)
                {
                    messageLBL.Text = "";
                    massageStart = true;
                    toLBL.Text = details[0];
                    fromLBL.Text = details[1];
                    for (int zb = 2; zb < details.Length; zb++)
                        messageLBL.Text += details[zb] + ' ';
                }

                line = sr.ReadLine();



            }
            sr.Close();
            return Message;
        }
        private int MessagesCounter(string id)
        {
            StreamReader sr = new StreamReader("messages.txt");
            string line = sr.ReadLine();
            int count = 0;
            while (line != null)
            {
                string[] details = line.Split(' ');
                if (id == details[0])
                    count++;

                line = sr.ReadLine();

            }
            sr.Close();
            return count;

        }
        private int Messagesfrom(string id)
        {
            StreamReader sr = new StreamReader("messages.txt");
            string line = sr.ReadLine();



            int count = 0;
            while (line != null)
            {
                string[] details = line.Split(' ');
                if (id == details[0])
                {
                    allMessage[count] = details[1];
                    count++;
                }
                line = sr.ReadLine();

            }
            sr.Close();
            return count;

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
        private void showData(string[] userDetails)
        {

            DataTable dt = new DataTable();
            InitializeGridView(dt);//does as the name say
            foreach (string c in userDetails)
                dt.Rows.Add(c);

            //close the file
            dataGridMessage.DataSource = dt;

        }
        private void InitializeGridView(DataTable dt)
        {
            string[] columnnames = { "message from" };
            foreach (string c in columnnames)
                dt.Columns.Add(c);
        }
        private void Messages_Click(object sender, EventArgs e)
        {


        }

      

        private void Back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            studentMain f8 = new studentMain();
            f8.Show();

        }

        private void dataGridMessage_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            getMessage(getData("user.txt")[0], dataGridMessage.CurrentRow.Cells[0].Value.ToString());

        }
    }
}
