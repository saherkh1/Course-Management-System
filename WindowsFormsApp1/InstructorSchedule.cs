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
    public partial class InstructorSchedule : Form
    {
        public InstructorSchedule()
        {
            InitializeComponent();
            showtable();
        }
        private void writelbl(string[] cs_details)
        {
            switch (cs_details[6])
            {
                case "1":
                    switch (cs_details[7])
                    {
                        case "8":
                            lbl1.Visible = true;
                            lbl1.Text = cs_details[5];
                            break;

                        case "10":
                            lbl2.Visible = true;
                            lbl2.Text = cs_details[5];
                            break;

                        case "12":
                            lbl3.Visible = true;
                            lbl3.Text = cs_details[5];
                            break;

                        case "14":
                            lbl4.Visible = true;
                            lbl4.Text = cs_details[5];
                            break;

                    }
                    break;

                case "2":
                    switch (cs_details[7])
                    {
                        case "8":
                            lbl5.Visible = true;
                            lbl5.Text = cs_details[5];
                            break;

                        case "10":
                            lbl6.Visible = true;
                            lbl6.Text = cs_details[5];
                            break;

                        case "12":
                            lbl7.Visible = true;
                            lbl7.Text = cs_details[5];
                            break;

                        case "14":
                            lbl8.Visible = true;
                            lbl8.Text = cs_details[5];
                            break;

                    }
                    break;

                case "3":
                    switch (cs_details[7])
                    {
                        case "8":
                            lbl9.Visible = true;
                            lbl9.Text = cs_details[5];
                            break;

                        case "10":
                            lbl10.Visible = true;
                            lbl10.Text = cs_details[5];
                            break;

                        case "12":
                            lbl11.Visible = true;
                            lbl11.Text = cs_details[5];
                            break;

                        case "14":
                            lbl12.Visible = true;
                            lbl12.Text = cs_details[5];
                            break;

                    }
                    break;

                case "4":
                    switch (cs_details[7])
                    {
                        case "8":
                            lbl13.Visible = true;
                            lbl13.Text = cs_details[5];
                            break;

                        case "10":
                            lbl14.Visible = true;
                            lbl14.Text = cs_details[5];
                            break;

                        case "12":
                            lbl15.Visible = true;
                            lbl15.Text = cs_details[5];
                            break;

                        case "14":
                            lbl16.Visible = true;
                            lbl16.Text = cs_details[5];
                            break;

                    }
                    break;

                case "5":
                    switch (cs_details[7])
                    {
                        case "8":
                            lbl17.Visible = true;
                            lbl17.Text = cs_details[5];
                            break;

                        case "10":
                            lbl18.Visible = true;
                            lbl18.Text = cs_details[5];
                            break;

                        case "12":
                            lbl19.Visible = true;
                            lbl19.Text = cs_details[5];
                            break;

                        case "14":
                            lbl20.Visible = true;
                            lbl20.Text = cs_details[5];
                            break;

                    }

                    break;
            }

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorMain sm = new InstructorMain();
            sm.Show();
   
        }
        private void showtable()
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("user.txt");
            //Read the first line of text
            string line = sr.ReadLine();
            string[] details = line.Split(' ');


            string[] cs_details = line.Split();
            writelbl(cs_details);
            line = sr.ReadLine();
            sr.Close();

        }
    }
}
