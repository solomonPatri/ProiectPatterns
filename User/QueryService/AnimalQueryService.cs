using ProiectPatterns.User.Repository;
using ProiectPatterns.User.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectPatterns.User.Models;

namespace ProiectPatterns.User.QueryService
{
    public class AnimalQueryService:IAnimalQueryService
    {
        private IAnimalRepo _repo;

        public AnimalQueryService()
        {

            this._repo = AnimalFactory.CreateUserService<IAnimalRepo>();
        }

        public IEnumerable<Animal> GetAll()
        {
            return this._repo.GetAnimals();

        }


        public Animal ReturnById(int id)
        {

            return this._repo.FindAnimalById(id);


        }

        public Animal ReturnByName(string name)
        {

            return this._repo.FindAnimalByName(name);
        }

      









    }
}
