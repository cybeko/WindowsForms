using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface IModel
    {
        public List<Book> Books { get; set; } 
        void SaveToFile(Book book);
        void DeleteFromFile(int bookId);
        void LoadFromFile();

    }
}
