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
    public partial class InstructorAnswerRequests : Form
    {
        public InstructorAnswerRequests()
        {
            InitializeComponent();
            errorLBL.Text = "";
            fromLBL.Text = "";
            toLBL.Text = "";
            requestLBL.Text = "";
            statusLBL.Text = "";
            myId = getData("user.txt")[0];
            myRequestsCoutAndexport();
            showRequestsDGV();
        }
        private string[] getData(string path, string key = null)
        {
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            if (line == null)
                return null;
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
        private int count = 0;
        private int selectedIndex=-1;
        private string myId;
        private string[] fromId;
        private string[] request;
        private string[] status;
        ///////////////////////////////////////////////////////////////////////////////////////////
        //in instructor view requests search for details[0]==myid 
        ///////////////////////////////////////////////////////////////////////////////////////////

        private void myRequestsCoutAndexport()
        {
            StreamReader sr = new StreamReader("requests.txt");
            string line = sr.ReadLine();
            bool flagbinding = false;
            while (line != null)
            {
                string[] details = line.Split(' ');

                if (flagbinding )
                {
                    if (details[0] == "EOMessage")
                        if (details[1] != "binding")
                        {
                            flagbinding = false;
                            count--;
                        }
                }
                else if (details[1] == myId)
                {
                    count++;
                    flagbinding = true;
                }
                

                line = sr.ReadLine();
            }
            bool flag = false;
            fromId = new string[count];
            request = new string[count];
            status = new string[count];
            sr.Close();
            sr = new StreamReader("requests.txt");
            line = sr.ReadLine();
            int i = 0;
            while (line != null && count != 0)
            {
                string[] details = line.Split(' ');
                if (details[0] == "EOMessage")//"EOMessage"
                {
                    if (flag)
                    {
                        status[i] = details[1];
                        i++;
                    }
                    flag = false;
                }

                else if (flag)
                {
                    for (int c = 0; c < details.Length; c++)
                        request[i] += "\r\n " + details[c];
                }

                else if (details[1] == myId)
                {
                    fromId[i] = details[0];
                    for (int c = 2; c < details.Length; c++)
                        request[i] += "\r\n " + details[c];
                    flag = true;
                }

                line = sr.ReadLine();
            }
            sr.Close();

        }
        private void showRequestsDGV()
        {
            DataTable dt = new DataTable();
            string[] columnnames = { "Request from" };
            foreach (string c in columnnames)
                dt.Columns.Add(c);
            foreach (string c in fromId)
                dt.Rows.Add(c);
            dataGridView.DataSource = dt;
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             selectedIndex = dataGridView.CurrentRow.Index;
            if (count != 0)
            {
                fromLBL.Text = fromId[selectedIndex];
                toLBL.Text = myId;
                requestLBL.Text = request[selectedIndex];
                statusLBL.Text = status[selectedIndex];
            }
            else errorLBL.Text = "No Requests";
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorMain f8 = new InstructorMain();
            f8.Show();
        }
        private void ChangeStatusForRequest()
        {
            int messageIndex = 0;
            string[] Lines = File.ReadAllLines("request.txt");
            File.Delete("request.txt");// Deleting the file
            using (StreamWriter sw = File.AppendText("request.txt"))

                for (int i = 0; i < Lines.Length; i++)
                {
                    string[] splitedLine = Lines[i].Split();
                    if (splitedLine[1] == myId)
                    {

                        while (i < Lines.Length && splitedLine[0] != "EOMessage") i++;

                        if (splitedLine[0] == "EOMessage")
                            if (splitedLine[1] != status[messageIndex])
                            {
                                string newLine = splitedLine[0] + ' ' + status[messageIndex] ;
                                sw.WriteLine(newLine);
                                messageIndex++;
                            }
                            else
                            
                                sw.WriteLine(Lines[i]);
                            
                    }
                }

            errorLBL.ForeColor = System.Drawing.Color.Black;
            errorLBL.Text = "Coming soon!!";


        }

        private void approveBTN_Click(object sender, EventArgs e)
        {
            if (selectedIndex > -1)
            {
                status[selectedIndex] = "Approved";
                ChangeStatusForRequest();
            }

        }

        private void DenyBTN_Click(object sender, EventArgs e)
        {
            if (selectedIndex > -1)
            {
                status[selectedIndex] = "Denied";
                ChangeStatusForRequest();
            }
        }
    }
}
