using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Class
{
    //Клас ошибок
    class Error: ApplicationException
    {
        public Error() { }
        public Error(string message) { }

    }
    //Сообщения ошибок
    struct ErrorMessage
    {
        public static string TwoDispetcherNotFound = "Не найдуно двух диспетчеров";
        public static string AirplanCrash = "Самалет разбился";
        public static string PilotLuzer = "Тест не здан";

    }
}
