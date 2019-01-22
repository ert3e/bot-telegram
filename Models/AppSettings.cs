using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramBotApp.Models
{
    public class AppSettings
    {
        public static string Url { get; set; } = "https://bpt-work.herokuapp.com:443{0}";

        public static string Name { get; set; } = "extremecode_bot";

        public static string Key { get; set; } = "650722338:AAGDMVx9cXMLmxqt63BWD6GZSiXmuNlBrbo";

    }
}