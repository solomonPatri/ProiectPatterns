using ProiectPatterns.User.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPatterns.User.CommandService
{
    public interface IAnimalCommandService
    {

        Animal Add(Animal animal);

        Animal Delete(int id);   
      






    }
}
