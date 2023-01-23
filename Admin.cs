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
        public void AddBook()
        {
            
        }

        // удаление книги
        public void RemoveBook()
        {

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
        public void GiveBook()
        {

        }

        // прием книги от читателя
        public void GetBook()
        {

        }

        // регистрация нового сотрудника
        public void createNewAdmin(string name, string password)
        {
            Admin adm = new Admin(name, password);
            Service.addAdmin(nexId, adm);
            nexId++;
        }

        // получить список всех книг
        public Catalog ViewAllBooks()
        {
            return new Catalog();
        }

        // икать книгу по автору
        public Book SearchBookByAuthor()
        {
            return new Book("", "");
        }

        // искать книгу по названию
        public Book SearchBookByTitle()
        {
            return new Book("", "");
        }
    }
}
