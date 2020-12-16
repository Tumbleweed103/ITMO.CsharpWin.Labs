using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task<string> Calc (int maxValue)
        {
            return await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(2000);
                string result = "";
                for (int trial = 2; trial <= maxValue; trial++)
                {
                    bool isPrime = true;
                    for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                    {
                        if (trial % divisor == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        result += " " + trial;
                    }
                }
                return result;
            });
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            string result;
            try
            {
                int maxValue = int.Parse(maxTextBox.Text);
                result = await Calc(maxValue);
                maxLabel.Text = result.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                maxTextBox.Text = "";
                return;
            }
        }
    }
}
