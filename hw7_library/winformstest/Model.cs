using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Library
{
    public class Model : IModel
    {
        public List<Book> Books { get; set; } = new List<Book>();
        private readonly string filePath = "books.json";
        public int CurrentId { get; private set; } = 1;
        public void DeleteFromFile(int bookId)
        {
            var bookToRemove = Books.FirstOrDefault(b => b.Id == bookId);
            if (bookToRemove != null)
            {
                Books.Remove(bookToRemove);
                string json = JsonSerializer.Serialize(Books, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            else
            {
                MessageBox.Show($"Book with ID {bookId} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void AddBook(Book book)
        {
            var newBook = new Book
            {
                Id = CurrentId++,
                Title = book.Title,
                Author = book.Author,
                Genre = book.Genre,
                YearPublished = book.YearPublished
            };

            Books.Add(newBook);
        }
        public void SaveBookToFile(Book book)
        {
            AddBook(book);

            try
            {
                string json = JsonSerializer.Serialize(Books, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving the book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteAllBooks()
        {
            Books.Clear();
            SaveBooksToFile();
            CurrentId = 1;
        }
        private void SaveBooksToFile()
        {
            try
            {
                string json = JsonSerializer.Serialize(Books);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadFromFile()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    Books = JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>();

                    if (Books.Any())
                    {
                        CurrentId = Books.Max(b => b.Id) + 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading books: {ex.Message}", "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Books = new List<Book>();
                }
            }
            else
            {
                Books = new List<Book>();
            }
        }

    }
}
