using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class User
    {
        private string name; //
        private DateTime birthday; //
        private string phoneNumber; //
        private int ticketNumber; //
        private static int nextTicket = 1000000; //
        private List<Book> onHandBooks; //
        private List<Book> returnedBooks; //
    }
}
