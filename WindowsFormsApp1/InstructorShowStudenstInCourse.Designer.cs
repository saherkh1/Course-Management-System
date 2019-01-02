namespace WindowsFormsApp1
{
    partial class InstructorShowStudenstInCourse
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
            this.studentincourse_dgv = new System.Windows.Forms.DataGridView();
            this.back_btn = new System.Windows.Forms.Button();
            this.uper_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentincourse_dgv)).BeginInit();
            this.uper_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentincourse_dgv
            // 
            this.studentincourse_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentincourse_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentincourse_dgv.Location = new System.Drawing.Point(29, 132);
            this.studentincourse_dgv.Name = "studentincourse_dgv";
            this.studentincourse_dgv.RowTemplate.Height = 24;
            this.studentincourse_dgv.Size = new System.Drawing.Size(729, 274);
            this.studentincourse_dgv.TabIndex = 0;
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(675, 2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(121, 46);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // uper_panel
            // 
            this.uper_panel.BackColor = System.Drawing.Color.LightGreen;
            this.uper_panel.Controls.Add(this.label3);
            this.uper_panel.Controls.Add(this.back_btn);
            this.uper_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uper_panel.Location = new System.Drawing.Point(0, 0);
            this.uper_panel.Name = "uper_panel";
            this.uper_panel.Size = new System.Drawing.Size(799, 100);
            this.uper_panel.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 58);
            this.label3.TabIndex = 10;
            this.label3.Text = "Students In My Course";
            // 
            // InstructorShowStudenstInCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 549);
            this.Controls.Add(this.uper_panel);
            this.Controls.Add(this.studentincourse_dgv);
            this.Name = "InstructorShowStudenstInCourse";
            this.Text = "InstructorShowStudentInCourse";
            ((System.ComponentModel.ISupportInitialize)(this.studentincourse_dgv)).EndInit();
            this.uper_panel.ResumeLayout(false);
            this.uper_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentincourse_dgv;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Panel uper_panel;
        private System.Windows.Forms.Label label3;
    }
}