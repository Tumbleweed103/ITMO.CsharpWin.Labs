
namespace SimpleCalculator
{
    partial class QuadEquation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.labelEnterCoefficients = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(9, 45);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(20, 17);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "a:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(9, 73);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(20, 17);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "b:";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(9, 102);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(19, 17);
            this.labelC.TabIndex = 2;
            this.labelC.Text = "c:";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(35, 45);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(70, 22);
            this.textBoxA.TabIndex = 3;
            this.textBoxA.Text = "0";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(35, 73);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(70, 22);
            this.textBoxB.TabIndex = 4;
            this.textBoxB.Text = "0";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(35, 102);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(70, 22);
            this.textBoxC.TabIndex = 5;
            this.textBoxC.Text = "0";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(12, 141);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(254, 22);
            this.textBoxAnswer.TabIndex = 6;
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(129, 45);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(107, 32);
            this.buttonSolve.TabIndex = 7;
            this.buttonSolve.Text = "Solve";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // labelEnterCoefficients
            // 
            this.labelEnterCoefficients.AutoSize = true;
            this.labelEnterCoefficients.Location = new System.Drawing.Point(9, 9);
            this.labelEnterCoefficients.Name = "labelEnterCoefficients";
            this.labelEnterCoefficients.Size = new System.Drawing.Size(141, 17);
            this.labelEnterCoefficients.TabIndex = 8;
            this.labelEnterCoefficients.Text = "Enter the coefficients";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(129, 92);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(107, 32);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // QuadEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 175);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelEnterCoefficients);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "QuadEquation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuadEquation";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label labelEnterCoefficients;
        private System.Windows.Forms.Button buttonCancel;
    }
}