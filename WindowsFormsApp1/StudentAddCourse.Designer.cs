namespace WindowsFormsApp1
{
    partial class StudentAddCourse
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
            this.components = new System.ComponentModel.Container();
            this.welcomelbl = new System.Windows.Forms.Label();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.textBoxAddCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCourse = new System.Windows.Forms.Button();
            this.massagelbl = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.courses_studentsTableAdapter1 = new WindowsFormsApp1.collegeDataSetTableAdapters.courses_studentsTableAdapter();
            this.collegeDataSet = new WindowsFormsApp1.collegeDataSet();
            this.coursesTableAdapter = new WindowsFormsApp1.collegeDataSetTableAdapters.coursesTableAdapter();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomelbl
            // 
            this.welcomelbl.AutoSize = true;
            this.welcomelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelbl.Location = new System.Drawing.Point(12, 23);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(255, 25);
            this.welcomelbl.TabIndex = 0;
            this.welcomelbl.Text = "Here is a list of the courses: ";
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(17, 51);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowTemplate.Height = 24;
            this.dataGridViewCourses.Size = new System.Drawing.Size(785, 235);
            this.dataGridViewCourses.TabIndex = 2;
            this.dataGridViewCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourses_CellContentClick);
            // 
            // textBoxAddCourse
            // 
            this.textBoxAddCourse.Location = new System.Drawing.Point(479, 296);
            this.textBoxAddCourse.Name = "textBoxAddCourse";
            this.textBoxAddCourse.Size = new System.Drawing.Size(142, 22);
            this.textBoxAddCourse.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the name of the course you would like to add:";
            // 
            // AddCourse
            // 
            this.AddCourse.Location = new System.Drawing.Point(642, 296);
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Size = new System.Drawing.Size(100, 40);
            this.AddCourse.TabIndex = 5;
            this.AddCourse.Text = "Add course";
            this.AddCourse.UseVisualStyleBackColor = true;
            this.AddCourse.Click += new System.EventHandler(this.AddCourse_Click);
            // 
            // massagelbl
            // 
            this.massagelbl.AutoSize = true;
            this.massagelbl.Location = new System.Drawing.Point(476, 346);
            this.massagelbl.Name = "massagelbl";
            this.massagelbl.Size = new System.Drawing.Size(22, 17);
            this.massagelbl.TabIndex = 6;
            this.massagelbl.Text = "lbl";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(713, 1);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(89, 47);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // courses_studentsTableAdapter1
            // 
            this.courses_studentsTableAdapter1.ClearBeforeFill = true;
            // 
            // collegeDataSet
            // 
            this.collegeDataSet.DataSetName = "collegeDataSet";
            this.collegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this.collegeDataSet;
            // 
            // StudentAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.massagelbl);
            this.Controls.Add(this.AddCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddCourse);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.welcomelbl);
            this.Name = "StudentAddCourse";
            this.Text = "StudentAddCourse";
            this.Load += new System.EventHandler(this.StudentAddCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomelbl;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.TextBox textBoxAddCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCourse;
        private System.Windows.Forms.Label massagelbl;
        private System.Windows.Forms.Button BackBtn;
        private collegeDataSetTableAdapters.courses_studentsTableAdapter courses_studentsTableAdapter1;
        private collegeDataSet collegeDataSet;
        private collegeDataSetTableAdapters.coursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.BindingSource coursesBindingSource;
    }
}