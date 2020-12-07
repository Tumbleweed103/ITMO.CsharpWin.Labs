using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EditPerson
{
    public partial class ViewPersonForm : Form
    {
        public ViewPersonForm()
        {
            InitializeComponent();
            personListView.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(personListView_RetrieveVirtualItem);
        }

        List<Person> people = new List<Person>();

        private void addButton_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            editPersonForm editForm = new editPersonForm(p);
            if (editForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            people.Add(p);
            personListView.VirtualListSize = people.Count();
            personListView.Invalidate();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (personListView.SelectedIndices.Count == 0)
            {
                return;
            }

            Person p = people[personListView.SelectedIndices[0]];
            editPersonForm editForm = new editPersonForm(p);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                personListView.Invalidate();
            }
        }

        private void personListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < people.Count())
            {
                e.Item = new ListViewItem(people[e.ItemIndex].FirstName);
                e.Item.SubItems.Add(people[e.ItemIndex].LastName);
                e.Item.SubItems.Add(people[e.ItemIndex].Age.ToString());
            }
        }

        private void viewPersonButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Person person in people)
            {
                sb.Append("Сотрудник: \n" + person.ToString());
                personTextBox.Text = sb.ToString();
            }
        }
    }
}
