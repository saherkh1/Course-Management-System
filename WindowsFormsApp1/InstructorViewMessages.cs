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
    public partial class InstructorViewMessages : Form
    {
        public InstructorViewMessages()
        {
            InitializeComponent();
            myId = getData("user.txt")[0];
            myMessagesCoutAndExport();
            showMessagesDGV();
            fromLBL.Text = "";
            toLBL.Text = "";
            messageLBL.Text = "";
        }
        private void showMessagesDGV()
        {
            DataTable dt = new DataTable();
            string[] columnnames = { "Message From" };
            foreach (string c in columnnames)
                dt.Columns.Add(c);
            foreach (string c in fromId)
                dt.Rows.Add(c);
            dataGridView.DataSource = dt;
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
        string[] messageTxt;
        
        private void myMessagesCoutAndExport()
        {


            StreamReader sr = new StreamReader("messages.txt");
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
            messageTxt = new string[count];
           
            sr.Close();
            sr = new StreamReader("messages.txt");
            line = sr.ReadLine();
            int i = 0;
            while (line != null && count != 0)
            {
                string[] details = line.Split(' ');
                if (details[0] == "EOMessage")//"EOMessage"
                {
                    if (flag) i++;
                    flag = false;
                    
                }

                else if (flag)
                {
                    for (int c = 0; c < details.Length; c++)
                        messageTxt[i] += "\r\n" + details[c];
                }

                else if (details[0] == myId)
                {
                    fromId[i] = details[1];
                    for (int c = 2; c < details.Length; c++)
                    {
                        messageTxt[i] += "\r\n" + details[c];
                    }
                    flag = true;
                }

                line = sr.ReadLine();
            }
            sr.Close();

        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedIndex = dataGridView.CurrentRow.Index;
            fromLBL.Text = fromId[selectedIndex];
            toLBL.Text = myId;
            messageLBL.Text = messageTxt[selectedIndex];
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorMain f4 = new InstructorMain();
            f4.Show();
        }
    }
}
