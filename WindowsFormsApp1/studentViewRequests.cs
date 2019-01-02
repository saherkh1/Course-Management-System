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
    public partial class studentViewRequests : Form
    {
        public studentViewRequests()
        {
            InitializeComponent();
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
        int count = 0;
        string myId;
        string[] fromId;
        string[] request;
        string[] status;
        private void myRequestsCoutAndexport()
        {
            
            
            StreamReader sr = new StreamReader("requests.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] details = line.Split(' ');
                if (details[0] == myId)
                    count++;

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
                        request[i] += "\r\n "+details[c];
                }

                else if (details[0] == myId)
                {
                    fromId[i] = details[1];
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
            int selectedIndex = dataGridView.CurrentRow.Index;
            fromLBL.Text= fromId[selectedIndex];
            toLBL.Text = myId;
            requestLBL.Text =request[selectedIndex];
            statusLBL.Text =status[selectedIndex];
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentMain f8 = new studentMain();
            f8.Show();
        }
    }
}
