using System;
using System.Collections;
using System.Globalization;
using System.Runtime.Serialization;

namespace CatShopWebApi.Exceptions
{
    public class CatBoughtedException : Exception
    {

        private CultureInfo _culture;
        public CatBoughtedException(CultureInfo culture)
        {
            _culture = culture;
        }
        public override string Message => GetTextMessageByCultureInfo();
        public override IDictionary Data => base.Data;
        public override string HelpLink { get => base.HelpLink; set => base.HelpLink = value; }
        public override string Source { get => base.Source; set => base.Source = value; }
        public override string StackTrace => base.StackTrace;
        public override Exception GetBaseException()
        {
            return base.GetBaseException();
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }

        private string GetTextMessageByCultureInfo()
        {
            if (_culture.Name == "ru-RU")
                return "Кот уже куплен";

            return "Cat already bought";
        }
    }
}
