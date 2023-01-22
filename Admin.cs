using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Admin
    {
        private string name; //
        private int id; //
        private string password; //
        private static int nexId = 100; //

        //
        public Admin(string name, string password)
        {
            this.name = name;
            this.password = password;
            this.id = nexId;
            nexId++;
        }

        //
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        //
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        //
        public void AddBook()
        {
            
        }

        //
        public void RemoveBook()
        {

        }

        //
        public void EditBookTitle(Book book, string newTitle)
        {
            book.Title = newTitle;
        }

        //
        public void EditBookAuthor(Book book, string newAuthor)
        {
            book.Author = newAuthor;
        }

        //
        public void EditDescription(Book book, string newDescription)
        {
            book.Description = newDescription;
        }

        //
        public void GiveBook()
        {

        }

        //
        public void GetBook()
        {

        }
    }
}
