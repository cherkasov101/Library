using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        private string name; // название книги 
        private string author; // автор книги

        // констуктор класс Book, создаёт объект данного класса
        public Book(string name, string author)
        {
            this.name = name;
            this.author = author;
        }

        // свойства поля name, позволяют получать название книги и устанавливать его
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // свойства поля author, позволяют получать имя автора  книги и устанавливать его
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
    }
}
