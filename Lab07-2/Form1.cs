using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07_2
{
    public partial class Form1 : Form
    {
        private delegate void TimeConsumingMethodDelegate(int seconds);
        public delegate void SetProgressDelegate(int val);
        bool Cancel;

        public Form1()
        {
            InitializeComponent();
        }

        private void timeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать цифры");
            }
        }

        private void TimeConsumingMethod(int seconds)
        {
            for (int j = 1; j <= seconds; j++)
            {
                SetProgress((int)(j * 100) / seconds);
                System.Threading.Thread.Sleep(1000);
                if (Cancel)
                {
                    break;
                }
            }
            if (Cancel)
            {
                MessageBox.Show("Cancelled!");
                Cancel = false;
            }
            else
            {
                MessageBox.Show("Complete!");
            }
        }

        public void SetProgress(int val)
        {
            if (progressBar.InvokeRequired)
            {
                SetProgressDelegate progressDelegate = new SetProgressDelegate(SetProgress);
                this.Invoke(progressDelegate, new object[] { val });
            }
            else
            {
                progressBar.Value = val;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            TimeConsumingMethodDelegate timeConsumingDelegate = new TimeConsumingMethodDelegate(TimeConsumingMethod);
            timeConsumingDelegate.BeginInvoke(int.Parse(timeTextBox.Text), null, null);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Cancel = true;
        }
    }
}
