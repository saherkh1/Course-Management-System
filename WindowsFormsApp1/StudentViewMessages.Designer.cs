namespace WindowsFormsApp1
{
    partial class StudentViewMessages
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
            this.dataGridMessage = new System.Windows.Forms.DataGridView();
            this.messageLBL = new System.Windows.Forms.Label();
            this.fromLBL = new System.Windows.Forms.Label();
            this.toLBL = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMessage
            // 
            this.dataGridMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMessage.Location = new System.Drawing.Point(5, 11);
            this.dataGridMessage.Name = "dataGridMessage";
            this.dataGridMessage.RowTemplate.Height = 24;
            this.dataGridMessage.Size = new System.Drawing.Size(283, 384);
            this.dataGridMessage.TabIndex = 10;
            this.dataGridMessage.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridMessage_RowHeaderMouseClick_1);
            // 
            // messageLBL
            // 
            this.messageLBL.AutoSize = true;
            this.messageLBL.Location = new System.Drawing.Point(429, 120);
            this.messageLBL.Name = "messageLBL";
            this.messageLBL.Size = new System.Drawing.Size(46, 17);
            this.messageLBL.TabIndex = 9;
            this.messageLBL.Text = "label3";
            // 
            // fromLBL
            // 
            this.fromLBL.AutoSize = true;
            this.fromLBL.Location = new System.Drawing.Point(429, 90);
            this.fromLBL.Name = "fromLBL";
            this.fromLBL.Size = new System.Drawing.Size(46, 17);
            this.fromLBL.TabIndex = 8;
            this.fromLBL.Text = "label2";
            // 
            // toLBL
            // 
            this.toLBL.AutoSize = true;
            this.toLBL.Location = new System.Drawing.Point(429, 60);
            this.toLBL.Name = "toLBL";
            this.toLBL.Size = new System.Drawing.Size(46, 17);
            this.toLBL.TabIndex = 7;
            this.toLBL.Text = "label1";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(722, -1);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(77, 39);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click_1);
            // 
            // StudentViewMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridMessage);
            this.Controls.Add(this.messageLBL);
            this.Controls.Add(this.fromLBL);
            this.Controls.Add(this.toLBL);
            this.Controls.Add(this.Back);
            this.Name = "StudentViewMessages";
            this.Text = "StudentViewMessages";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMessage;
        private System.Windows.Forms.Label messageLBL;
        private System.Windows.Forms.Label fromLBL;
        private System.Windows.Forms.Label toLBL;
        private System.Windows.Forms.Button Back;
    }
}