using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labr3
{
    // Класс, реализующий бизнес-логику
    public class Controller
    {
        private DatabaseClass database;
        private IUserInteraction userInteraction;
        private IThirdPartyInteraction thirdPartyInteraction;

        public Controller(DatabaseClass database, IUserInteraction userInteraction, IThirdPartyInteraction thirdPartyInteraction)
        {
            this.database = database;
            this.userInteraction = userInteraction;
            this.thirdPartyInteraction = thirdPartyInteraction;
        }

        public bool ProcessUser()
        {
            // Получение входных данных от пользователя
            string login = userInteraction.GetInputFromUser();

            // Проверка наличия записи в БД
            UserData userData = database.GetData(login);

            if (userData == null)
            {
                // Запись не найдена в БД, вычисление результата
                bool authResult = LoginClass.IsLoginValid(login);
                string errorMessage = "";

                if (!authResult)
                {
                    errorMessage = "Invalid login format.";
                }

                // Добавление записи в БД
                database.AddData(login, authResult, errorMessage);

                // Отправка строки-результата сторонней зависимости
                thirdPartyInteraction.SendData(login + " - " + authResult);

                return authResult;
            }
            else
            {
                // Запись найдена в БД, возвращение результата
                return userData.AuthResult;
            }
        }
    }
}
