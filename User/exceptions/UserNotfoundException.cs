using ProiectPatterns.system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPatterns.User.exceptions
{
    public class UserNotfoundException:Exception
    {

        public UserNotfoundException():base(ExceptionMessage.UserNotFounded)
        {





        }


    }
}
