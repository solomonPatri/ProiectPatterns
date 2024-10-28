using ProiectPatterns.User.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPatterns.User.Singleton
{
    public class RepoSingleton
    {
        private static IAnimalRepo instance = null;

        private RepoSingleton() { 
        
        
        
        }

        public static IAnimalRepo Instance
        {
            get {
       
            if  (instance == null)
                {

                    instance = new AnimalRepo();

                }
                return instance;
            
            
            
            }


        }








    }
}
