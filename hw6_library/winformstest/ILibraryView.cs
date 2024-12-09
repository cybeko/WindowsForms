using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface ILibraryView
    {
        public void GetBookInfo();
        public int GetSelectedBookId();
        public void DisplayBooks(List<Book> books);
        public Book CurrentBook { get; set; }
        event EventHandler<EventArgs> SaveToFileEvent;
        event EventHandler<EventArgs> DeleteFromFileEvent;
    }
}
