using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAnim
{
    public partial class WinAnim : Form
    {
        public WinAnim()
        {
            InitializeComponent();
        }

        private void btnAW_BLEND_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 1000,
            WinAPIClass.AnimateWindowFlags.AW_ACTIVATE |
            WinAPIClass.AnimateWindowFlags.AW_BLEND);
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCNTR_AW_SLIDE.Invalidate();
        }

        private void btnHOR_AW_SLIDE_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 1000,
            WinAPIClass.AnimateWindowFlags.AW_HOR_POSITIVE |
            WinAPIClass.AnimateWindowFlags.AW_SLIDE);
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCNTR_AW_SLIDE.Invalidate();
        }

        private void btnCNTR_AW_SLIDE_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 1000,
            WinAPIClass.AnimateWindowFlags.AW_CENTER |
            WinAPIClass.AnimateWindowFlags.AW_SLIDE);
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCNTR_AW_SLIDE.Invalidate();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
