using ProiectPatterns.User.Models;
using ProiectPatterns.User.Repository;
using ProiectPatterns.User.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectPatterns.system;
using ProiectPatterns.User.exceptions;

namespace ProiectPatterns.User.CommandService
{
    public class AnimalCommandService:IAnimalCommandService
    {

        IAnimalRepo _repo;

        public AnimalCommandService()
        {

            this._repo = AnimalFactory.CreateUserService<IAnimalRepo>();
        }

        public Animal Add(Animal animal)
        {
            Animal an = this._repo.FindAnimalByName(animal.Name);
            if(an == null)
            {
                return this._repo.AddAnimal(animal);

            }
            throw new UserAlreadyExistException();

        }

        public Animal Delete(int id)
        {
            Animal animal = this._repo.FindAnimalById(id);

            if(animal != null) { 

                this._repo.DeleteAnimal(id);
                return animal;

            }
            throw new UserNotfoundException();


        }

        public Animal Update(Animal animal)
        {

            Animal update = _repo.FindAnimalById(animal.Id);

            if (update!=null)
            {
                this._repo.UpdateAnimal(animal);
                return update;
            }
          
           throw new UserNotUpdateException();









        }







    }
}
