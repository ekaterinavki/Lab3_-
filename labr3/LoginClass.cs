using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data;

namespace labr3
{
    public class LoginClass
    {
        public static bool IsLoginValid(string login)
        {
            try
            {
                // Проверка формата логина
                Regex phoneRegex = new Regex(@"^\+\d{1}-\d{3}-\d{3}-\d{4}$");
                Regex emailRegex = new Regex(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$");

                if (phoneRegex.IsMatch(login) || emailRegex.IsMatch(login) || login.Length >= 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при проверке логина: " + ex.Message);
                return false;
            }
        }
    }
}
