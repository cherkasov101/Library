using System;
using System.Collections.Generic;
using System.IO;

namespace Library
{
    public class Service
    {
        private static Dictionary<int, User> users = new Dictionary<int, User>(); // хранит всех зарегистрированных читателей
        private static Dictionary<int, Admin> admins = new Dictionary<int, Admin>(); // хранит сотрудников
        private static string userDB = "UserDB.txt"; // путь к файлу со спискем читателей
        private static string adminDB = "AdminDB.txt"; // путь к файлу со списком сотрудников
        public static Catalog catalog = new Catalog(); // каталог книг

        // конструктор класса Login, используется для загрузки данных о пользователях из файлов
        public Service()
        {
            string[] usersData = File.ReadAllLines(userDB);
            foreach (string line in usersData)
            {
                string[] u = line.Split(';');
                int ticket = int.Parse(u[0]);
                string[] bday = u[2].Split('-');
                DateTime birthday = new DateTime(int.Parse(bday[0]), 
                    int.Parse(bday[1]), int.Parse(bday[2]));

                List<int> booksOnHand = new List<int>();
                string[] bon = u[4].Split('-');
                foreach (string b in bon)
                {
                    int book = int.Parse(b);
                    if (book == 0) continue;
                    booksOnHand.Add(book);
                }

                List<int> returnedBooks = new List<int>();
                string[] rb = u[5].Split('-');
                foreach (string b in rb)
                {
                    int book = int.Parse(b);
                    if (book == 0) continue;
                    booksOnHand.Add(book);
                }

                User user = new User(u[1], u[6], birthday, u[3], ticket, booksOnHand, returnedBooks);
                users.Add(ticket, user);
            }

            string[] adminsData = File.ReadAllLines(adminDB);
            foreach (string line in adminsData)
            {
                string[] a = line.Split(';');
                int id;
                try
                {
                    id = int.Parse(a[0]);
                }
                catch (Exception)
                {
                    id = -1;
                }
                Admin adm = new Admin(id, a[1], a[2]);
                admins.Add(id, adm);
            }
        }

        // авторизация читателя
        public bool UserLogin(int ticket, string password)
        {
            User user;
            if (users.TryGetValue(ticket, out user))
            {
                user = users[ticket];
                if(user.Password == password)
                {
                    User.activeUser = user;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;

            }
        }

        // авторизация сотрудника библиотеки
        public bool AdminLogin(int id, string password)
        {
            Admin admin;
            if (admins.TryGetValue(id, out admin))
            {
                admin = admins[id];
                if(admin.Password == password)
                {
                    Admin.activeAdmin = admin;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;

            }
        }

        // регистрация читателя
        public void Registration(string name, string password,
            DateTime birthday, string phoneNumber)
        {
            User usr = new User(name, password, birthday, phoneNumber);
            users.Add(usr.TicketNumber, usr);
        }

        // добавить сотрудника
        public static void addAdmin(int id, Admin adm)
        {
            admins.Add(id, adm);
        }

        // сохранение всех данных перед выходом из программы
        public void Logout()
        {
            catalog.SaveData();

            string usersData = "";
            foreach (User user in users.Values)
            {
                usersData += Convert.ToString(user.TicketNumber) + ";";
                usersData += user.Name + ";";
                string year = user.Birthday.Year.ToString();
                string month = user.Birthday.Month.ToString();
                string day = user.Birthday.Day.ToString();
                usersData += year + "-" + month + "-" + day + ";";
                usersData += user.PhoneNumber + ";";
                string onHands = "";
                foreach (int id in user.OnHandBooks)
                {
                    onHands += Convert.ToString(id) + "-";
                }
                usersData += onHands + ";";
                string returned = "";
                foreach (int id in user.ReturnedBooks)
                {
                    returned += Convert.ToString(id) + "-";
                }
                usersData += returned + ";" + user.Password + "\n";
            }
            File.WriteAllText(userDB, usersData);

            string adminData = "";
            foreach(Admin admin in admins.Values)
            {
                adminData += Convert.ToString(admin.Id) + ";";
                adminData += admin.Name + ";" + admin.Password + "\n";
            }
        }
        
        // передаёт пользователя из списка
        public static User GetUser(int id)
        {
            return users[id];
        }
    }
}
