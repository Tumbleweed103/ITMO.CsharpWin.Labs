using Calculator;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class QuadEquation : Form
    {
        double root1;
        double root2;

        public QuadEquation()
        {
            InitializeComponent();
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBoxA.Text, CultureInfo.InvariantCulture);
            double b = Convert.ToDouble(textBoxB.Text, CultureInfo.InvariantCulture);
            double c = Convert.ToDouble(textBoxC.Text, CultureInfo.InvariantCulture);
            int result = CalcEngine.CalcQuadEquationRoots(a, b, c, out root1, out root2);

            if (result == 1)
            {
                textBoxAnswer.Text = $"Two roots: {root1:F2} and {root2:F2}";
            }
            if (result == 0)
            {
                textBoxAnswer.Text = $"Double root: {root1:F2}";
            }
            if (result == -1)
            {
                textBoxAnswer.Text = "No roots";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxA_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxA.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxA, "Can't be empty");
            }
            else
            {
                try
                {
                    double val = double.Parse(textBoxA.Text, CultureInfo.InvariantCulture);
                    if (val == 0)
                    {
                        e.Cancel = true;
                        errorProvider.SetError(textBoxA, "Can't be 0");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProvider.Clear();
                    }
                }
                catch
                {
                    e.Cancel = true;
                    errorProvider.SetError(textBoxA, "Must be a number");
                }
            }
        }

        private void textBoxB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxB.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxB, "Can't be empty");
            }
            else
            {
                try
                {
                    double val = double.Parse(textBoxB.Text, CultureInfo.InvariantCulture);
                    e.Cancel = false;
                    errorProvider.Clear();
                }
                catch
                {
                    e.Cancel = true;
                    errorProvider.SetError(textBoxB, "Must be a number");
                }
            }
        }

        private void textBoxC_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxC.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxB, "Can't be empty");
            }
            else
            {
                try
                {
                    double val = double.Parse(textBoxC.Text, CultureInfo.InvariantCulture);
                    e.Cancel = false;
                    errorProvider.Clear();
                }
                catch
                {
                    e.Cancel = true;
                    errorProvider.SetError(textBoxC, "Must be a number");
                }
            }
        }
    }
}
