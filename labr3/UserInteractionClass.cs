using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labr3
{
    // Класс, реализующий взаимодействие с пользователем через консоль
    public class UserInteractionClass : IUserInteraction
    {
        public string GetInputFromUser()
        {
            Console.Write("Enter login: ");
            string login = Console.ReadLine();
            return login;
        }
    }

    // Интерфейс для класса, реализующего взаимодействие с пользователем
    public interface IUserInteraction
    {
        string GetInputFromUser();
    }
}
