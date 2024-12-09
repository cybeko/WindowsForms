using Library;
using System.Windows.Forms;

namespace Library
{
    public partial class LibraryForm : Form, ILibraryView
    {
        public Book CurrentBook { get; set; }
        public event EventHandler<EventArgs> SaveToFileEvent;
        public event EventHandler<EventArgs> DeleteFromFileEvent;
        public LibraryForm()
        {
            InitializeComponent();
            CurrentBook = new Book();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            GetBookInfo();
            SaveToFileEvent?.Invoke(this, EventArgs.Empty);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteFromFileEvent?.Invoke(this, EventArgs.Empty);
        }
        public void GetBookInfo()
        {
            CurrentBook.Title = bookName.Text;
            CurrentBook.Author = authorName.Text;
            CurrentBook.Genre = bookGenre.Text;
            CurrentBook.YearPublished = int.Parse(bookYearPublished.Text);
        }
        public void DisplayBooks(List<Book> books)
        {
            bookList.Items.Clear();

            foreach (var book in books)
            {
                bookList.Items.Add(book);
            }
        }
        public int GetSelectedBookId()
        {
            if (bookList.SelectedItem is Book selectedBook)
            {
                return selectedBook.Id;
            }
            return -1;
        }

    }
}
