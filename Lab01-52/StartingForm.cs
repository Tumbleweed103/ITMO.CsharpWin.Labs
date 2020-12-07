using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_2
{
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        private void diamondshapedFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiamondForm newForm = new DiamondForm();
            newForm.MdiParent = this;
            newForm.Show();
        }
    }
}
