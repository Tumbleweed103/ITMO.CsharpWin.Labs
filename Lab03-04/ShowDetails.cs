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
    public partial class ShowDetails : Form
    {
        public ShowDetails()
        {
            InitializeComponent();
        }

        private void showUserInfoButton_Click(object sender, EventArgs e)
        {
            if (addDetailsControl.Username != "" && addDetailsControl.Password != "")
            {
                userInfoTextBox.Text = "Username: " + addDetailsControl.Username + "\nPassword: " + addDetailsControl.Password;
            }
            else
            {
                MessageBox.Show("Fill in the user details first.");
            }
        }
    }
}
