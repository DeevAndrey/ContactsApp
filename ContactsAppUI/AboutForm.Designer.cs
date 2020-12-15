
namespace ContactsAppUI
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.EmailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ContactsAppLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AuthorAboutLabel = new System.Windows.Forms.Label();
            this.EmailAboutLabel = new System.Windows.Forms.Label();
            this.GithubLabel = new System.Windows.Forms.Label();
            this.AuthorAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmailLinkLabel
            // 
            resources.ApplyResources(this.EmailLinkLabel, "EmailLinkLabel");
            this.EmailLinkLabel.Name = "EmailLinkLabel";
            this.EmailLinkLabel.TabStop = true;
            // 
            // GitHubLinkLabel
            // 
            resources.ApplyResources(this.GitHubLinkLabel, "GitHubLinkLabel");
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.TabStop = true;
            this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
            // 
            // ContactsAppLabel
            // 
            resources.ApplyResources(this.ContactsAppLabel, "ContactsAppLabel");
            this.ContactsAppLabel.Name = "ContactsAppLabel";
            // 
            // VersionLabel
            // 
            resources.ApplyResources(this.VersionLabel, "VersionLabel");
            this.VersionLabel.Name = "VersionLabel";
            // 
            // AuthorAboutLabel
            // 
            resources.ApplyResources(this.AuthorAboutLabel, "AuthorAboutLabel");
            this.AuthorAboutLabel.Name = "AuthorAboutLabel";
            // 
            // EmailAboutLabel
            // 
            resources.ApplyResources(this.EmailAboutLabel, "EmailAboutLabel");
            this.EmailAboutLabel.Name = "EmailAboutLabel";
            // 
            // GithubLabel
            // 
            resources.ApplyResources(this.GithubLabel, "GithubLabel");
            this.GithubLabel.Name = "GithubLabel";
            // 
            // AuthorAbout
            // 
            resources.ApplyResources(this.AuthorAbout, "AuthorAbout");
            this.AuthorAbout.Name = "AuthorAbout";
            // 
            // AboutForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AuthorAbout);
            this.Controls.Add(this.GithubLabel);
            this.Controls.Add(this.EmailAboutLabel);
            this.Controls.Add(this.AuthorAboutLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ContactsAppLabel);
            this.Controls.Add(this.GitHubLinkLabel);
            this.Controls.Add(this.EmailLinkLabel);
            this.Name = "AboutForm";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel EmailLinkLabel;
        private System.Windows.Forms.LinkLabel GitHubLinkLabel;
        private System.Windows.Forms.Label ContactsAppLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AuthorAboutLabel;
        private System.Windows.Forms.Label EmailAboutLabel;
        private System.Windows.Forms.Label GithubLabel;
        private System.Windows.Forms.Label AuthorAbout;
    }
}