using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int YearPublished { get; set; }
        public Book() 
        { 
            Title = string.Empty;
            Author = string.Empty;
            Genre = string.Empty;
        }
        public Book(string title, string author, string genre, int yearPublished, int id)
        {
            Title = title;
            Author = author;
            Genre = genre;
            YearPublished = yearPublished;
            Id = id;
        }
        public override string ToString()
        {
            return $"[ID: {Id}] {Title} by {Author}";
        }

    }
}
