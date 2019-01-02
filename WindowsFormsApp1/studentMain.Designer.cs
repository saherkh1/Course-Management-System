namespace WindowsFormsApp1
{
    partial class studentMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sst = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddCourse = new System.Windows.Forms.Button();
            this.RemoveCorse = new System.Windows.Forms.Button();
            this.ViewGreadsbtn = new System.Windows.Forms.Button();
            this.Exams = new System.Windows.Forms.Button();
            this.viewMessagesBTN = new System.Windows.Forms.Button();
            this.sendMessagesBTN = new System.Windows.Forms.Button();
            this.SendRequestBTN = new System.Windows.Forms.Button();
            this.viewRequestsBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sst
            // 
            this.sst.Location = new System.Drawing.Point(15, 100);
            this.sst.Name = "sst";
            this.sst.Size = new System.Drawing.Size(100, 48);
            this.sst.TabIndex = 0;
            this.sst.Text = "Schedule";
            this.sst.UseVisualStyleBackColor = true;
            this.sst.Click += new System.EventHandler(this.sst_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 52);
            this.button1.TabIndex = 51;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddCourse
            // 
            this.AddCourse.Location = new System.Drawing.Point(125, 100);
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Size = new System.Drawing.Size(100, 48);
            this.AddCourse.TabIndex = 53;
            this.AddCourse.Text = "Add Course";
            this.AddCourse.UseVisualStyleBackColor = true;
            this.AddCourse.Click += new System.EventHandler(this.AddCourse_Click);
            // 
            // RemoveCorse
            // 
            this.RemoveCorse.Location = new System.Drawing.Point(237, 100);
            this.RemoveCorse.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveCorse.Name = "RemoveCorse";
            this.RemoveCorse.Size = new System.Drawing.Size(100, 48);
            this.RemoveCorse.TabIndex = 54;
            this.RemoveCorse.Text = "Remove Course";
            this.RemoveCorse.UseVisualStyleBackColor = true;
            this.RemoveCorse.Click += new System.EventHandler(this.RemoveCorse_Click);
            // 
            // ViewGreadsbtn
            // 
            this.ViewGreadsbtn.Location = new System.Drawing.Point(354, 100);
            this.ViewGreadsbtn.Name = "ViewGreadsbtn";
            this.ViewGreadsbtn.Size = new System.Drawing.Size(100, 48);
            this.ViewGreadsbtn.TabIndex = 55;
            this.ViewGreadsbtn.Text = "ViewGread";
            this.ViewGreadsbtn.UseVisualStyleBackColor = true;
            this.ViewGreadsbtn.Click += new System.EventHandler(this.ViewGreadsbtn_Click);
            // 
            // Exams
            // 
            this.Exams.Location = new System.Drawing.Point(463, 100);
            this.Exams.Margin = new System.Windows.Forms.Padding(2);
            this.Exams.Name = "Exams";
            this.Exams.Size = new System.Drawing.Size(100, 48);
            this.Exams.TabIndex = 56;
            this.Exams.Text = "Exams";
            this.Exams.UseVisualStyleBackColor = true;
            this.Exams.Click += new System.EventHandler(this.Exams_Click);
            // 
            // viewMessagesBTN
            // 
            this.viewMessagesBTN.Location = new System.Drawing.Point(581, 100);
            this.viewMessagesBTN.Margin = new System.Windows.Forms.Padding(2);
            this.viewMessagesBTN.Name = "viewMessagesBTN";
            this.viewMessagesBTN.Size = new System.Drawing.Size(100, 48);
            this.viewMessagesBTN.TabIndex = 57;
            this.viewMessagesBTN.Text = "View Messages";
            this.viewMessagesBTN.UseVisualStyleBackColor = true;
            this.viewMessagesBTN.Click += new System.EventHandler(this.viewMessagesBTN_Click);
            // 
            // sendMessagesBTN
            // 
            this.sendMessagesBTN.Location = new System.Drawing.Point(389, 327);
            this.sendMessagesBTN.Name = "sendMessagesBTN";
            this.sendMessagesBTN.Size = new System.Drawing.Size(75, 23);
            this.sendMessagesBTN.TabIndex = 58;
            this.sendMessagesBTN.Text = "Send Messages";
            this.sendMessagesBTN.UseVisualStyleBackColor = true;
            this.sendMessagesBTN.Click += new System.EventHandler(this.sendMessagesBTN_Click);
            // 
            // SendRequestBTN
            // 
            this.SendRequestBTN.Location = new System.Drawing.Point(472, 255);
            this.SendRequestBTN.Name = "SendRequestBTN";
            this.SendRequestBTN.Size = new System.Drawing.Size(75, 52);
            this.SendRequestBTN.TabIndex = 59;
            this.SendRequestBTN.Text = "Send Request";
            this.SendRequestBTN.UseVisualStyleBackColor = true;
            this.SendRequestBTN.Click += new System.EventHandler(this.SendRequestBTN_Click);
            // 
            // viewRequestsBTN
            // 
            this.viewRequestsBTN.Location = new System.Drawing.Point(389, 180);
            this.viewRequestsBTN.Name = "viewRequestsBTN";
            this.viewRequestsBTN.Size = new System.Drawing.Size(96, 69);
            this.viewRequestsBTN.TabIndex = 60;
            this.viewRequestsBTN.Text = "View Requests Status";
            this.viewRequestsBTN.UseVisualStyleBackColor = true;
            this.viewRequestsBTN.Click += new System.EventHandler(this.viewRequestsBTN_Click);
            // 
            // studentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewRequestsBTN);
            this.Controls.Add(this.SendRequestBTN);
            this.Controls.Add(this.sendMessagesBTN);
            this.Controls.Add(this.viewMessagesBTN);
            this.Controls.Add(this.Exams);
            this.Controls.Add(this.ViewGreadsbtn);
            this.Controls.Add(this.RemoveCorse);
            this.Controls.Add(this.AddCourse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sst);
            this.Name = "studentMain";
            this.Text = "studentMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddCourse;
        private System.Windows.Forms.Button RemoveCorse;
        private System.Windows.Forms.Button ViewGreadsbtn;
        private System.Windows.Forms.Button Exams;
        private System.Windows.Forms.Button viewMessagesBTN;
        private System.Windows.Forms.Button sendMessagesBTN;
        private System.Windows.Forms.Button SendRequestBTN;
        private System.Windows.Forms.Button viewRequestsBTN;
    }
}