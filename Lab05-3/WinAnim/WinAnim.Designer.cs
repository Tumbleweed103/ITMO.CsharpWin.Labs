
namespace WinAnim
{
    partial class WinAnim
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
            this.btnAW_BLEND = new System.Windows.Forms.Button();
            this.btnHOR_AW_SLIDE = new System.Windows.Forms.Button();
            this.btnCNTR_AW_SLIDE = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAW_BLEND
            // 
            this.btnAW_BLEND.Location = new System.Drawing.Point(31, 29);
            this.btnAW_BLEND.Name = "btnAW_BLEND";
            this.btnAW_BLEND.Size = new System.Drawing.Size(168, 23);
            this.btnAW_BLEND.TabIndex = 0;
            this.btnAW_BLEND.Text = "Blend";
            this.btnAW_BLEND.UseVisualStyleBackColor = true;
            this.btnAW_BLEND.Click += new System.EventHandler(this.btnAW_BLEND_Click);
            // 
            // btnHOR_AW_SLIDE
            // 
            this.btnHOR_AW_SLIDE.Location = new System.Drawing.Point(31, 73);
            this.btnHOR_AW_SLIDE.Name = "btnHOR_AW_SLIDE";
            this.btnHOR_AW_SLIDE.Size = new System.Drawing.Size(168, 23);
            this.btnHOR_AW_SLIDE.TabIndex = 1;
            this.btnHOR_AW_SLIDE.Text = "Horizontal slide";
            this.btnHOR_AW_SLIDE.UseVisualStyleBackColor = true;
            this.btnHOR_AW_SLIDE.Click += new System.EventHandler(this.btnHOR_AW_SLIDE_Click);
            // 
            // btnCNTR_AW_SLIDE
            // 
            this.btnCNTR_AW_SLIDE.Location = new System.Drawing.Point(31, 117);
            this.btnCNTR_AW_SLIDE.Name = "btnCNTR_AW_SLIDE";
            this.btnCNTR_AW_SLIDE.Size = new System.Drawing.Size(168, 23);
            this.btnCNTR_AW_SLIDE.TabIndex = 2;
            this.btnCNTR_AW_SLIDE.Text = "Center slide";
            this.btnCNTR_AW_SLIDE.UseVisualStyleBackColor = true;
            this.btnCNTR_AW_SLIDE.Click += new System.EventHandler(this.btnCNTR_AW_SLIDE_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(31, 160);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // WinAnim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(225, 212);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCNTR_AW_SLIDE);
            this.Controls.Add(this.btnHOR_AW_SLIDE);
            this.Controls.Add(this.btnAW_BLEND);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WinAnim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window animation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAW_BLEND;
        private System.Windows.Forms.Button btnHOR_AW_SLIDE;
        private System.Windows.Forms.Button btnCNTR_AW_SLIDE;
        private System.Windows.Forms.Button btnClose;
    }
}

