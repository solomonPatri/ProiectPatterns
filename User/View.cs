using ProiectPatterns.User.CommandService;
using ProiectPatterns.User.QueryService;
using ProiectPatterns.User.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectPatterns.User.Models;
using ProiectPatterns.User.exceptions;

namespace ProiectPatterns.User
{
    public class View
    {
        private IAnimalCommandService _servicecommand;
        private IAnimalQueryService _queryservice;

        public View()
        {
            this._servicecommand = AnimalFactory.CreateUserService<IAnimalCommandService>();
            this._queryservice = AnimalFactory.CreateUserService<IAnimalQueryService>();
            this.play();


        }

        public void Meniu()
        {
            Console.WriteLine("1-> Afisare Animale" + "\n");
            Console.WriteLine("2->Adaugare unui Animal" + "\n");
            Console.WriteLine("3-> Stergerea unui animal:" + "\n");
            Console.WriteLine("4->Modificarea unui Animal:" + "\n");



        }

        public void play()
        {
            bool run = true;

            while (run)
            {
                Meniu();
                int nrales = int.Parse(Console.ReadLine());
                switch (nrales)
                {
                    case 1:
                        Afisare();
                        break;


                }




            }







        }

        public void Afisare()
        {
            foreach(var animal in _queryservice.GetAll())
            {

                Console.WriteLine(animal.ToString());

            }


        }

        public void AdaugareAnimal()
        {
            Console.WriteLine("Ce type de animal doriti sa adaugati: Mamiferi/Reptile/Anfibieni/Pesti" + "\n");

            string type = Console.ReadLine();

            Console.WriteLine("Numele animalului" + "\n");
            string name = Console.ReadLine();
            Animal anim = _queryservice.ReturnByName(name);

            try
            {


                _servicecommand.Add(anim);

            }catch(UserAlreadyExistException a)
            {
                Console.WriteLine(a.Message);
            }


        }


        public void DeleteAnimal()
        {
            Console.WriteLine("Introduceti numele animalului care doriti sa eliminati:" + "\n");
            string name = Console.ReadLine();

            Animal delete = _queryservice.ReturnByName(name);

            try
            {
                _servicecommand.Delete(delete.Id);

            }catch(UserNotfoundException d)
            {
                Console.WriteLine(d.Message);
            }
            


        }

        public void Udpate()
        {
            Console.WriteLine("Introduceiti numele animalului care doriti sa modificati" + "\n");
            string name = Console.ReadLine();

            Animal update = _queryservice.ReturnByName(name);

            try
            {
                



            }








        }
        









    }
}
