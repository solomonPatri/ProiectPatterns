using ProiectPatterns.User.QueryService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPatterns.User.Singleton
{
    public class QuerySingleton
    {
        private static IAnimalQueryService instance = null;

        private QuerySingleton() { }

        public static IAnimalQueryService Instance
        {

            get
            {
                if(instance == null)
                {
                
                    instance = new AnimalQueryService();

                }return instance;


            }
        }








    }
}
