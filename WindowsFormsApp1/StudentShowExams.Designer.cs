namespace WindowsFormsApp1
{
    partial class StudentShowExams
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
            this.Back = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.ShowExams = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ShowExams)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(681, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(121, 60);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(3, 66);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(105, 50);
            this.Show.TabIndex = 2;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // ShowExams
            // 
            this.ShowExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowExams.Location = new System.Drawing.Point(124, 66);
            this.ShowExams.Name = "ShowExams";
            this.ShowExams.RowTemplate.Height = 33;
            this.ShowExams.Size = new System.Drawing.Size(664, 336);
            this.ShowExams.TabIndex = 3;
            this.ShowExams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowExams_CellContentClick);
            // 
            // StudentShowExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowExams);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Back);
            this.Name = "StudentShowExams";
            this.Text = "StudentShowExams";
            ((System.ComponentModel.ISupportInitialize)(this.ShowExams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.DataGridView ShowExams;
    }
}