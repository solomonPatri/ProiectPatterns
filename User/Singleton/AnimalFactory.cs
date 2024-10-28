using ProiectPatterns.User.CommandService;
using ProiectPatterns.User.QueryService;
using ProiectPatterns.User.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPatterns.User.Singleton
{
    public class AnimalFactory
    {

        public static T CreateUserService<T>()
        {
            if (typeof(T) == typeof(IAnimalCommandService))
            {

                return (T)(object)CommandSingleton.Instance;

            }
            else if (typeof(T) == typeof(IAnimalQueryService))
            {
                return (T)(object)QuerySingleton.Instance;
            }


            else if (typeof(T) == typeof(IAnimalRepo))
            {
                return (T)(object)RepoSingleton.Instance;
            }
            else
            {
                throw new ArgumentException("No service found for the given type");
            }

        }

    }








}

