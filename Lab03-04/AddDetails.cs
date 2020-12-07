using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_04
{
    public partial class addDetailsControl : UserControl
    {
        public addDetailsControl()
        {
            InitializeComponent();
        }

        public string Username
        {
            get { return usernameTextBox.Text; }
        }

        public string Password
        {
            get { return passwordTextBox.Text; }
        }

        private void usernameTextBox_Validating(object sender, CancelEventArgs e)
        {
            infoLabel.Text = "";
            if (usernameTextBox.Text == "")
            {
                e.Cancel = false;
            }
            foreach (char c in usernameTextBox.Text)
            {
                if (!char.IsLetter(c))
                {
                    e.Cancel = true;
                    infoLabel.Text = "Username must not contain any numbers or special characters.";
                }
            }
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            infoLabel.Text = "";
            if (passwordTextBox.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                if (passwordTextBox.TextLength < 6)
                {
                    e.Cancel = true;
                    infoLabel.Text = "Password must be at least 6 characters long.";
                }
                else if (!passwordTextBox.Text.Any(char.IsDigit))
                {
                    e.Cancel = true;
                    infoLabel.Text = "Password must contain at least 1 number.";
                }
            }   
        }
    }
}
