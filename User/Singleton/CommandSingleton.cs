using ProiectPatterns.User.CommandService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPatterns.User.Singleton
{
    public class CommandSingleton
    {

        public static IAnimalCommandService instance = null;

        private CommandSingleton()
        {

        }


        public static IAnimalCommandService Instance
        {
            get
            {
                   if (instance == null)
                {
                    instance = new AnimalCommandService();
                }
                   return instance;

            }
        }








    }
}
