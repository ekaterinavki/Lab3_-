using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labr3
{
    // Класс, реализующий имитацию взаимодействия со сторонней зависимостью
    public class ThirdPartyInteractionClass : IThirdPartyInteraction
    {
        public void SendData(string data)
        {
            Console.WriteLine("Simulating sending data to a third-party dependency: " + data);
        }
    }

    public interface IThirdPartyInteraction
    {
        void SendData(string data);
    }
}
