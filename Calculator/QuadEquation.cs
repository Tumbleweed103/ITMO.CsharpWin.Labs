using Calculator;
using System;
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
            int a = Convert.ToInt32(textBoxA.Text);
            int b = Convert.ToInt32(textBoxB.Text);
            int c = Convert.ToInt32(textBoxC.Text);
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
    }
}
