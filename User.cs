using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class User
    {
        private string name; //
        private DateTime birthday; //
        private string phoneNumber; //
        private int ticketNumber; //
        private static int nextTicket = 1000000; //
        private List<Book> onHandBooks; //
        private List<Book> returnedBooks; //

        //
        public User(string name, string day, string month, string year, string phoneNumber)
        {
            this.name = name;
            birthday = new DateTime();
            this.phoneNumber = phoneNumber;
            ticketNumber = nextTicket;
            nextTicket++;
            onHandBooks = new List<Book>();
            returnedBooks = new List<Book>();
        } 

        //
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        //
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        //
        public int TicketNumber
        {
            get { return ticketNumber; }
        }

        //
        public List<Book> OnHandBooks
        {
            get { return onHandBooks; }
        }

        //
        public List<Book> ReturnedBooks
        {
            get { return returnedBooks; }
        }


        //
        public Catalog ViewAllBooks() 
        {
            return new Catalog();
        }

        //
        public Book SearchBookByAuthor()
        {
            return new Book("", "");
        }

        //
        public Book SearchBookByTitle()
        {
            return new Book("", "");
        }

        //
        public void SubmitApplication()
        {

        }
    }
}
