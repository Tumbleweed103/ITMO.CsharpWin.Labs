using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private delegate int AsyncSumm(int a, int b);
        delegate void PrintLabel(string str);
        private PrintLabel PrintDelegateFunc;

        private int Summ(int a, int b)
        {
            Thread.Sleep(2000);
            return a + b;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = int.Parse(txbA.Text);
                b = int.Parse(txbB.Text);
                AsyncSumm summDelegate = new AsyncSumm(Summ);
                AsyncCallback cb = new AsyncCallback(CallBackMethod);
                summDelegate.BeginInvoke(a, b, cb, summDelegate);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов произошла ошибка");
            }
        }

        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            AsyncSumm summDelegate = (AsyncSumm)ar.AsyncState;
            str = String.Format($"Сумма введенных чисел равна {summDelegate.EndInvoke(ar)}");
            PrintDelegateFunc = new PrintLabel(PrintFunc);
            lblResult.Invoke(PrintDelegateFunc, new object[] { str });
            MessageBox.Show(str, "Результат операции");
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работа кипит!!!");
        }

        void PrintFunc(string str)
        {
            lblResult.Text = str;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = int.Parse(txbA.Text);
                b = int.Parse(txbB.Text);
                int res = await Subb(a, b);
                lblResult.Text = res.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка"); 
                txbA.Text = txbB.Text = "";
                return;
            }
        }

        private async Task<int> Subb(int a, int b)
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(2000);
                return a - b;
            }
            );
        }
    }
}
