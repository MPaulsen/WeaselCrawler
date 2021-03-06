﻿namespace WeasylScraper
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
            this.btnBuildMaster = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.RichTextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblFound = new System.Windows.Forms.Label();
            this.lblCrawled = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wbMain
            // 
            this.wbMain.Location = new System.Drawing.Point(0, 0);
            this.wbMain.Margin = new System.Windows.Forms.Padding(11, 10, 11, 50);
            this.wbMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMain.Name = "wbMain";
            this.wbMain.Size = new System.Drawing.Size(1060, 876);
            this.wbMain.TabIndex = 0;
            // 
            // btnFollowers
            // 
            this.btnFollowers.Location = new System.Drawing.Point(1255, 14);
            this.btnFollowers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFollowers.Name = "btnFollowers";
            this.btnFollowers.Size = new System.Drawing.Size(75, 23);
            this.btnFollowers.TabIndex = 1;
            this.btnFollowers.Text = "Followers";
            this.btnFollowers.UseVisualStyleBackColor = true;
            this.btnFollowers.Click += new System.EventHandler(this.btnFollowers_Click);
            // 
            // btnBuildMaster
            // 
            this.btnBuildMaster.Location = new System.Drawing.Point(1153, 14);
            this.btnBuildMaster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuildMaster.Name = "btnBuildMaster";
            this.btnBuildMaster.Size = new System.Drawing.Size(96, 59);
            this.btnBuildMaster.TabIndex = 3;
            this.btnBuildMaster.Text = "Build Master List";
            this.btnBuildMaster.UseVisualStyleBackColor = true;
            this.btnBuildMaster.Click += new System.EventHandler(this.btnBuildMaster_Click);
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(1073, 115);
            this.tbLog.Margin = new System.Windows.Forms.Padding(4);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(255, 761);
            this.tbLog.TabIndex = 4;
            this.tbLog.Text = "";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1073, 14);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.Location = new System.Drawing.Point(1074, 94);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(52, 17);
            this.lblFound.TabIndex = 6;
            this.lblFound.Text = "Found:";
            // 
            // lblCrawled
            // 
            this.lblCrawled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCrawled.AutoSize = true;
            this.lblCrawled.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCrawled.Location = new System.Drawing.Point(1212, 94);
            this.lblCrawled.Name = "lblCrawled";
            this.lblCrawled.Size = new System.Drawing.Size(62, 17);
            this.lblCrawled.TabIndex = 7;
            this.lblCrawled.Text = "Crawled:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.lblCrawled);
            this.Controls.Add(this.lblFound);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.btnBuildMaster);
            this.Controls.Add(this.btnFollowers);
            this.Controls.Add(this.wbMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbMain;
        private System.Windows.Forms.Button btnFollowers;
        private System.Windows.Forms.Button btnBuildMaster;
        private System.Windows.Forms.RichTextBox tbLog;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblFound;
        private System.Windows.Forms.Label lblCrawled;
    }
}

