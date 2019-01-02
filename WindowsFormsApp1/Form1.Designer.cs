namespace WindowsFormsApp1
{
    partial class Form1
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
            this.uper_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxun = new System.Windows.Forms.TextBox();
            this.textBoxps = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ERE = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uper_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uper_panel
            // 
            this.uper_panel.BackColor = System.Drawing.Color.LightGreen;
            this.uper_panel.Controls.Add(this.label3);
            this.uper_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uper_panel.Location = new System.Drawing.Point(0, 0);
            this.uper_panel.Name = "uper_panel";
            this.uper_panel.Size = new System.Drawing.Size(748, 100);
            this.uper_panel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(502, 69);
            this.label3.TabIndex = 0;
            this.label3.Text = "The College of Engineers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "  ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // textBoxun
            // 
            this.textBoxun.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxun.ForeColor = System.Drawing.Color.Black;
            this.textBoxun.Location = new System.Drawing.Point(173, 67);
            this.textBoxun.Name = "textBoxun";
            this.textBoxun.Size = new System.Drawing.Size(100, 22);
            this.textBoxun.TabIndex = 0;
            this.textBoxun.TextChanged += new System.EventHandler(this.textBoxun_TextChanged);
            // 
            // textBoxps
            // 
            this.textBoxps.Location = new System.Drawing.Point(173, 100);
            this.textBoxps.Name = "textBoxps";
            this.textBoxps.Size = new System.Drawing.Size(100, 22);
            this.textBoxps.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ERE
            // 
            this.ERE.AutoSize = true;
            this.ERE.Location = new System.Drawing.Point(55, 83);
            this.ERE.Name = "ERE";
            this.ERE.Size = new System.Drawing.Size(0, 17);
            this.ERE.TabIndex = 7;
            this.ERE.UseMnemonic = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxun);
            this.groupBox1.Controls.Add(this.ERE);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxps);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(194, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "user details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(748, 549);
            this.Controls.Add(this.uper_panel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.uper_panel.ResumeLayout(false);
            this.uper_panel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel uper_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxun;
        private System.Windows.Forms.TextBox textBoxps;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ERE;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

