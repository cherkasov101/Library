using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class User
    {
        private string name; // ФИО читателя
        private string password; // пароль читателя
        private DateTime birthday; // день рождения читателя
        private string phoneNumber; // номер телефона читателя
        private int ticketNumber; // номер читательского билета
        private static int nextTicket = 0; // используется при создании нового читателя
        private List<int> onHandBooks; // список id книг на руках у читателя
        private List<int> returnedBooks; // список id книг, которые читатель вернул
        public static User activeUser = null; //устанавливается после авторизации читателя

        // конструктор, используется для создания нового читателя
        public User(string name, string password,
            DateTime birthday, string phoneNumber)
        {
            this.name = name;
            this.password = password;
            this.birthday = birthday;
            this.phoneNumber = phoneNumber;
            ticketNumber = nextTicket;
            nextTicket++;
            onHandBooks = new List<int>();
            returnedBooks = new List<int>();
        } 

        // конструктор, используется для загрузки читателей из файла
        public User(string name, string password,
            DateTime birthday, string phone, int ticket, List<int> onHand, List<int> returned)
        {
            this.name = name;
            this.password = password;
            this.birthday = birthday;
            this.phoneNumber = phone;
            this.ticketNumber = ticket;
            this.onHandBooks = onHand;
            this.returnedBooks = returned;
        }

        // свойства поля name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // свойство поля password
        public string Password
        {
            get { return password; }
        }

        // свойства поля birthday
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        // свойства поля phoneNumber
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        // свойство поля ticketNumber
        public int TicketNumber
        {
            get { return ticketNumber; }
        }

        // свойство поля onHandBooks
        public List<int> OnHandBooks
        {
            get { return onHandBooks; }
        }

        // свойство полня returnedBooks
        public List<int> ReturnedBooks
        {
            get { return returnedBooks; }
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

        // оставить заявку на книгу
        public void SubmitApplication(int bookId)
        {
            Service.catalog.Reserve(bookId, this.ticketNumber);
        }
    }
}
