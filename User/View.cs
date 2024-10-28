using ProiectPatterns.User.CommandService;
using ProiectPatterns.User.QueryService;
using ProiectPatterns.User.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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





        









    }
}
