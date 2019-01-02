namespace WindowsFormsApp1
{
    partial class StudentRemoveCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.textcourse = new System.Windows.Forms.TextBox();
            this.RemoveCourse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.courses_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.courses_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "name course:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textcourse
            // 
            this.textcourse.Location = new System.Drawing.Point(237, 192);
            this.textcourse.Margin = new System.Windows.Forms.Padding(2);
            this.textcourse.Multiline = true;
            this.textcourse.Name = "textcourse";
            this.textcourse.Size = new System.Drawing.Size(93, 35);
            this.textcourse.TabIndex = 2;
            // 
            // RemoveCourse
            // 
            this.RemoveCourse.Location = new System.Drawing.Point(249, 266);
            this.RemoveCourse.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveCourse.Name = "RemoveCourse";
            this.RemoveCourse.Size = new System.Drawing.Size(67, 26);
            this.RemoveCourse.TabIndex = 3;
            this.RemoveCourse.Text = "Remove";
            this.RemoveCourse.UseVisualStyleBackColor = true;
            this.RemoveCourse.Click += new System.EventHandler(this.RemoveCourse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(558, 0);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(89, 47);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // courses_dgv
            // 
            this.courses_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courses_dgv.Location = new System.Drawing.Point(1, 0);
            this.courses_dgv.Name = "courses_dgv";
            this.courses_dgv.RowTemplate.Height = 24;
            this.courses_dgv.Size = new System.Drawing.Size(552, 150);
            this.courses_dgv.TabIndex = 6;
            // 
            // StudentRemoveCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 370);
            this.Controls.Add(this.courses_dgv);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemoveCourse);
            this.Controls.Add(this.textcourse);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentRemoveCourse";
            this.Text = "RemoveCourseStudent";
            this.Load += new System.EventHandler(this.StudentRemoveCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courses_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textcourse;
        private System.Windows.Forms.Button RemoveCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView courses_dgv;
    }
}