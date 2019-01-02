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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
            showtable();
        }
        private void showtable()
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("user.txt");
            //Read the first line of text
            string line = sr.ReadLine();
            string[] details = line.Split(' ');
            sr.Close();

            StreamReader srr = new StreamReader("coursestudent.txt");
            string linecs = srr.ReadLine();
            while (linecs != null)
            {


                string[] cs_details = linecs.Split();
                if (cs_details[0] == details[0])
                    writelbl(cs_details[2], cs_details[3], cs_details);

                linecs = srr.ReadLine();
            }
            srr.Close();
            
        }
        private void writelbl(string day,string month,string[] cs_details)
        {
            switch (cs_details[2])
            {
                case "1":
                    switch (cs_details[3])
                    {
                        case "8":
                            lbl1.Visible = true;
                            lbl1.Text = cs_details[1];
                            break;

                        case "10":
                            lbl2.Visible = true;
                            lbl2.Text = cs_details[1];
                            break;

                        case "12":
                            lbl3.Visible = true;
                            lbl3.Text = cs_details[1];
                            break;

                        case "14":
                            lbl4.Visible = true;
                            lbl4.Text = cs_details[1];
                            break;

                    }
                    break;

                case "2":
                    switch (cs_details[3])
                    {
                        case "8":
                            lbl5.Visible = true;
                            lbl5.Text = cs_details[1];
                            break;

                        case "10":
                            lbl6.Visible = true;
                            lbl6.Text = cs_details[1];
                            break;

                        case "12":
                            lbl7.Visible = true;
                            lbl7.Text = cs_details[1];
                            break;

                        case "14":
                            lbl8.Visible = true;
                            lbl8.Text = cs_details[1];
                            break;

                    }
                    break;

                case "3":
                    switch (cs_details[3])
                    {
                        case "8":
                            lbl9.Visible = true;
                            lbl9.Text = cs_details[1];
                            break;

                        case "10":
                            lbl10.Visible = true;
                            lbl10.Text = cs_details[1];
                            break;

                        case "12":
                            lbl11.Visible = true;
                            lbl11.Text = cs_details[1];
                            break;

                        case "14":
                            lbl12.Visible = true;
                            lbl12.Text = cs_details[1];
                            break;

                    }
                    break;

                case "4":
                    switch (cs_details[3])
                    {
                        case "8":
                            lbl13.Visible = true;
                            lbl13.Text = cs_details[1];
                            break;

                        case "10":
                            lbl14.Visible = true;
                            lbl14.Text = cs_details[1];
                            break;

                        case "12":
                            lbl15.Visible = true;
                            lbl15.Text = cs_details[1];
                            break;

                        case "14":
                            lbl16.Visible = true;
                            lbl16.Text = cs_details[1];
                            break;

                    }
                    break;

                case "5":
                    switch (cs_details[3])
                    {
                        case "8":
                            lbl17.Visible = true;
                            lbl17.Text = cs_details[1];
                            break;

                        case "10":
                            lbl18.Visible = true;
                            lbl18.Text = cs_details[1];
                            break;

                        case "12":
                            lbl19.Visible = true;
                            lbl19.Text = cs_details[1];
                            break;

                        case "14":
                            lbl20.Visible = true;
                            lbl20.Text = cs_details[1];
                            break;

                    }

                    break;
            }

        }
        

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void lbl7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            studentMain f3 = new studentMain();
            f3.Show();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {

        }
    }
}
