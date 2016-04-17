using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_21_Радош
{
    class Controller
    {
        public User CurrentUser { get; private set; }
        public Controller()
        {
            
        }

        public void LogIn(string login, string password)
        {
            // implementation
        }

        public void LogOut()
        {
            this.CurrentUser = null;
        }

        public void Register()
        {
            // implementation
        }
        public void GetUserInfo()
        {
            
        }
    }
}
