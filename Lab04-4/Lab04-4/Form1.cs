﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string SolData
        {
            get { return textBoxF1.Text; }
            set { textBoxF1.Text = value; }
        }

        private void buttonF1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(this);
        }
    }
}
