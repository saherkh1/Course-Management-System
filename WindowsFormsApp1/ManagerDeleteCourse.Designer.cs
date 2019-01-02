namespace WindowsFormsApp1
{
    partial class ManagerDeleteCourse
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
            this.coursename_txt = new System.Windows.Forms.TextBox();
            this.coursename_lbl = new System.Windows.Forms.Label();
            this.Deletecourse_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.wrongname_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // coursename_txt
            // 
            this.coursename_txt.Location = new System.Drawing.Point(236, 146);
            this.coursename_txt.Name = "coursename_txt";
            this.coursename_txt.Size = new System.Drawing.Size(152, 22);
            this.coursename_txt.TabIndex = 0;
            // 
            // coursename_lbl
            // 
            this.coursename_lbl.AutoSize = true;
            this.coursename_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursename_lbl.Location = new System.Drawing.Point(65, 146);
            this.coursename_lbl.Name = "coursename_lbl";
            this.coursename_lbl.Size = new System.Drawing.Size(122, 20);
            this.coursename_lbl.TabIndex = 1;
            this.coursename_lbl.Text = "Course Name :";
            // 
            // Deletecourse_btn
            // 
            this.Deletecourse_btn.Location = new System.Drawing.Point(256, 215);
            this.Deletecourse_btn.Name = "Deletecourse_btn";
            this.Deletecourse_btn.Size = new System.Drawing.Size(96, 44);
            this.Deletecourse_btn.TabIndex = 2;
            this.Deletecourse_btn.Text = "Delete";
            this.Deletecourse_btn.UseVisualStyleBackColor = true;
            this.Deletecourse_btn.Click += new System.EventHandler(this.Deletecourse_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(667, 1);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(133, 54);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // wrongname_lbl
            // 
            this.wrongname_lbl.AutoSize = true;
            this.wrongname_lbl.ForeColor = System.Drawing.Color.Black;
            this.wrongname_lbl.Location = new System.Drawing.Point(243, 185);
            this.wrongname_lbl.Name = "wrongname_lbl";
            this.wrongname_lbl.Size = new System.Drawing.Size(0, 17);
            this.wrongname_lbl.TabIndex = 4;
            // 
            // ManagerDeleteCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wrongname_lbl);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.Deletecourse_btn);
            this.Controls.Add(this.coursename_lbl);
            this.Controls.Add(this.coursename_txt);
            this.Name = "ManagerDeleteCourse";
            this.Text = "ManagerDeleteCourse";
            this.Load += new System.EventHandler(this.ManagerDeleteCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox coursename_txt;
        private System.Windows.Forms.Label coursename_lbl;
        private System.Windows.Forms.Button Deletecourse_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label wrongname_lbl;
    }
}