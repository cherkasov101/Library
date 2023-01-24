using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Admin
    {
        public static Admin activeAdmin = null; // устанавливается после авторизации сотрудника
        private string name; // ФИО сотрудника
        private int id; // id сотрудника
        private string password; // пароль сотрудника
        private static int nexId = 0; // поля используется при регистрации нового сотрудника
        private static string fileNameNextId = "nextId.txt"; // путь к файлу, содержащему значение для поля nextId

        // конструктор для регистрации нового сотрудника
        public Admin(string name, string password)
        {
            this.name = name;
            this.password = password;
            if (nexId <= 0)
            {
                string dataNextId = File.ReadAllText(fileNameNextId);
                try
                {
                    nexId = Convert.ToInt32(dataNextId);
                }
                catch (Exception) 
                { 
                    nexId = -1;
                }
            }  
            this.id = nexId;
            nexId++;
        }

        // конструктор, используется при загрузке сотрудников из файла
        public Admin(int id, string name, string password)
        {
            this.name = name;
            this.password = password;
            this.id = id;
        }

        // свойство поля name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // свойство поля password
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        // свойство поля id
        public int Id
        {
            get { return id; }
        }

        // добавление новой книги
        public void AddBook(string title, string author, string description)
        {
            Book book = new Book(title, author, description);
            Service.catalog.AddBook(book);
        }

        // удаление книги
        public void RemoveBook(int id)
        {
            Service.catalog.DeleteBook(id);
        }

        // редактирование названия книги
        public void EditBookTitle(Book book, string newTitle)
        {
            book.Title = newTitle;
        }

        // редактирование автора книги
        public void EditBookAuthor(Book book, string newAuthor)
        {
            book.Author = newAuthor;
        }

        // редактирование описания книги
        public void EditDescription(Book book, string newDescription)
        {
            book.Description = newDescription;
        }

        // выдача книги читателю
        public void GiveBook(int bookId, int userTicket)
        {
            Service.catalog.ChangeStatus(bookId);
        }

        // прием книги от читателя
        public string GetBook(int id)
        {
            Book book = Service.catalog.GetById(id);
            if (book.Queue.Count != 0)
            {
                User user = Service.GetUser(book.Queue[0]);
                Service.catalog.ChangeStatus(book.Id);
                return "книгу ждёт читатель: " + user.Name + " " + user.PhoneNumber;
            }
            else
            {
                Service.catalog.ChangeStatus(book.Id);
                return "книга в библиотеке";
            }
        }

        // регистрация нового сотрудника
        public void createNewAdmin(string name, string password)
        {
            Admin adm = new Admin(name, password);
            Service.addAdmin(adm.id, adm);
        }

        // получить список всех книг
        public List<Book> ViewAllBooks()
        {
            return Service.catalog.allBooks();
        }

        // икать книгу по автору
        public Book SearchBookByAuthor(string author)
        {
            return Service.catalog.GetByAuthor(author);
        }

        // искать книгу по названию
        public Book SearchBookByTitle(string title)
        {
            return Service.catalog.GetByTitle(title);
        }
    }
}
