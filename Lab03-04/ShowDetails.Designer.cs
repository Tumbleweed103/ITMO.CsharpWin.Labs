
namespace Lab03_04
{
    partial class ShowDetails
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
            this.userInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.showInfoLabel = new System.Windows.Forms.Label();
            this.showUserInfoButton = new System.Windows.Forms.Button();
            this.addDetailsControl = new Lab03_04.addDetailsControl();
            this.SuspendLayout();
            // 
            // userInfoTextBox
            // 
            this.userInfoTextBox.Location = new System.Drawing.Point(12, 33);
            this.userInfoTextBox.Name = "userInfoTextBox";
            this.userInfoTextBox.Size = new System.Drawing.Size(197, 96);
            this.userInfoTextBox.TabIndex = 0;
            this.userInfoTextBox.Text = "";
            // 
            // showInfoLabel
            // 
            this.showInfoLabel.AutoSize = true;
            this.showInfoLabel.Location = new System.Drawing.Point(12, 9);
            this.showInfoLabel.Name = "showInfoLabel";
            this.showInfoLabel.Size = new System.Drawing.Size(69, 17);
            this.showInfoLabel.TabIndex = 3;
            this.showInfoLabel.Text = "User info:";
            // 
            // showUserInfoButton
            // 
            this.showUserInfoButton.Location = new System.Drawing.Point(74, 137);
            this.showUserInfoButton.Name = "showUserInfoButton";
            this.showUserInfoButton.Size = new System.Drawing.Size(75, 23);
            this.showUserInfoButton.TabIndex = 4;
            this.showUserInfoButton.Text = "Show";
            this.showUserInfoButton.UseVisualStyleBackColor = true;
            this.showUserInfoButton.Click += new System.EventHandler(this.showUserInfoButton_Click);
            // 
            // addDetailsControl
            // 
            this.addDetailsControl.Location = new System.Drawing.Point(235, 12);
            this.addDetailsControl.Name = "addDetailsControl";
            this.addDetailsControl.Size = new System.Drawing.Size(268, 166);
            this.addDetailsControl.TabIndex = 5;
            // 
            // ShowDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 176);
            this.Controls.Add(this.addDetailsControl);
            this.Controls.Add(this.showUserInfoButton);
            this.Controls.Add(this.showInfoLabel);
            this.Controls.Add(this.userInfoTextBox);
            this.Name = "ShowDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox userInfoTextBox;
        private System.Windows.Forms.Label showInfoLabel;
        private System.Windows.Forms.Button showUserInfoButton;
        private addDetailsControl addDetailsControl;
    }
}

