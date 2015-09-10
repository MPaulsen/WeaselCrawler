namespace WeasylScraper
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
            this.wbMain = new System.Windows.Forms.WebBrowser();
            this.btnFollowers = new System.Windows.Forms.Button();
            this.btnFollowing = new System.Windows.Forms.Button();
            this.btnBuildMaster = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // wbMain
            // 
            this.wbMain.Location = new System.Drawing.Point(0, 0);
            this.wbMain.Margin = new System.Windows.Forms.Padding(8, 8, 8, 41);
            this.wbMain.MinimumSize = new System.Drawing.Size(15, 16);
            this.wbMain.Name = "wbMain";
            this.wbMain.Size = new System.Drawing.Size(795, 712);
            this.wbMain.TabIndex = 0;
            // 
            // btnFollowers
            // 
            this.btnFollowers.Location = new System.Drawing.Point(941, 11);
            this.btnFollowers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFollowers.Name = "btnFollowers";
            this.btnFollowers.Size = new System.Drawing.Size(56, 19);
            this.btnFollowers.TabIndex = 1;
            this.btnFollowers.Text = "Followers";
            this.btnFollowers.UseVisualStyleBackColor = true;
            this.btnFollowers.Click += new System.EventHandler(this.btnFollowers_Click);
            // 
            // btnFollowing
            // 
            this.btnFollowing.Location = new System.Drawing.Point(805, 11);
            this.btnFollowing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFollowing.Name = "btnFollowing";
            this.btnFollowing.Size = new System.Drawing.Size(56, 19);
            this.btnFollowing.TabIndex = 2;
            this.btnFollowing.Text = "Following";
            this.btnFollowing.UseVisualStyleBackColor = true;
            this.btnFollowing.Click += new System.EventHandler(this.btnFollowing_Click);
            // 
            // btnBuildMaster
            // 
            this.btnBuildMaster.Location = new System.Drawing.Point(865, 11);
            this.btnBuildMaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuildMaster.Name = "btnBuildMaster";
            this.btnBuildMaster.Size = new System.Drawing.Size(72, 48);
            this.btnBuildMaster.TabIndex = 3;
            this.btnBuildMaster.Text = "Build Master List";
            this.btnBuildMaster.UseVisualStyleBackColor = true;
            this.btnBuildMaster.Click += new System.EventHandler(this.btnBuildMaster_Click);
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(805, 64);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(192, 648);
            this.tbLog.TabIndex = 4;
            this.tbLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.btnBuildMaster);
            this.Controls.Add(this.btnFollowing);
            this.Controls.Add(this.btnFollowers);
            this.Controls.Add(this.wbMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbMain;
        private System.Windows.Forms.Button btnFollowers;
        private System.Windows.Forms.Button btnFollowing;
        private System.Windows.Forms.Button btnBuildMaster;
        private System.Windows.Forms.RichTextBox tbLog;
    }
}

