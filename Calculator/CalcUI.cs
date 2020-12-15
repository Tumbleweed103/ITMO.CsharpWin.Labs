using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Calculator;

namespace SimpleCalculator
{
	/// <summary>
	/// Summary description for CalcUI.
	/// </summary>
	public class CalcUI : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox VersionInfo;
		private System.Windows.Forms.Button KeyExit;
		private System.Windows.Forms.Button KeyDate;
		private System.Windows.Forms.TextBox OutputDisplay;
		private System.Windows.Forms.Button KeyClear;
		private System.Windows.Forms.Button KeyMinus;
		private System.Windows.Forms.Button KeyPlus;
		private System.Windows.Forms.Button KeyEqual;
		private System.Windows.Forms.Button KeyMultiply;
		private System.Windows.Forms.Button KeyDivide;
		private System.Windows.Forms.Button KeyPoint;
		private System.Windows.Forms.Button KeySign;
		private System.Windows.Forms.Button KeyZero;
		private System.Windows.Forms.Button KeyNine;
		private System.Windows.Forms.Button KeyEight;
		private System.Windows.Forms.Button KeySeven;
		private System.Windows.Forms.Button KeySix;
		private System.Windows.Forms.Button KeyFive;
		private System.Windows.Forms.Button KeyFour;
		private System.Windows.Forms.Button KeyThree;
		private System.Windows.Forms.Button KeyTwo;
		private System.Windows.Forms.Button KeyOne;
        private Button KeyPowerTwo;
        private Button KeyPower;
        private Button KeySquare;
        private Button KeyInverse;
        private Button KeyFactorial;
        private Button KeyCube;

        // Output Display Constants.
        private const string oneOut = "1";
		private const string twoOut = "2";
		private const string threeOut = "3";
		private const string fourOut = "4";
		private const string fiveOut = "5";
		private const string sixOut = "6";
		private const string sevenOut = "7";
		private const string eightOut = "8";
		private const string nineOut = "9";
		private const string zeroOut = "0";
        private ToolTip toolTip;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem toolStripItemSelectType;
        private ToolStripMenuItem toolStripItemBasic;
        private ToolStripMenuItem toolStripItemScientific;
        private ToolStripMenuItem toolStripItemSelectEquations;
        private ToolStripMenuItem toolStripItemQuadraticEquation;
        private IContainer components;

        public CalcUI()
		{
			//
			// Required for Windows Form Designer support
			//

			InitializeComponent();
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            //
            // Get version information from the Calculator Module.
            //

            VersionInfo.Text = CalcEngine.GetVersion();
			OutputDisplay.Text = "0";
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.KeyDate = new System.Windows.Forms.Button();
            this.KeyOne = new System.Windows.Forms.Button();
            this.VersionInfo = new System.Windows.Forms.TextBox();
            this.KeySix = new System.Windows.Forms.Button();
            this.KeyFive = new System.Windows.Forms.Button();
            this.KeyEqual = new System.Windows.Forms.Button();
            this.KeyTwo = new System.Windows.Forms.Button();
            this.KeyZero = new System.Windows.Forms.Button();
            this.KeyThree = new System.Windows.Forms.Button();
            this.KeyPlus = new System.Windows.Forms.Button();
            this.KeyExit = new System.Windows.Forms.Button();
            this.KeySign = new System.Windows.Forms.Button();
            this.KeySeven = new System.Windows.Forms.Button();
            this.KeyPoint = new System.Windows.Forms.Button();
            this.KeyNine = new System.Windows.Forms.Button();
            this.OutputDisplay = new System.Windows.Forms.TextBox();
            this.KeyMinus = new System.Windows.Forms.Button();
            this.KeyEight = new System.Windows.Forms.Button();
            this.KeyMultiply = new System.Windows.Forms.Button();
            this.KeyFour = new System.Windows.Forms.Button();
            this.KeyClear = new System.Windows.Forms.Button();
            this.KeyDivide = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripItemSelectType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemBasic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemScientific = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemSelectEquations = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemQuadraticEquation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyDate
            // 
            this.KeyDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyDate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDate.ForeColor = System.Drawing.Color.Red;
            this.KeyDate.Location = new System.Drawing.Point(241, 152);
            this.KeyDate.Name = "KeyDate";
            this.KeyDate.Size = new System.Drawing.Size(67, 47);
            this.KeyDate.TabIndex = 19;
            this.KeyDate.TabStop = false;
            this.KeyDate.Text = "Date";
            this.toolTip.SetToolTip(this.KeyDate, "Display current date and time");
            this.KeyDate.Click += new System.EventHandler(this.KeyDate_Click);
            // 
            // KeyOne
            // 
            this.KeyOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyOne.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyOne.ForeColor = System.Drawing.Color.DarkGreen;
            this.KeyOne.Location = new System.Drawing.Point(11, 208);
            this.KeyOne.Name = "KeyOne";
            this.KeyOne.Size = new System.Drawing.Size(48, 46);
            this.KeyOne.TabIndex = 2;
            this.KeyOne.TabStop = false;
            this.KeyOne.Text = "1";
            this.KeyOne.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // VersionInfo
            // 
            this.VersionInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VersionInfo.Cursor = System.Windows.Forms.Cursors.No;
            this.VersionInfo.Font = new System.Drawing.Font("Verdana", 8F);
            this.VersionInfo.Location = new System.Drawing.Point(11, 31);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.ReadOnly = true;
            this.VersionInfo.Size = new System.Drawing.Size(297, 24);
            this.VersionInfo.TabIndex = 0;
            this.VersionInfo.TabStop = false;
            this.VersionInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeySix
            // 
            this.KeySix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeySix.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySix.ForeColor = System.Drawing.Color.DarkGreen;
            this.KeySix.Location = new System.Drawing.Point(126, 152);
            this.KeySix.Name = "KeySix";
            this.KeySix.Size = new System.Drawing.Size(48, 47);
            this.KeySix.TabIndex = 7;
            this.KeySix.TabStop = false;
            this.KeySix.Text = "6";
            this.KeySix.Click += new System.EventHandler(this.KeySix_Click);
            // 
            // KeyFive
            // 
            this.KeyFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyFive.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFive.ForeColor = System.Drawing.Color.DarkGreen;
            this.KeyFive.Location = new System.Drawing.Point(68, 152);
            this.KeyFive.Name = "KeyFive";
            this.KeyFive.Size = new System.Drawing.Size(48, 47);
            this.KeyFive.TabIndex = 6;
            this.KeyFive.TabStop = false;
            this.KeyFive.Text = "5";
            this.KeyFive.Click += new System.EventHandler(this.KeyFive_Click);
            // 
            // KeyEqual
            // 
            this.KeyEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyEqual.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEqual.ForeColor = System.Drawing.Color.Red;
            this.KeyEqual.Location = new System.Drawing.Point(241, 263);
            this.KeyEqual.Name = "KeyEqual";
            this.KeyEqual.Size = new System.Drawing.Size(67, 46);
            this.KeyEqual.TabIndex = 18;
            this.KeyEqual.TabStop = false;
            this.KeyEqual.Text = "=";
            this.toolTip.SetToolTip(this.KeyEqual, "Calculate");
            this.KeyEqual.Click += new System.EventHandler(this.KeyEqual_Click);
            // 
            // KeyTwo
            // 
            this.KeyTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyTwo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyTwo.ForeColor = System.Drawing.Color.DarkGreen;
            this.KeyTwo.Location = new System.Drawing.Point(68, 208);
            this.KeyTwo.Name = "KeyTwo";
            this.KeyTwo.Size = new System.Drawing.Size(48, 46);
            this.KeyTwo.TabIndex = 3;
            this.KeyTwo.TabStop = false;
            this.KeyTwo.Text = "2";
            this.KeyTwo.Click += new System.EventHandler(this.KeyTwo_Click);
            // 
            // KeyZero
            // 
            this.KeyZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyZero.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyZero.ForeColor = System.Drawing.Color.DarkGreen;
            this.KeyZero.Location = new System.Drawing.Point(11, 263);
            this.KeyZero.Name = "KeyZero";
            this.KeyZero.Size = new System.Drawing.Size(48, 46);
            this.KeyZero.TabIndex = 11;
            this.KeyZero.TabStop = false;
            this.KeyZero.Text = "0";
            this.KeyZero.Click += new System.EventHandler(this.KeyZero_Click);
            // 
            // KeyThree
            // 
            this.KeyThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyThree.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyThree.ForeColor = System.Drawing.Color.DarkGreen;
            this.KeyThree.Location = new System.Drawing.Point(126, 208);
            this.KeyThree.Name = "KeyThree";
            this.KeyThree.Size = new System.Drawing.Size(48, 46);
            this.KeyThree.TabIndex = 4;
            this.KeyThree.TabStop = false;
            this.KeyThree.Text = "3";
            this.KeyThree.Click += new System.EventHandler(this.KeyThree_Click);
            // 
            // KeyPlus
            // 
            this.KeyPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyPlus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPlus.ForeColor = System.Drawing.Color.Red;
            this.KeyPlus.Location = new System.Drawing.Point(183, 263);
            this.KeyPlus.Name = "KeyPlus";
            this.KeyPlus.Size = new System.Drawing.Size(48, 46);
            this.KeyPlus.TabIndex = 12;
            this.KeyPlus.TabStop = false;
            this.KeyPlus.Text = "+";
            this.toolTip.SetToolTip(this.KeyPlus, "Add");
            this.KeyPlus.Click += new System.EventHandler(this.KeyPlus_Click);
            // 
            // KeyExit
            // 
            this.KeyExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyExit.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyExit.ForeColor = System.Drawing.Color.Red;
            this.KeyExit.Location = new System.Drawing.Point(241, 208);
            this.KeyExit.Name = "KeyExit";
            this.KeyExit.Size = new System.Drawing.Size(67, 46);
            this.KeyExit.TabIndex = 21;
            this.KeyExit.TabStop = false;
            this.KeyExit.Text = "Exit";
            this.toolTip.SetToolTip(this.KeyExit, "Close the calculator");
            this.KeyExit.Click += new System.EventHandler(this.KeyExit_Click);
            // 
            // KeySign
            // 
            this.KeySign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeySign.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.KeySign.ForeColor = System.Drawing.Color.DarkGreen;
            this.KeySign.Location = new System.Drawing.Point(126, 263);
            this.KeySign.Name = "KeySign";
            this.KeySign.Size = new System.Drawing.Size(48, 46);
            this.KeySign.TabIndex = 16;
            this.KeySign.TabStop = false;
            this.KeySign.Text = "+/-";
            this.toolTip.SetToolTip(this.KeySign, "Change sign");
            this.KeySign.Click += new System.EventHandler(this.KeySign_Click);
            // 
            // KeySeven
            // 
            this.KeySeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeySeven.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySeven.ForeColor = System.Drawing.Color.DarkGreen;
            this.KeySeven.Location = new System.Drawing.Point(11, 97);
            this.KeySeven.Name = "KeySeven";
            this.KeySeven.Size = new System.Drawing.Size(48, 46);
            this.KeySeven.TabIndex = 8;
            this.KeySeven.TabStop = false;
            this.KeySeven.Text = "7";
            this.KeySeven.Click += new System.EventHandler(this.KeySeven_Click);
            // 
            // KeyPoint
            // 
            this.KeyPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyPoint.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPoint.ForeColor = System.Drawing.Color.DarkGreen;
            this.KeyPoint.Location = new System.Drawing.Point(68, 263);
            this.KeyPoint.Name = "KeyPoint";
            this.KeyPoint.Size = new System.Drawing.Size(48, 46);
            this.KeyPoint.TabIndex = 17;
            this.KeyPoint.TabStop = false;
            this.KeyPoint.Text = ".";
            this.KeyPoint.Click += new System.EventHandler(this.KeyPoint_Click);
            // 
            // KeyNine
            // 
            this.KeyNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyNine.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyNine.ForeColor = System.Drawing.Color.DarkGreen;
            this.KeyNine.Location = new System.Drawing.Point(126, 97);
            this.KeyNine.Name = "KeyNine";
            this.KeyNine.Size = new System.Drawing.Size(48, 46);
            this.KeyNine.TabIndex = 10;
            this.KeyNine.TabStop = false;
            this.KeyNine.Text = "9";
            this.KeyNine.Click += new System.EventHandler(this.KeyNine_Click);
            // 
            // OutputDisplay
            // 
            this.OutputDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OutputDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.OutputDisplay.Location = new System.Drawing.Point(11, 61);
            this.OutputDisplay.Name = "OutputDisplay";
            this.OutputDisplay.ReadOnly = true;
            this.OutputDisplay.Size = new System.Drawing.Size(297, 30);
            this.OutputDisplay.TabIndex = 1;
            this.OutputDisplay.TabStop = false;
            this.OutputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // KeyMinus
            // 
            this.KeyMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyMinus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMinus.ForeColor = System.Drawing.Color.Red;
            this.KeyMinus.Location = new System.Drawing.Point(183, 208);
            this.KeyMinus.Name = "KeyMinus";
            this.KeyMinus.Size = new System.Drawing.Size(48, 46);
            this.KeyMinus.TabIndex = 13;
            this.KeyMinus.TabStop = false;
            this.KeyMinus.Text = "-";
            this.toolTip.SetToolTip(this.KeyMinus, "Subtract");
            this.KeyMinus.Click += new System.EventHandler(this.KeyMinus_Click);
            // 
            // KeyEight
            // 
            this.KeyEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyEight.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEight.ForeColor = System.Drawing.Color.DarkGreen;
            this.KeyEight.Location = new System.Drawing.Point(68, 97);
            this.KeyEight.Name = "KeyEight";
            this.KeyEight.Size = new System.Drawing.Size(48, 46);
            this.KeyEight.TabIndex = 9;
            this.KeyEight.TabStop = false;
            this.KeyEight.Text = "8";
            this.KeyEight.Click += new System.EventHandler(this.KeyEight_Click);
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyMultiply.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMultiply.ForeColor = System.Drawing.Color.Red;
            this.KeyMultiply.Location = new System.Drawing.Point(183, 152);
            this.KeyMultiply.Name = "KeyMultiply";
            this.KeyMultiply.Size = new System.Drawing.Size(48, 47);
            this.KeyMultiply.TabIndex = 14;
            this.KeyMultiply.TabStop = false;
            this.KeyMultiply.Text = "*";
            this.toolTip.SetToolTip(this.KeyMultiply, "Multiply");
            this.KeyMultiply.Click += new System.EventHandler(this.KeyMultiply_Click);
            // 
            // KeyFour
            // 
            this.KeyFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyFour.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFour.ForeColor = System.Drawing.Color.DarkGreen;
            this.KeyFour.Location = new System.Drawing.Point(11, 152);
            this.KeyFour.Name = "KeyFour";
            this.KeyFour.Size = new System.Drawing.Size(48, 47);
            this.KeyFour.TabIndex = 5;
            this.KeyFour.TabStop = false;
            this.KeyFour.Text = "4";
            this.KeyFour.Click += new System.EventHandler(this.KeyFour_Click);
            // 
            // KeyClear
            // 
            this.KeyClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyClear.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyClear.ForeColor = System.Drawing.Color.Red;
            this.KeyClear.Location = new System.Drawing.Point(241, 97);
            this.KeyClear.Name = "KeyClear";
            this.KeyClear.Size = new System.Drawing.Size(67, 46);
            this.KeyClear.TabIndex = 20;
            this.KeyClear.TabStop = false;
            this.KeyClear.Text = "C";
            this.toolTip.SetToolTip(this.KeyClear, "Clear");
            this.KeyClear.Click += new System.EventHandler(this.KeyClear_Click);
            // 
            // KeyDivide
            // 
            this.KeyDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyDivide.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDivide.ForeColor = System.Drawing.Color.Red;
            this.KeyDivide.Location = new System.Drawing.Point(183, 97);
            this.KeyDivide.Name = "KeyDivide";
            this.KeyDivide.Size = new System.Drawing.Size(48, 46);
            this.KeyDivide.TabIndex = 15;
            this.KeyDivide.TabStop = false;
            this.KeyDivide.Text = "/";
            this.toolTip.SetToolTip(this.KeyDivide, "Divide");
            this.KeyDivide.Click += new System.EventHandler(this.KeyDivide_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemSelectType,
            this.toolStripItemSelectEquations});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(320, 28);
            this.MenuStrip.TabIndex = 22;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // toolStripItemSelectType
            // 
            this.toolStripItemSelectType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemBasic,
            this.toolStripItemScientific});
            this.toolStripItemSelectType.Name = "toolStripItemSelectType";
            this.toolStripItemSelectType.Size = new System.Drawing.Size(54, 24);
            this.toolStripItemSelectType.Text = "Type";
            // 
            // toolStripItemBasic
            // 
            this.toolStripItemBasic.Checked = true;
            this.toolStripItemBasic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripItemBasic.Name = "toolStripItemBasic";
            this.toolStripItemBasic.Size = new System.Drawing.Size(224, 26);
            this.toolStripItemBasic.Text = "Basic";
            this.toolStripItemBasic.Click += new System.EventHandler(this.toolStripItemBasic_Click);
            // 
            // toolStripItemScientific
            // 
            this.toolStripItemScientific.Name = "toolStripItemScientific";
            this.toolStripItemScientific.Size = new System.Drawing.Size(224, 26);
            this.toolStripItemScientific.Text = "Scientific";
            this.toolStripItemScientific.Click += new System.EventHandler(this.toolStripItemScientific_Click);
            // 
            // toolStripItemSelectEquations
            // 
            this.toolStripItemSelectEquations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemQuadraticEquation});
            this.toolStripItemSelectEquations.Name = "toolStripItemSelectEquations";
            this.toolStripItemSelectEquations.Size = new System.Drawing.Size(88, 24);
            this.toolStripItemSelectEquations.Text = "Equations";
            // 
            // toolStripItemQuadraticEquation
            // 
            this.toolStripItemQuadraticEquation.Name = "toolStripItemQuadraticEquation";
            this.toolStripItemQuadraticEquation.Size = new System.Drawing.Size(224, 26);
            this.toolStripItemQuadraticEquation.Text = "Quadratic equation";
            this.toolStripItemQuadraticEquation.Click += new System.EventHandler(this.toolStripItemQuadraticEquation_Click);
            // 
            // CalcUI
            // 
            this.AcceptButton = this.KeyZero;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(320, 320);
            this.Controls.Add(this.KeyOne);
            this.Controls.Add(this.KeyTwo);
            this.Controls.Add(this.KeyThree);
            this.Controls.Add(this.KeyFour);
            this.Controls.Add(this.KeyFive);
            this.Controls.Add(this.KeySix);
            this.Controls.Add(this.KeySeven);
            this.Controls.Add(this.KeyEight);
            this.Controls.Add(this.KeyNine);
            this.Controls.Add(this.KeyZero);
            this.Controls.Add(this.KeyPlus);
            this.Controls.Add(this.KeyMinus);
            this.Controls.Add(this.KeyMultiply);
            this.Controls.Add(this.KeyDivide);
            this.Controls.Add(this.KeySign);
            this.Controls.Add(this.KeyPoint);
            this.Controls.Add(this.KeyEqual);
            this.Controls.Add(this.KeyDate);
            this.Controls.Add(this.KeyClear);
            this.Controls.Add(this.KeyExit);
            this.Controls.Add(this.OutputDisplay);
            this.Controls.Add(this.VersionInfo);
            this.Controls.Add(this.MenuStrip);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "CalcUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.TopMost = true;
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		protected void KeyPlus_Click(object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation(CalcEngine.Operator.eAdd);
		}

		protected void KeyMinus_Click(object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation(CalcEngine.Operator.eSubtract);
		}

		protected void KeyMultiply_Click(object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation(CalcEngine.Operator.eMultiply);
		}

		protected void KeyDivide_Click(object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation(CalcEngine.Operator.eDivide);
		}

		//
		// Other non-numeric key click methods.
		//

		protected void KeySign_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcSign();
		}

		protected void KeyPoint_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcDecimal();
		}

		protected void KeyDate_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.GetDate();
			CalcEngine.CalcReset();
		}

		protected void KeyClear_Click(object sender, System.EventArgs e)
		{
			CalcEngine.CalcReset();
			OutputDisplay.Text = "0";
		}

		//
		// Perform the calculation.
		//

		protected void KeyEqual_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcEqual();
			CalcEngine.CalcReset();
		}

		//
		// Numeric key click methods.
		//

		protected void KeyNine_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(nineOut);
		}

		protected void KeyEight_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(eightOut);
		}

		protected void KeySeven_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(sevenOut);
		}

		protected void KeySix_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(sixOut);
		}

		protected void KeyFive_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(fiveOut);
		}

		protected void KeyFour_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(fourOut);
		}

		protected void KeyThree_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(threeOut);
		}

		protected void KeyTwo_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(twoOut);
		}

		protected void KeyOne_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(oneOut);
		}

		protected void KeyZero_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(zeroOut);
		}

		//
		// End the program.
		//

		protected void KeyExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new CalcUI());
        }

        private void toolStripItemScientific_Click(object sender, EventArgs e)
        {
            if (!toolStripItemScientific.Checked)
            {
                toolStripItemBasic.Checked = false;
                toolStripItemScientific.Checked = true;
                this.Width = 420;
                MenuStrip.Width = this.Width;
                VersionInfo.Width = 395;
                OutputDisplay.Width = 395;

                KeyClear.Location = new Point(344, 92);
                KeyClear.Height = 96;
                KeyDate.Location = new Point(275, 198);
                KeyDate.Height = 42;
                KeyExit.Location = new Point(275, 250);
                KeyExit.Height = 43;
                KeyEqual.Location = new Point(344, 198);
                KeyEqual.Height = 95;

                KeyPowerTwo = new Button();
                KeyPowerTwo.Font = new Font("Courier New", 10F, FontStyle.Bold);
                KeyPowerTwo.ForeColor = Color.Red;
                KeyPowerTwo.FlatStyle = FlatStyle.Flat;
                KeyPowerTwo.Size = new Size(48, 43);
                KeyPowerTwo.Location = new Point(219, 92);
                KeyPowerTwo.Text = "x²";
                toolTip.SetToolTip(KeyPowerTwo, "X to power 2");
                KeyPowerTwo.Click += new System.EventHandler(KeyPowerTwo_Click);
                this.Controls.Add(KeyPowerTwo);

                KeyPower = new Button();
                KeyPower.Font = new Font("Courier New", 10F, FontStyle.Bold);
                KeyPower.ForeColor = Color.Red;
                KeyPower.FlatStyle = FlatStyle.Flat;
                KeyPower.Size = new Size(48, 44);
                KeyPower.Location = new Point(219, 144);
                KeyPower.Text = "xⁿ";
                toolTip.SetToolTip(KeyPower, "X to power N");
                KeyPower.Click += new System.EventHandler(KeyPower_Click);
                this.Controls.Add(KeyPower);

                KeySquare = new Button();
                KeySquare.Font = new Font("Courier New", 10F, FontStyle.Bold);
                KeySquare.ForeColor = Color.Red;
                KeySquare.FlatStyle = FlatStyle.Flat;
                KeySquare.Size = new Size(48, 42);
                KeySquare.Location = new Point(219, 198);
                KeySquare.Text = "√x";
                toolTip.SetToolTip(KeySquare, "Square root of X");
                KeySquare.Click += new System.EventHandler(KeySquare_Click);
                this.Controls.Add(KeySquare);

                KeyInverse = new Button();
                KeyInverse.Font = new Font("Courier New", 10F, FontStyle.Bold);
                KeyInverse.ForeColor = Color.Red;
                KeyInverse.FlatStyle = FlatStyle.Flat;
                KeyInverse.Size = new Size(48, 43);
                KeyInverse.Location = new Point(219, 250);
                KeyInverse.Text = "1/x";
                toolTip.SetToolTip(KeyInverse, "Inverse X");
                KeyInverse.Click += new System.EventHandler(KeyInverse_Click);
                this.Controls.Add(KeyInverse);

                KeyFactorial = new Button();
                KeyFactorial.Font = new Font("Courier New", 10F, FontStyle.Bold);
                KeyFactorial.ForeColor = Color.Red;
                KeyFactorial.FlatStyle = FlatStyle.Flat;
                KeyFactorial.Size = new Size(62, 43);
                KeyFactorial.Location = new Point(275, 92);
                KeyFactorial.Text = "!x";
                toolTip.SetToolTip(KeyFactorial, "Factorial of X");
                KeyFactorial.Click += new System.EventHandler(KeyFactorial_Click);
                this.Controls.Add(KeyFactorial);

                KeyCube = new Button();
                KeyCube.Font = new Font("Courier New", 10F, FontStyle.Bold);
                KeyCube.ForeColor = Color.Red;
                KeyCube.FlatStyle = FlatStyle.Flat;
                KeyCube.Size = new Size(62, 44);
                KeyCube.Location = new Point(275, 144);
                KeyCube.Text = "∛X";
                toolTip.SetToolTip(KeyCube, "Cube root of X");
                KeyCube.Click += new System.EventHandler(KeyCube_Click);
                this.Controls.Add(KeyCube);
            }
        }

        private void toolStripItemBasic_Click(object sender, EventArgs e)
        {
            if (!toolStripItemBasic.Checked)
            {
                toolStripItemBasic.Checked = true;
                toolStripItemScientific.Checked = false;

                this.Width = 298;
                MenuStrip.Width = this.Width;
                VersionInfo.Width = 269;
                OutputDisplay.Width = 269;

                KeyClear.Location = new Point(218, 92);
                KeyClear.Height = 43;
                KeyDate.Location = new Point(218, 144);
                KeyDate.Height = 44;
                KeyExit.Location = new Point(218, 197);
                KeyExit.Height = 43;
                KeyEqual.Location = new Point(218, 249);
                KeyEqual.Height = 44;

                KeyPowerTwo.Click -= new System.EventHandler(KeyPowerTwo_Click);
                this.Controls.Remove(KeyPowerTwo);
                KeyPowerTwo.Dispose();

                KeyPower.Click -= new System.EventHandler(KeyPower_Click);
                this.Controls.Remove(KeyPower);
                KeyPower.Dispose();

                KeySquare.Click -= new System.EventHandler(KeySquare_Click);
                this.Controls.Remove(KeySquare);
                KeySquare.Dispose();

                KeyInverse.Click -= new System.EventHandler(KeyInverse_Click);
                this.Controls.Remove(KeyInverse);
                KeyInverse.Dispose();

                KeyFactorial.Click -= new System.EventHandler(KeyFactorial_Click);
                this.Controls.Remove(KeyFactorial);
                KeyFactorial.Dispose();

                KeyCube.Click -= new System.EventHandler(KeyCube_Click);
                this.Controls.Remove(KeyCube);
                KeyCube.Dispose();
            }
        }

        protected void KeyPowerTwo_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcPowerTwo();
        }

        protected void KeyPower_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.ePower);
        }

        protected void KeySquare_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSquare();
        }

        protected void KeyInverse_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcInverse();
        }

        protected void KeyFactorial_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcFactorial();
        }

        protected void KeyCube_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcCube();
        }

        private void toolStripItemQuadraticEquation_Click(object sender, EventArgs e)
        {
            QuadEquation quadEquationDialog = new QuadEquation();
            quadEquationDialog.Show();
        }
    }
}
