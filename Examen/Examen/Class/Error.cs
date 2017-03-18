using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Class
{
    //Клас ошибок
    [Serializable]
    class Error: ApplicationException
    {
        public Error():base() { }
        public Error(string messages) : base (messages) { }
        public Error(string messages,System.Exception ex): base(messages,ex) { }
        public Error(System.Runtime.Serialization.SerializationInfo info,System.Runtime.Serialization.StreamingContext context) : base(info,context) { }

    }
    //Сообщения ошибок
    struct ErrorMessage
    {
        public static string TwoDispetcherNotFound = "Не найдуно двух диспетчеров";
        public static string AirplanCrash = "Самалет разбился";
        public static string PilotLuzer = "Тест не здан";

    }
}
