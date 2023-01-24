using System;
using System.Collections.Generic;
using System.IO;

namespace Library
{
    public class Book
    {
        private static int nextId = 0; // id для следующей созданной книги
        private static string pathNextId = "nextIdBook.txt"; // путь к файлу с книгами
        private int id; // id книги
        private string title; // название книги 
        private string author; // автор книги
        private string description; // текстовое описание книги
        private bool status; // true если есть в наличие, false если на руках
        private List<int> queue; // очередь желающих получить данную книгу (номера читательских билетов)
       
        // констуктор класс Book, используется для создания новой книги
        public Book(string title, string author, string description)
        {
            if (nextId == 0) 
            {
                string idStr = File.ReadAllText(pathNextId);
                nextId = Convert.ToInt32(idStr);
            }
            id = nextId;
            nextId++;
            this.title = title;
            this.author = author;
            this.description = description;
            status = true;
            queue = new List<int>();
        }

        // конструктор, используется при загрузке книг из файла
        public Book(int id, string title, string author, string description, 
            bool status, List<int> queue)
        {
            this.id = id;
            this.title = title;
            this.author= author;
            this.description = description;
            this.status = status;
            this.queue = queue;
        }

        // свойство поля id, позволяет получать id книги
        public int Id { 
            get { return id; } 
        }

        // свойства поля name, позволяют получать название книги и устанавливать его
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        // свойства поля author, позволяют получать имя автора  книги и устанавливать его
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        // свойства поля description, позволяют олучить описание книги и добавить новое
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        // свойство поля status, позволяет получить текущий статус
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        // свойство поля queue для получения очереди желающих взять книгу
        public List<int> Queue
        {
            get { return queue; }
        }
    }
}
