namespace Library
{
    public partial class LibraryForm : Form, ILibraryView
    {
        public Book CurrentBook { get; set; }
        public event EventHandler<EventArgs> SaveToFileEvent;
        public event EventHandler<EventArgs> DeleteFromFileEvent;
        public event EventHandler<EventArgs> ExitEvent;
        public event EventHandler<EventArgs> GetFirstBookEvent;
        public event EventHandler<EventArgs> DeleteAllBooksEvent;

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
            CurrentBook.Title = bookTitle.Text;
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitEvent?.Invoke(this, EventArgs.Empty);
        }

        private void getFirstBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetFirstBookEvent?.Invoke(this, EventArgs.Empty);
        }

        private void deleteAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAllBooksEvent?.Invoke(this, EventArgs.Empty);
        }
        public void ClearInputFields()
        {
            bookTitle.Clear();
            authorName.Clear();
            bookGenre.Clear();
            bookYearPublished.Clear();
        }
    }
}
