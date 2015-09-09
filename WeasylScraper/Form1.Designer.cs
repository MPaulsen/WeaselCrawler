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
            this.SuspendLayout();
            // 
            // wbMain
            // 
            this.wbMain.Location = new System.Drawing.Point(0, 0);
            this.wbMain.Margin = new System.Windows.Forms.Padding(10, 10, 10, 50);
            this.wbMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMain.Name = "wbMain";
            this.wbMain.Size = new System.Drawing.Size(800, 600);
            this.wbMain.TabIndex = 0;
            // 
            // btnFollowers
            // 
            this.btnFollowers.Location = new System.Drawing.Point(837, 30);
            this.btnFollowers.Name = "btnFollowers";
            this.btnFollowers.Size = new System.Drawing.Size(75, 23);
            this.btnFollowers.TabIndex = 1;
            this.btnFollowers.Text = "Followers";
            this.btnFollowers.UseVisualStyleBackColor = true;
            this.btnFollowers.Click += new System.EventHandler(this.btnFollowers_Click);
            // 
            // btnFollowing
            // 
            this.btnFollowing.Location = new System.Drawing.Point(837, 94);
            this.btnFollowing.Name = "btnFollowing";
            this.btnFollowing.Size = new System.Drawing.Size(75, 23);
            this.btnFollowing.TabIndex = 2;
            this.btnFollowing.Text = "Following";
            this.btnFollowing.UseVisualStyleBackColor = true;
            this.btnFollowing.Click += new System.EventHandler(this.btnFollowing_Click);
            // 
            // btnBuildMaster
            // 
            this.btnBuildMaster.Location = new System.Drawing.Point(837, 146);
            this.btnBuildMaster.Name = "btnBuildMaster";
            this.btnBuildMaster.Size = new System.Drawing.Size(75, 59);
            this.btnBuildMaster.TabIndex = 3;
            this.btnBuildMaster.Text = "Build Master List";
            this.btnBuildMaster.UseVisualStyleBackColor = true;
            this.btnBuildMaster.Click += new System.EventHandler(this.btnBuildMaster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 645);
            this.Controls.Add(this.btnBuildMaster);
            this.Controls.Add(this.btnFollowing);
            this.Controls.Add(this.btnFollowers);
            this.Controls.Add(this.wbMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbMain;
        private System.Windows.Forms.Button btnFollowers;
        private System.Windows.Forms.Button btnFollowing;
        private System.Windows.Forms.Button btnBuildMaster;
    }
}

