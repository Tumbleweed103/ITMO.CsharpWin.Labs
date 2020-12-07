using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblWorm
{
    public partial class FormLibrary : Form
    {
        public FormLibrary()
        {
            InitializeComponent();
        }

        public string BookAuthor
        {
            get { return textBookAuthor.Text; }
            set { textBookAuthor.Text = value; }
        }

        public string BookTitle
        {
            get { return textBookTitle.Text; }
            set { textBookTitle.Text = value; }
        }

        public string BookPublisher
        {
            get { return textBookPublisher.Text; }
            set { textBookPublisher.Text = value; }
        }

        public int BookPage
        {
            get { return (int)numericBookPages.Value; }
            set { numericBookPages.Value = value; }
        }

        public int BookYear
        {
            get { return (int)numericBookYear.Value; }
            set { numericBookYear.Value = value; }
        }

        public int BookInvNumber
        {
            get { return (int)numericBookInv.Value; }
            set { numericBookInv.Value = value; }
        }

        public int BookPeriodUse
        {
            get { return (int)numericBookPeriod.Value; }
            set { numericBookPeriod.Value = value; }
        }

        public bool BookAvailable
        {
            get { return checkBookAvailable.Checked; }
            set { checkBookAvailable.Checked = value; }
        }

        public bool Sort
        {
            get { return checkSorted.Checked; }
            set { checkSorted.Checked = value; }
        }

        public bool BookReturnTime
        {
            get { return checkSorted.Checked; }
            set { checkSorted.Checked = value; }
        }

        public string MagazineTitle
        {
            get { return textMagazineTitle.Text; }
            set { textMagazineTitle.Text = value; }
        }

        public string MagazineVolume
        {
            get { return textMagazineVolume.Text; }
            set { textMagazineVolume.Text = value; }
        }

        public int MagazineNumber
        {
            get { return (int)numericMagazineNumber.Value; }
            set { numericMagazineNumber.Value = value; }
        }

        public int MagazineYear
        {
            get { return (int)numericMagazineYear.Value; }
            set { numericMagazineYear.Value = value; }
        }

        public int MagazineInvNumber
        {
            get { return (int)numericMagazineInv.Value; }
            set { numericMagazineInv.Value = value; }
        }

        public bool MagazineAvailable
        {
            get { return checkMagazineAvailable.Checked; }
            set { checkMagazineAvailable.Checked = value; }
        }

        public bool MagazineSubs
        {
            get { return checkMagazineSubs.Checked; }
            set { checkMagazineSubs.Checked = value; }
        }

        List<Item> items = new List<Item>();

        private void buttonBookAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book(BookAuthor, BookTitle, BookPublisher, BookPage, BookYear, BookInvNumber, BookAvailable);

            if (BookReturnTime)
            {
                book.ReturnSrok();
            }
            book.PriceBook(BookPeriodUse);
            items.Add(book);

            BookAuthor = BookTitle = BookPublisher = "";
            BookPage = BookInvNumber = BookPeriodUse = 0;
            BookYear = 1900;
            BookAvailable = BookReturnTime = false;
        }

        private void buttonMagazineAdd_Click(object sender, EventArgs e)
        {
            Magazine magazine = new Magazine(MagazineTitle, MagazineVolume, MagazineNumber, MagazineYear, MagazineInvNumber, MagazineAvailable);

            if (checkMagazineSubs.Checked)
            {
                magazine.IfSubs = true;
            }
            items.Add(magazine);

            MagazineTitle = MagazineVolume = "";
            MagazineNumber = MagazineInvNumber = 0;
            MagazineYear = 1900;
            MagazineAvailable = MagazineSubs = false;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (Sort)
            {
                items.Sort();
            }

            StringBuilder sb = new StringBuilder();
            foreach (Item item in items)
            {
                sb.Append("\n" + item.ToString());
            }
            richShowBox.Text = sb.ToString();
        }
    }
}
