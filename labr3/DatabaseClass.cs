using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labr3
{
    public class DatabaseClass
    {
        private List<UserData> users = new List<UserData>();

        // Метод добавления данных
        public void AddData(string login, bool authResult, string errorMessage)
        {
            UserData newUser = new UserData(login, authResult, errorMessage);
            users.Add(newUser);
        }

        // Метод получения данных
        public UserData GetData(string login)
        {
            return users.Find(u => u.Login == login);
        }

        // Метод удаления данных
        public void RemoveData(string login)
        {
            UserData userToRemove = users.Find(u => u.Login == login);
            if (userToRemove != null)
            {
                users.Remove(userToRemove);
            }
        }
    }
}
