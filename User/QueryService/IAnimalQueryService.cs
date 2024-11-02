using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectPatterns.User.Models;

namespace ProiectPatterns.User.QueryService
{
    public interface IAnimalQueryService
    {
        IEnumerable<Animal> GetAll();

        Animal ReturnById(int id);

        Animal ReturnByName(string name);

    }
}
