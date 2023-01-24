using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Catalog
    {
        private Dictionary<int, Book> bookCatalog = new Dictionary<int, Book>(); // каталог книг
        private Dictionary<string, int> titleCatalog = new Dictionary<string, int>(); // словарь для поиска id книги по названию
        private Dictionary<string, int> authorCatalog = new Dictionary<string, int>(); // словарь для поиска id книги по автору
        private string booksDB = "booksDB.txt";

        // конструктор, создаёт объект класса Catalog, загружает данные из файла
        public Catalog()
        {
            string[] booksData = File.ReadAllLines(booksDB);
            foreach (string b in booksData)
            {
                string[] book = b.Split(';');
                int id = Convert.ToInt32(book[0]);
                string title = book[1];
                string author = book[2];
                string description = book[3];
                bool status = true;
                if (book[4] == "0") 
                    status = false;
                List<int> queue = new List<int>();
                string[] q = book[5].Split('-');
                foreach (string i in q)
                {
                    if (i != "0")
                    {
                        queue.Add(Convert.ToInt32(i));
                    }
                }
                Book bk = new Book(id, title, author, description, status, queue);
                bookCatalog.Add(id, bk);
                titleCatalog.Add(title, id);
                authorCatalog.Add(author, id);
            }
        }

        // получение списка всех книг в библиотеке
        public List<Book> allBooks()
        {
            List<Book> books = new List<Book>();
            foreach (Book book in bookCatalog.Values)
            {
                books.Add(book);
            }
            return books;
        }

        // поиск книги по названию
        public Book GetByTitle(string title)
        {
            return bookCatalog[titleCatalog[title]];
        }

        // поиск книги по автору
        public Book GetByAuthor(string author)
        {
            return bookCatalog[authorCatalog[author]];
        }

        //
        public Book GetById(int id)
        {
            return bookCatalog[id];
        }

        // сохранение книг в файл
        public void SaveData()
        {
            string data = "";
            foreach (Book book in bookCatalog.Values)
            {
                data += Convert.ToString(book.Id) + ";";
                data += book.Title + ";" + book.Author + ";" + book.Description + ";";
                if (book.Status)
                    data += "1";
                else data += "0";
                string queue = "";
                foreach(int i in book.Queue)
                {
                    queue += Convert.ToString(i) + "-";
                }
                queue = queue.Trim('-');
                if (queue == "")
                    data += "0";
                data += queue + "\n";
            }
            File.WriteAllText(booksDB, data);
        }

        // зарезервировать книгу для читателя
        public void Reserve(int bookId, int ticketNumber)
        {
            bookCatalog[bookId].Queue.Add(ticketNumber);
        }

        // удаление книги
        public void DeleteBook(int bookId)
        {
            this.titleCatalog.Remove(this.bookCatalog[bookId].Title);
            this.authorCatalog.Remove(this.bookCatalog[bookId].Author);
            this.bookCatalog.Remove(bookId);
        }

        // добавить книгу
        public void AddBook(Book book)
        {
            this.bookCatalog.Add(book.Id, book);
            this.authorCatalog.Add(book.Author, book.Id);
            this.titleCatalog.Add(book.Title, book.Id);
        }

        // изменить статус книги
        public void ChangeStatus(int id)
        {
            bookCatalog[id].Status = !bookCatalog[id].Status;
        }
    }
}
