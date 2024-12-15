using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryPresenter
    {
        private readonly IModel _model;
        private readonly ILibraryView _view;

        public LibraryPresenter(IModel model, ILibraryView view)
        {
            _model = model;
            _view = view;

            _view.SaveToFileEvent += OnSaveToFile;
            _view.DeleteFromFileEvent += OnDeleteFromFile;
            _view.ExitEvent += OnExit;
            _view.GetFirstBookEvent += OnGetFirstBook;
            _view.DeleteAllBooksEvent += OnDeleteAllBooks;

            _model.LoadFromFile();
            _view.DisplayBooks(_model.Books);
        }

        private void OnSaveToFile(object sender, EventArgs e)
        {
            _view.GetBookInfo();
            _model.SaveBookToFile(_view.CurrentBook);
            _view.DisplayBooks(_model.Books);
            _view.ClearInputFields();
        }
        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OnGetFirstBook(object sender, EventArgs e)
        {
            if (_model.Books.Any())
            {
                var firstBook = _model.Books.First();
                MessageBox.Show($"First Book:\n\nTitle: {firstBook.Title}\nAuthor: {firstBook.Author}\nGenre: {firstBook.Genre}\nYear: {firstBook.YearPublished}",
                    "First Book", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No books available", "First Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void OnDeleteFromFile(object sender, EventArgs e)
        {
            int bookId = _view.GetSelectedBookId();
            if (bookId != -1)
            {
                _model.DeleteFromFile(bookId);
                _view.DisplayBooks(_model.Books);
            }
            else
            {
                MessageBox.Show("Please select a book to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void OnDeleteAllBooks(object sender, EventArgs e)
        {
            if (_model.Books.Any())
            {
                var res = MessageBox.Show(
                    "Are you sure you want to delete all books?",
                    "Delete All Books",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    _model.DeleteAllBooks();
                    _view.DisplayBooks(_model.Books);
                    MessageBox.Show("All books have been deleted", "Delete All Books", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("There are no books to delete", "Delete All books", MessageBoxButtons.OK);
            }
        }

    }

}
