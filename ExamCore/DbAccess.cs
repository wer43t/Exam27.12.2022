using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCore
{
    public static class DbAccess
    {
        public static List<User> GetUsers()
        {
            return DBContext.context.User.ToList();
        }

        public static void AddUser(User user)
        {
            if(GetUsers().Where(x => x.id == user.id).Count() == 0)
            {
                if (CheckLogin(user.login))
                {
                    DBContext.context.User.Add(user);
                }
            }
            DBContext.context.SaveChanges();
        }

        private static bool CheckLogin(string login)
        {
            return GetUsers().Where(x => x.login == login).Count() == 0;
        }

        public static bool TryLogin(string login, string password)
        {
            return GetUsers().Where(x => x.login == login & x.password == password).Count() == 1;
        }

        public static User GetUser(string login, string password) 
        {
            return GetUsers().Where(x => x.login == login && x.password == password).FirstOrDefault();
        }

        public static List<Phone> GetPhones() 
        { 
            return DBContext.context.Phone.ToList();
        }

        public static void AddPhone(Phone phone) { }

        public static List<Client> GetClients()
        {
            return DBContext.context.Client.ToList(); 
        }

        public static void SaveClient(Client client)
        {
            if (GetUsers().Where(x => x.id == client.id).Count() == 0)
            {
                DBContext.context.Client.Add(client);
            }
            DBContext.context.SaveChanges();
        }
    }
}
