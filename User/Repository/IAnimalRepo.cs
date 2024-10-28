using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectPatterns.User.Models;

namespace ProiectPatterns.User.Repository
{
    public interface IAnimalRepo
    {
        IEnumerable<Animal> GetAnimals();

        Animal FindAnimalByName(string name);

        Animal FindAnimalById(int id);

        Animal AddAnimal(Animal animal);

        Animal DeleteAnimal(int id);


        public int GeneratenextId();
        



        









    }
}
