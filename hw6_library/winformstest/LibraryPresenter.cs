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

            _model.LoadFromFile();
            _view.DisplayBooks(_model.Books);
        }

        private void OnSaveToFile(object sender, EventArgs e)
        {
            _view.GetBookInfo();
            _model.SaveToFile(_view.CurrentBook);
            _view.DisplayBooks(_model.Books);
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

    }

}
