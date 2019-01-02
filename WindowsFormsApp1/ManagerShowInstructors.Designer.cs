namespace WindowsFormsApp1
{
    partial class ManagerShowInstructors
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
            this.ShowInstructor_grd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ShowInstructor_grd)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(679, 1);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(118, 46);
            this.back_btn.TabIndex = 0;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // ShowInstructor_grd
            // 
            this.ShowInstructor_grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowInstructor_grd.Location = new System.Drawing.Point(12, 82);
            this.ShowInstructor_grd.Name = "ShowInstructor_grd";
            this.ShowInstructor_grd.RowTemplate.Height = 24;
            this.ShowInstructor_grd.Size = new System.Drawing.Size(776, 221);
            this.ShowInstructor_grd.TabIndex = 1;
            // 
            // ManagerShowInstructors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowInstructor_grd);
            this.Controls.Add(this.back_btn);
            this.Name = "ManagerShowInstructors";
            this.Text = "ManagerShowInstructors";
            ((System.ComponentModel.ISupportInitialize)(this.ShowInstructor_grd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView ShowInstructor_grd;
    }
}