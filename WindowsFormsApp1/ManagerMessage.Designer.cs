namespace WindowsFormsApp1
{
    partial class ManagerMessage
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
            this.Back = new System.Windows.Forms.Button();
            this.collegeDataSet = new WindowsFormsApp1.collegeDataSet();
            this.collegeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toLBL = new System.Windows.Forms.Label();
            this.fromLBL = new System.Windows.Forms.Label();
            this.messageLBL = new System.Windows.Forms.Label();
            this.dataGridMessage = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(651, -1);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(77, 39);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // collegeDataSet
            // 
            this.collegeDataSet.DataSetName = "collegeDataSet";
            this.collegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collegeDataSetBindingSource
            // 
            this.collegeDataSetBindingSource.DataSource = this.collegeDataSet;
            this.collegeDataSetBindingSource.Position = 0;
            // 
            // toLBL
            // 
            this.toLBL.AutoSize = true;
            this.toLBL.Location = new System.Drawing.Point(426, 48);
            this.toLBL.Name = "toLBL";
            this.toLBL.Size = new System.Drawing.Size(46, 17);
            this.toLBL.TabIndex = 2;
            this.toLBL.Text = "label1";
            // 
            // fromLBL
            // 
            this.fromLBL.AutoSize = true;
            this.fromLBL.Location = new System.Drawing.Point(426, 78);
            this.fromLBL.Name = "fromLBL";
            this.fromLBL.Size = new System.Drawing.Size(46, 17);
            this.fromLBL.TabIndex = 3;
            this.fromLBL.Text = "label2";
            // 
            // messageLBL
            // 
            this.messageLBL.AutoSize = true;
            this.messageLBL.Location = new System.Drawing.Point(426, 108);
            this.messageLBL.Name = "messageLBL";
            this.messageLBL.Size = new System.Drawing.Size(46, 17);
            this.messageLBL.TabIndex = 4;
            this.messageLBL.Text = "label3";
            // 
            // dataGridMessage
            // 
            this.dataGridMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridMessage.Location = new System.Drawing.Point(0, 0);
            this.dataGridMessage.Name = "dataGridMessage";
            this.dataGridMessage.RowTemplate.Height = 24;
            this.dataGridMessage.Size = new System.Drawing.Size(260, 387);
            this.dataGridMessage.TabIndex = 5;
            this.dataGridMessage.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridMessage_RowHeaderMouseClick);
            // 
            // ManagerMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 387);
            this.Controls.Add(this.dataGridMessage);
            this.Controls.Add(this.messageLBL);
            this.Controls.Add(this.fromLBL);
            this.Controls.Add(this.toLBL);
            this.Controls.Add(this.Back);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerMessage";
            this.Text = "ManagerMessage";
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.BindingSource collegeDataSetBindingSource;
        private collegeDataSet collegeDataSet;
        private System.Windows.Forms.Label toLBL;
        private System.Windows.Forms.Label fromLBL;
        private System.Windows.Forms.Label messageLBL;
        private System.Windows.Forms.DataGridView dataGridMessage;
    }
}