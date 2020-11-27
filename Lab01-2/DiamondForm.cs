﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Lab01_2
{
    public partial class DiamondForm : Form
    {
        public DiamondForm()
        {
            InitializeComponent();
        }

        private void DiamondForm_Load(object sender, EventArgs e)
        {
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddPolygon(new Point[]
            { 
              new Point(this.Width / 2, 0),
              new Point(this.Width, this.Height / 2),
              new Point(this.Width / 2, this.Height),
              new Point(0, this.Height / 2)
            });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
