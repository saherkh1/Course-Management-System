using System;
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
    public partial class studentMain : Form
    {
        public studentMain()
        {
            InitializeComponent();
        }

        private void sst_Click(object sender, EventArgs e)
        {
            Schedule sc = new Schedule();
            sc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAddCourse f5 = new StudentAddCourse();
            f5.Show();
            
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAddCourse f6 = new StudentAddCourse();
            f6.Show();
        }

        private void RemoveCorse_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentRemoveCourse f7 = new StudentRemoveCourse();
            f7.Show();
        }

        private void ViewGreadsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentViewGreads f8 = new StudentViewGreads();
            f8.Show();
        }

        private void Exams_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentShowExams f = new StudentShowExams();
            f.Show();

        }

        private void viewMessagesBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentViewMessages f = new StudentViewMessages();
            f.Show();
        }

        private void sendMessagesBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentSendMessages f = new StudentSendMessages();
            f.Show();
        }

        private void SendRequestBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentSendRequests f = new StudentSendRequests();
            f.Show();
        }

        private void viewRequestsBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentViewRequests f = new studentViewRequests();
            f.Show();
        }
    }
}
