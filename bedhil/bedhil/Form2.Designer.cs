namespace bedhil
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tBAppCommand = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbWorkDir = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbApplicationName = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tBAppCommand);
            this.groupBox3.Location = new System.Drawing.Point(6, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 104);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Application Command";
            // 
            // tBAppCommand
            // 
            this.tBAppCommand.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tBAppCommand.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tBAppCommand.Location = new System.Drawing.Point(6, 21);
            this.tBAppCommand.Multiline = true;
            this.tBAppCommand.Name = "tBAppCommand";
            this.tBAppCommand.Size = new System.Drawing.Size(413, 77);
            this.tBAppCommand.TabIndex = 0;
            this.tBAppCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBAppCommand_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbWorkDir);
            this.groupBox4.Location = new System.Drawing.Point(6, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(425, 55);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Application Directory";
            // 
            // tbWorkDir
            // 
            this.tbWorkDir.Location = new System.Drawing.Point(6, 21);
            this.tbWorkDir.Name = "tbWorkDir";
            this.tbWorkDir.Size = new System.Drawing.Size(413, 22);
            this.tbWorkDir.TabIndex = 0;
            this.tbWorkDir.Click += new System.EventHandler(this.tbWorkDir_Click);
            this.tbWorkDir.Enter += new System.EventHandler(this.tbWorkDir_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbApplicationName);
            this.groupBox2.Location = new System.Drawing.Point(6, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 55);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Name";
            // 
            // tbApplicationName
            // 
            this.tbApplicationName.Location = new System.Drawing.Point(6, 21);
            this.tbApplicationName.Name = "tbApplicationName";
            this.tbApplicationName.Size = new System.Drawing.Size(413, 22);
            this.tbApplicationName.TabIndex = 0;
            this.tbApplicationName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbApplicationName_KeyDown);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(12, 276);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(113, 46);
            this.buttonDone.TabIndex = 1;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(131, 276);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(113, 46);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Clear";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 327);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tBAppCommand;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbWorkDir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbApplicationName;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}