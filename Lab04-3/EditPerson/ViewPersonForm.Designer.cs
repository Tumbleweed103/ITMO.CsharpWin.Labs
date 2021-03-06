﻿
namespace EditPerson
{
    partial class ViewPersonForm
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
            this.addPersonButton = new System.Windows.Forms.Button();
            this.editPersonButton = new System.Windows.Forms.Button();
            this.viewPersonButton = new System.Windows.Forms.Button();
            this.columnFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personListView = new System.Windows.Forms.ListView();
            this.personTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(28, 324);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(92, 23);
            this.addPersonButton.TabIndex = 1;
            this.addPersonButton.Text = "Add";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editPersonButton
            // 
            this.editPersonButton.Location = new System.Drawing.Point(163, 324);
            this.editPersonButton.Name = "editPersonButton";
            this.editPersonButton.Size = new System.Drawing.Size(92, 23);
            this.editPersonButton.TabIndex = 2;
            this.editPersonButton.Text = "Edit";
            this.editPersonButton.UseVisualStyleBackColor = true;
            this.editPersonButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // viewPersonButton
            // 
            this.viewPersonButton.Location = new System.Drawing.Point(296, 324);
            this.viewPersonButton.Name = "viewPersonButton";
            this.viewPersonButton.Size = new System.Drawing.Size(92, 23);
            this.viewPersonButton.TabIndex = 3;
            this.viewPersonButton.Text = "View list";
            this.viewPersonButton.UseVisualStyleBackColor = true;
            this.viewPersonButton.Click += new System.EventHandler(this.viewPersonButton_Click);
            // 
            // columnFirstName
            // 
            this.columnFirstName.Text = "First Name";
            this.columnFirstName.Width = 122;
            // 
            // columnLastName
            // 
            this.columnLastName.Text = "Last Name";
            this.columnLastName.Width = 138;
            // 
            // columnAge
            // 
            this.columnAge.Text = "Age";
            this.columnAge.Width = 79;
            // 
            // personListView
            // 
            this.personListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFirstName,
            this.columnLastName,
            this.columnAge});
            this.personListView.GridLines = true;
            this.personListView.HideSelection = false;
            this.personListView.Location = new System.Drawing.Point(12, 12);
            this.personListView.Name = "personListView";
            this.personListView.Size = new System.Drawing.Size(400, 289);
            this.personListView.TabIndex = 0;
            this.personListView.UseCompatibleStateImageBehavior = false;
            this.personListView.View = System.Windows.Forms.View.Details;
            this.personListView.VirtualMode = true;
            // 
            // personTextBox
            // 
            this.personTextBox.Location = new System.Drawing.Point(12, 364);
            this.personTextBox.Name = "personTextBox";
            this.personTextBox.Size = new System.Drawing.Size(400, 164);
            this.personTextBox.TabIndex = 4;
            this.personTextBox.Text = "";
            // 
            // ViewPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 540);
            this.Controls.Add(this.personTextBox);
            this.Controls.Add(this.viewPersonButton);
            this.Controls.Add(this.editPersonButton);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.personListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ViewPersonForm";
            this.Text = "Employee list";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.Button editPersonButton;
        private System.Windows.Forms.Button viewPersonButton;
        private System.Windows.Forms.ColumnHeader columnFirstName;
        private System.Windows.Forms.ColumnHeader columnLastName;
        private System.Windows.Forms.ColumnHeader columnAge;
        private System.Windows.Forms.ListView personListView;
        private System.Windows.Forms.RichTextBox personTextBox;
    }
}

