
namespace BiblWorm
{
    partial class FormLibrary
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.labelBookPeriod = new System.Windows.Forms.Label();
            this.labelBookInv = new System.Windows.Forms.Label();
            this.labelBookYear = new System.Windows.Forms.Label();
            this.labelBookPages = new System.Windows.Forms.Label();
            this.labelBookPublisher = new System.Windows.Forms.Label();
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.labelBookAuthor = new System.Windows.Forms.Label();
            this.numericBookPeriod = new System.Windows.Forms.NumericUpDown();
            this.numericBookInv = new System.Windows.Forms.NumericUpDown();
            this.numericBookYear = new System.Windows.Forms.NumericUpDown();
            this.textBookPublisher = new System.Windows.Forms.TextBox();
            this.textBookTitle = new System.Windows.Forms.TextBox();
            this.buttonBookAdd = new System.Windows.Forms.Button();
            this.numericBookPages = new System.Windows.Forms.NumericUpDown();
            this.textBookAuthor = new System.Windows.Forms.TextBox();
            this.checkBookReturn = new System.Windows.Forms.CheckBox();
            this.checkBookAvailable = new System.Windows.Forms.CheckBox();
            this.tabMagazines = new System.Windows.Forms.TabPage();
            this.buttonMagazineAdd = new System.Windows.Forms.Button();
            this.checkMagazineSubs = new System.Windows.Forms.CheckBox();
            this.checkMagazineAvailable = new System.Windows.Forms.CheckBox();
            this.numericMagazineInv = new System.Windows.Forms.NumericUpDown();
            this.labelMagazineInv = new System.Windows.Forms.Label();
            this.numericMagazineYear = new System.Windows.Forms.NumericUpDown();
            this.numericMagazineNumber = new System.Windows.Forms.NumericUpDown();
            this.textMagazineVolume = new System.Windows.Forms.TextBox();
            this.textMagazineTitle = new System.Windows.Forms.TextBox();
            this.labelMagazineYear = new System.Windows.Forms.Label();
            this.labelMagazineNumber = new System.Windows.Forms.Label();
            this.labelMagazineVolume = new System.Windows.Forms.Label();
            this.labelMagazineTitle = new System.Windows.Forms.Label();
            this.checkSorted = new System.Windows.Forms.CheckBox();
            this.richShowBox = new System.Windows.Forms.RichTextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBookPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBookInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBookYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBookPages)).BeginInit();
            this.tabMagazines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMagazineInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMagazineYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMagazineNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBooks);
            this.tabControl.Controls.Add(this.tabMagazines);
            this.tabControl.Location = new System.Drawing.Point(8, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(320, 379);
            this.tabControl.TabIndex = 0;
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.labelBookPeriod);
            this.tabBooks.Controls.Add(this.labelBookInv);
            this.tabBooks.Controls.Add(this.labelBookYear);
            this.tabBooks.Controls.Add(this.labelBookPages);
            this.tabBooks.Controls.Add(this.labelBookPublisher);
            this.tabBooks.Controls.Add(this.labelBookTitle);
            this.tabBooks.Controls.Add(this.labelBookAuthor);
            this.tabBooks.Controls.Add(this.numericBookPeriod);
            this.tabBooks.Controls.Add(this.numericBookInv);
            this.tabBooks.Controls.Add(this.numericBookYear);
            this.tabBooks.Controls.Add(this.textBookPublisher);
            this.tabBooks.Controls.Add(this.textBookTitle);
            this.tabBooks.Controls.Add(this.buttonBookAdd);
            this.tabBooks.Controls.Add(this.numericBookPages);
            this.tabBooks.Controls.Add(this.textBookAuthor);
            this.tabBooks.Controls.Add(this.checkBookReturn);
            this.tabBooks.Controls.Add(this.checkBookAvailable);
            this.tabBooks.Location = new System.Drawing.Point(4, 25);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooks.Size = new System.Drawing.Size(312, 350);
            this.tabBooks.TabIndex = 0;
            this.tabBooks.Text = "Книги";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // labelBookPeriod
            // 
            this.labelBookPeriod.AutoSize = true;
            this.labelBookPeriod.Location = new System.Drawing.Point(7, 183);
            this.labelBookPeriod.Name = "labelBookPeriod";
            this.labelBookPeriod.Size = new System.Drawing.Size(129, 17);
            this.labelBookPeriod.TabIndex = 19;
            this.labelBookPeriod.Text = "Срок пользования";
            // 
            // labelBookInv
            // 
            this.labelBookInv.AutoSize = true;
            this.labelBookInv.Location = new System.Drawing.Point(7, 155);
            this.labelBookInv.Name = "labelBookInv";
            this.labelBookInv.Size = new System.Drawing.Size(98, 17);
            this.labelBookInv.TabIndex = 18;
            this.labelBookInv.Text = "Инвентарный";
            // 
            // labelBookYear
            // 
            this.labelBookYear.AutoSize = true;
            this.labelBookYear.Location = new System.Drawing.Point(7, 127);
            this.labelBookYear.Name = "labelBookYear";
            this.labelBookYear.Size = new System.Drawing.Size(91, 17);
            this.labelBookYear.TabIndex = 17;
            this.labelBookYear.Text = "Год издания";
            // 
            // labelBookPages
            // 
            this.labelBookPages.AutoSize = true;
            this.labelBookPages.Location = new System.Drawing.Point(7, 99);
            this.labelBookPages.Name = "labelBookPages";
            this.labelBookPages.Size = new System.Drawing.Size(64, 17);
            this.labelBookPages.TabIndex = 16;
            this.labelBookPages.Text = "Страниц";
            // 
            // labelBookPublisher
            // 
            this.labelBookPublisher.AutoSize = true;
            this.labelBookPublisher.Location = new System.Drawing.Point(6, 70);
            this.labelBookPublisher.Name = "labelBookPublisher";
            this.labelBookPublisher.Size = new System.Drawing.Size(100, 17);
            this.labelBookPublisher.TabIndex = 15;
            this.labelBookPublisher.Text = "Издательство";
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.Location = new System.Drawing.Point(7, 42);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(72, 17);
            this.labelBookTitle.TabIndex = 14;
            this.labelBookTitle.Text = "Название";
            // 
            // labelBookAuthor
            // 
            this.labelBookAuthor.AutoSize = true;
            this.labelBookAuthor.Location = new System.Drawing.Point(7, 14);
            this.labelBookAuthor.Name = "labelBookAuthor";
            this.labelBookAuthor.Size = new System.Drawing.Size(47, 17);
            this.labelBookAuthor.TabIndex = 13;
            this.labelBookAuthor.Text = "Автор";
            // 
            // numericBookPeriod
            // 
            this.numericBookPeriod.Location = new System.Drawing.Point(153, 183);
            this.numericBookPeriod.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericBookPeriod.Name = "numericBookPeriod";
            this.numericBookPeriod.Size = new System.Drawing.Size(120, 22);
            this.numericBookPeriod.TabIndex = 12;
            // 
            // numericBookInv
            // 
            this.numericBookInv.Location = new System.Drawing.Point(153, 155);
            this.numericBookInv.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericBookInv.Name = "numericBookInv";
            this.numericBookInv.Size = new System.Drawing.Size(120, 22);
            this.numericBookInv.TabIndex = 11;
            // 
            // numericBookYear
            // 
            this.numericBookYear.Location = new System.Drawing.Point(153, 127);
            this.numericBookYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numericBookYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericBookYear.Name = "numericBookYear";
            this.numericBookYear.Size = new System.Drawing.Size(120, 22);
            this.numericBookYear.TabIndex = 10;
            this.numericBookYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // textBookPublisher
            // 
            this.textBookPublisher.Location = new System.Drawing.Point(113, 70);
            this.textBookPublisher.Name = "textBookPublisher";
            this.textBookPublisher.Size = new System.Drawing.Size(185, 22);
            this.textBookPublisher.TabIndex = 9;
            // 
            // textBookTitle
            // 
            this.textBookTitle.Location = new System.Drawing.Point(113, 42);
            this.textBookTitle.Name = "textBookTitle";
            this.textBookTitle.Size = new System.Drawing.Size(185, 22);
            this.textBookTitle.TabIndex = 8;
            // 
            // buttonBookAdd
            // 
            this.buttonBookAdd.Location = new System.Drawing.Point(22, 281);
            this.buttonBookAdd.Name = "buttonBookAdd";
            this.buttonBookAdd.Size = new System.Drawing.Size(261, 51);
            this.buttonBookAdd.TabIndex = 7;
            this.buttonBookAdd.Text = "Добавить";
            this.buttonBookAdd.UseVisualStyleBackColor = true;
            this.buttonBookAdd.Click += new System.EventHandler(this.buttonBookAdd_Click);
            // 
            // numericBookPages
            // 
            this.numericBookPages.Location = new System.Drawing.Point(153, 99);
            this.numericBookPages.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericBookPages.Name = "numericBookPages";
            this.numericBookPages.Size = new System.Drawing.Size(120, 22);
            this.numericBookPages.TabIndex = 2;
            // 
            // textBookAuthor
            // 
            this.textBookAuthor.Location = new System.Drawing.Point(113, 14);
            this.textBookAuthor.Name = "textBookAuthor";
            this.textBookAuthor.Size = new System.Drawing.Size(185, 22);
            this.textBookAuthor.TabIndex = 1;
            // 
            // checkBookReturn
            // 
            this.checkBookReturn.AutoSize = true;
            this.checkBookReturn.Location = new System.Drawing.Point(142, 229);
            this.checkBookReturn.Name = "checkBookReturn";
            this.checkBookReturn.Size = new System.Drawing.Size(156, 21);
            this.checkBookReturn.TabIndex = 4;
            this.checkBookReturn.Text = "Возвращает в срок";
            this.checkBookReturn.UseVisualStyleBackColor = true;
            // 
            // checkBookAvailable
            // 
            this.checkBookAvailable.AutoSize = true;
            this.checkBookAvailable.Location = new System.Drawing.Point(22, 229);
            this.checkBookAvailable.Name = "checkBookAvailable";
            this.checkBookAvailable.Size = new System.Drawing.Size(88, 21);
            this.checkBookAvailable.TabIndex = 3;
            this.checkBookAvailable.Text = "Наличие";
            this.checkBookAvailable.UseVisualStyleBackColor = true;
            // 
            // tabMagazines
            // 
            this.tabMagazines.Controls.Add(this.buttonMagazineAdd);
            this.tabMagazines.Controls.Add(this.checkMagazineSubs);
            this.tabMagazines.Controls.Add(this.checkMagazineAvailable);
            this.tabMagazines.Controls.Add(this.numericMagazineInv);
            this.tabMagazines.Controls.Add(this.labelMagazineInv);
            this.tabMagazines.Controls.Add(this.numericMagazineYear);
            this.tabMagazines.Controls.Add(this.numericMagazineNumber);
            this.tabMagazines.Controls.Add(this.textMagazineVolume);
            this.tabMagazines.Controls.Add(this.textMagazineTitle);
            this.tabMagazines.Controls.Add(this.labelMagazineYear);
            this.tabMagazines.Controls.Add(this.labelMagazineNumber);
            this.tabMagazines.Controls.Add(this.labelMagazineVolume);
            this.tabMagazines.Controls.Add(this.labelMagazineTitle);
            this.tabMagazines.Location = new System.Drawing.Point(4, 25);
            this.tabMagazines.Name = "tabMagazines";
            this.tabMagazines.Padding = new System.Windows.Forms.Padding(3);
            this.tabMagazines.Size = new System.Drawing.Size(312, 350);
            this.tabMagazines.TabIndex = 1;
            this.tabMagazines.Text = "Журналы";
            this.tabMagazines.UseVisualStyleBackColor = true;
            // 
            // buttonMagazineAdd
            // 
            this.buttonMagazineAdd.Location = new System.Drawing.Point(22, 281);
            this.buttonMagazineAdd.Name = "buttonMagazineAdd";
            this.buttonMagazineAdd.Size = new System.Drawing.Size(261, 51);
            this.buttonMagazineAdd.TabIndex = 12;
            this.buttonMagazineAdd.Text = "Добавить";
            this.buttonMagazineAdd.UseVisualStyleBackColor = true;
            this.buttonMagazineAdd.Click += new System.EventHandler(this.buttonMagazineAdd_Click);
            // 
            // checkMagazineSubs
            // 
            this.checkMagazineSubs.AutoSize = true;
            this.checkMagazineSubs.Location = new System.Drawing.Point(142, 229);
            this.checkMagazineSubs.Name = "checkMagazineSubs";
            this.checkMagazineSubs.Size = new System.Drawing.Size(94, 21);
            this.checkMagazineSubs.TabIndex = 11;
            this.checkMagazineSubs.Text = "Подписка";
            this.checkMagazineSubs.UseVisualStyleBackColor = true;
            // 
            // checkMagazineAvailable
            // 
            this.checkMagazineAvailable.AutoSize = true;
            this.checkMagazineAvailable.Location = new System.Drawing.Point(22, 229);
            this.checkMagazineAvailable.Name = "checkMagazineAvailable";
            this.checkMagazineAvailable.Size = new System.Drawing.Size(88, 21);
            this.checkMagazineAvailable.TabIndex = 10;
            this.checkMagazineAvailable.Text = "Наличие";
            this.checkMagazineAvailable.UseVisualStyleBackColor = true;
            // 
            // numericMagazineInv
            // 
            this.numericMagazineInv.Location = new System.Drawing.Point(153, 127);
            this.numericMagazineInv.Name = "numericMagazineInv";
            this.numericMagazineInv.Size = new System.Drawing.Size(120, 22);
            this.numericMagazineInv.TabIndex = 9;
            // 
            // labelMagazineInv
            // 
            this.labelMagazineInv.AutoSize = true;
            this.labelMagazineInv.Location = new System.Drawing.Point(7, 127);
            this.labelMagazineInv.Name = "labelMagazineInv";
            this.labelMagazineInv.Size = new System.Drawing.Size(98, 17);
            this.labelMagazineInv.TabIndex = 8;
            this.labelMagazineInv.Text = "Инвентарный";
            // 
            // numericMagazineYear
            // 
            this.numericMagazineYear.Location = new System.Drawing.Point(153, 99);
            this.numericMagazineYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numericMagazineYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericMagazineYear.Name = "numericMagazineYear";
            this.numericMagazineYear.Size = new System.Drawing.Size(120, 22);
            this.numericMagazineYear.TabIndex = 7;
            this.numericMagazineYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numericMagazineNumber
            // 
            this.numericMagazineNumber.Location = new System.Drawing.Point(153, 70);
            this.numericMagazineNumber.Name = "numericMagazineNumber";
            this.numericMagazineNumber.Size = new System.Drawing.Size(120, 22);
            this.numericMagazineNumber.TabIndex = 6;
            // 
            // textMagazineVolume
            // 
            this.textMagazineVolume.Location = new System.Drawing.Point(113, 42);
            this.textMagazineVolume.Name = "textMagazineVolume";
            this.textMagazineVolume.Size = new System.Drawing.Size(185, 22);
            this.textMagazineVolume.TabIndex = 5;
            // 
            // textMagazineTitle
            // 
            this.textMagazineTitle.Location = new System.Drawing.Point(113, 14);
            this.textMagazineTitle.Name = "textMagazineTitle";
            this.textMagazineTitle.Size = new System.Drawing.Size(185, 22);
            this.textMagazineTitle.TabIndex = 4;
            // 
            // labelMagazineYear
            // 
            this.labelMagazineYear.AutoSize = true;
            this.labelMagazineYear.Location = new System.Drawing.Point(7, 99);
            this.labelMagazineYear.Name = "labelMagazineYear";
            this.labelMagazineYear.Size = new System.Drawing.Size(90, 17);
            this.labelMagazineYear.TabIndex = 3;
            this.labelMagazineYear.Text = "Год выпуска";
            // 
            // labelMagazineNumber
            // 
            this.labelMagazineNumber.AutoSize = true;
            this.labelMagazineNumber.Location = new System.Drawing.Point(6, 70);
            this.labelMagazineNumber.Name = "labelMagazineNumber";
            this.labelMagazineNumber.Size = new System.Drawing.Size(51, 17);
            this.labelMagazineNumber.TabIndex = 2;
            this.labelMagazineNumber.Text = "Номер";
            // 
            // labelMagazineVolume
            // 
            this.labelMagazineVolume.AutoSize = true;
            this.labelMagazineVolume.Location = new System.Drawing.Point(7, 42);
            this.labelMagazineVolume.Name = "labelMagazineVolume";
            this.labelMagazineVolume.Size = new System.Drawing.Size(34, 17);
            this.labelMagazineVolume.TabIndex = 1;
            this.labelMagazineVolume.Text = "Том";
            // 
            // labelMagazineTitle
            // 
            this.labelMagazineTitle.AutoSize = true;
            this.labelMagazineTitle.Location = new System.Drawing.Point(7, 14);
            this.labelMagazineTitle.Name = "labelMagazineTitle";
            this.labelMagazineTitle.Size = new System.Drawing.Size(72, 17);
            this.labelMagazineTitle.TabIndex = 0;
            this.labelMagazineTitle.Text = "Название";
            // 
            // checkSorted
            // 
            this.checkSorted.AutoSize = true;
            this.checkSorted.Location = new System.Drawing.Point(334, 370);
            this.checkSorted.Name = "checkSorted";
            this.checkSorted.Size = new System.Drawing.Size(233, 21);
            this.checkSorted.TabIndex = 5;
            this.checkSorted.Text = "Сортировать по инвентарному";
            this.checkSorted.UseVisualStyleBackColor = true;
            // 
            // richShowBox
            // 
            this.richShowBox.Location = new System.Drawing.Point(334, 12);
            this.richShowBox.Name = "richShowBox";
            this.richShowBox.Size = new System.Drawing.Size(306, 313);
            this.richShowBox.TabIndex = 6;
            this.richShowBox.Text = "";
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(334, 331);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(139, 32);
            this.buttonShow.TabIndex = 8;
            this.buttonShow.Text = "Просмотреть";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // FormLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 403);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.richShowBox);
            this.Controls.Add(this.checkSorted);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormLibrary";
            this.Text = "Библиотека";
            this.tabControl.ResumeLayout(false);
            this.tabBooks.ResumeLayout(false);
            this.tabBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBookPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBookInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBookYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBookPages)).EndInit();
            this.tabMagazines.ResumeLayout(false);
            this.tabMagazines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMagazineInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMagazineYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMagazineNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.TabPage tabMagazines;
        private System.Windows.Forms.TextBox textBookAuthor;
        private System.Windows.Forms.NumericUpDown numericBookPages;
        private System.Windows.Forms.CheckBox checkBookAvailable;
        private System.Windows.Forms.CheckBox checkBookReturn;
        private System.Windows.Forms.CheckBox checkSorted;
        private System.Windows.Forms.RichTextBox richShowBox;
        private System.Windows.Forms.Button buttonBookAdd;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label labelBookPeriod;
        private System.Windows.Forms.Label labelBookInv;
        private System.Windows.Forms.Label labelBookYear;
        private System.Windows.Forms.Label labelBookPages;
        private System.Windows.Forms.Label labelBookPublisher;
        private System.Windows.Forms.Label labelBookTitle;
        private System.Windows.Forms.Label labelBookAuthor;
        private System.Windows.Forms.NumericUpDown numericBookPeriod;
        private System.Windows.Forms.NumericUpDown numericBookInv;
        private System.Windows.Forms.NumericUpDown numericBookYear;
        private System.Windows.Forms.TextBox textBookPublisher;
        private System.Windows.Forms.TextBox textBookTitle;
        private System.Windows.Forms.Label labelMagazineNumber;
        private System.Windows.Forms.Label labelMagazineVolume;
        private System.Windows.Forms.Label labelMagazineTitle;
        private System.Windows.Forms.Label labelMagazineYear;
        private System.Windows.Forms.NumericUpDown numericMagazineYear;
        private System.Windows.Forms.NumericUpDown numericMagazineNumber;
        private System.Windows.Forms.TextBox textMagazineVolume;
        private System.Windows.Forms.TextBox textMagazineTitle;
        private System.Windows.Forms.Label labelMagazineInv;
        private System.Windows.Forms.CheckBox checkMagazineSubs;
        private System.Windows.Forms.CheckBox checkMagazineAvailable;
        private System.Windows.Forms.NumericUpDown numericMagazineInv;
        private System.Windows.Forms.Button buttonMagazineAdd;
    }
}

