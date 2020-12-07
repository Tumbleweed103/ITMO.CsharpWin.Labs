using System;
using System.Windows.Forms;

namespace EditPerson
{
    public partial class editPersonForm : Form
    {

        Person p;
        public editPersonForm(Person p)
        {
            InitializeComponent();
            this.p = p;
            this.FirstName = p.FirstName;
            this.LastName = p.LastName;
            this.Age = p.Age;
        }

        public string FirstName
        {
            get { return firstNameTextBox.Text; }
            set { firstNameTextBox.Text = value; }
        }

        public string LastName
        {
            get { return lastNameTextBox.Text; }
            set { lastNameTextBox.Text = value; }
        }

        public int Age
        {
            get { return (int)ageNumericUpDown.Value; }
            set { ageNumericUpDown.Value = value; }
        }

        private void saveEditButton_Click(object sender, EventArgs e)
        {
            p.FirstName = this.FirstName;
            p.LastName = this.LastName;
            p.Age = this.Age;
        }
    }
}
