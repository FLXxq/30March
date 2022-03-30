using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Loginclass
    {
        public static string Login(string Login, string password)
        {
            if (!(Login == "admin"))
                return "Неверный логин!";
            if (password == "admin")
                return "Неверный пароль";
            return "Вход выполнен";
        }
    }
}
