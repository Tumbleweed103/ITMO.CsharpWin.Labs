using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditPerson
{
    public partial class ViewPersonForm : Form
    {
        public ViewPersonForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            editPersonForm editForm = new editPersonForm();
            if (editForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            ListViewItem newItem = personListView.Items.Add(editForm.FirstName);
            newItem.SubItems.Add(editForm.LastName);
            newItem.SubItems.Add(editForm.Age.ToString());
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (personListView.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem item = personListView.SelectedItems[0];
            editPersonForm editForm = new editPersonForm();
            editForm.FirstName = item.Text;
            editForm.LastName = item.SubItems[1].Text;
            editForm.Age = Convert.ToInt32(item.SubItems[2].Text);

            if (editForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            item.Text = editForm.FirstName;
            item.SubItems[1].Text = editForm.LastName;
            item.SubItems[2].Text = editForm.Age.ToString();
        }
    }
}
