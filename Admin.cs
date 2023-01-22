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
        public static Admin activeAdmin = null; //
        private string name; //
        private int id; //
        private string password; //
        private static int nexId = 0; //
        private static string fileNameNextId = "nextId.txt"; //

        //
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

        //
        public Admin(int id, string name, string password)
        {
            this.name = name;
            this.password = password;
            this.id = id;
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

        //
        public void createNewAdmin()
        {

        }
    }
}
