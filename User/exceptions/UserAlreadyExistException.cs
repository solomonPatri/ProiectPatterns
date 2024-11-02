using ProiectPatterns.system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPatterns.User.exceptions
{
    public class UserAlreadyExistException : Exception
    { 

        public UserAlreadyExistException() : base(ExceptionMessage.UserAlreadyExist)
        {




        }




    }
}
