using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    public class Login
    {
        public bool login(string user, string password)
        {
            if (user == "miguel" && password == "123456")
            {
                return true;
            }
            else return false;
            
        }
    }
}
