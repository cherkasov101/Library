using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Login
    {
        private Dictionary<int, User> users; //
        private Dictionary<int, Admin> admins; //
        private string userDB = "UserDB.txt"; //
        private string adminDB = "AdminDB.txt"; //


        //
        public Login()
        {
            string[] usersData = File.ReadAllLines(userDB);
            users = new Dictionary<int, User>();
            foreach (string line in usersData)
            {
                string[] u = line.Split(';');

            }

            string[] adminsData = File.ReadAllLines(adminDB);
            admins = new Dictionary<int, Admin>();
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

        //
        public void UserLogin()
        {

        }

        //
        public bool AdminLogin(int id, string password)
        {
            Admin admin;
            if (admins.TryGetValue(id, out admin))
            {
                admin = admins[id];
            }
            else
            {
                return false;
            }
            Admin.activeAdmin = admin;
            return true;
        }

        //
        public void Registration()
        {

        }
    }
}
