using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonF2_Click(object sender, EventArgs e)
        {
            string s = textBoxF21.Text + " " + textBoxF22.Text + " " + textBoxF23.Text;
            Form1 form1 = this.Owner as Form1;
            if (form1 != null)
            {
                form1.SolData = s;
            }
            this.Close();
        }
    }
}
