namespace WindowsFormsApp1
{
    partial class ManagerShowStudentsInCourse
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
            this.back_btn = new System.Windows.Forms.Button();
            this.showstudents_grd = new System.Windows.Forms.DataGridView();
            this.coursename_txtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.show_btn = new System.Windows.Forms.Button();
            this.erore_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showstudents_grd)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(681, 2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(116, 54);
            this.back_btn.TabIndex = 0;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // showstudents_grd
            // 
            this.showstudents_grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showstudents_grd.Location = new System.Drawing.Point(38, 62);
            this.showstudents_grd.Name = "showstudents_grd";
            this.showstudents_grd.RowTemplate.Height = 24;
            this.showstudents_grd.Size = new System.Drawing.Size(659, 183);
            this.showstudents_grd.TabIndex = 1;
            // 
            // coursename_txtb
            // 
            this.coursename_txtb.Location = new System.Drawing.Point(313, 307);
            this.coursename_txtb.Name = "coursename_txtb";
            this.coursename_txtb.Size = new System.Drawing.Size(126, 22);
            this.coursename_txtb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course Name :";
            // 
            // show_btn
            // 
            this.show_btn.Location = new System.Drawing.Point(324, 360);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(98, 30);
            this.show_btn.TabIndex = 4;
            this.show_btn.Text = "Show";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // erore_lbl
            // 
            this.erore_lbl.AutoSize = true;
            this.erore_lbl.Location = new System.Drawing.Point(295, 268);
            this.erore_lbl.Name = "erore_lbl";
            this.erore_lbl.Size = new System.Drawing.Size(46, 17);
            this.erore_lbl.TabIndex = 5;
            this.erore_lbl.Text = "label2";
            // 
            // ManagerShowStudentsInCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.erore_lbl);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coursename_txtb);
            this.Controls.Add(this.showstudents_grd);
            this.Controls.Add(this.back_btn);
            this.Name = "ManagerShowStudentsInCourse";
            this.Text = "ManagerShowStudentsInCourse";
            ((System.ComponentModel.ISupportInitialize)(this.showstudents_grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView showstudents_grd;
        private System.Windows.Forms.TextBox coursename_txtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.Label erore_lbl;
    }
}