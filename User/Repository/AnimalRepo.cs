﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using ProiectPatterns.User.Models;

namespace ProiectPatterns.User.Repository
{
    public class AnimalRepo:IAnimalRepo
    {
        List<Animal> _animals;
        string _filepath;

        public AnimalRepo()
        {
            _animals = new List<Animal>();
            _filepath = GetDirectory();
            this.load();

        }
        public void load()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_filepath))
                {
                    string line = " ";
                    while ((line = sr.ReadLine()) != null)
                    {

                        switch (line.Split(",")[0])
                        {

                            case "Mamifer":
                                Mamiferi mf = new Mamiferi(line);
                                _animals.Add(mf);
                                break;
                            case "Anfibieni":
                                Anfibieni anf = new Anfibieni(line);
                                _animals.Add(anf); 

                                break;
                            case "Pesti":
                                Pesti ps = new Pesti(line);
                                _animals.Add(ps);
                                break;
                            case "Reptile":
                                Reptile reptile = new Reptile(line);
                                _animals.Add(reptile);
                                break;
                            default:

                                break;



                        }




                    }


                }




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private string GetDirectory()
      {
            string currentDirectory = Directory.GetCurrentDirectory();
            string dataFolder = Path.Combine(currentDirectory,"data");
            string filepath = Path.Combine(dataFolder, "Animale");

            return filepath;

      }


        public IEnumerable<Animal> GetAnimals()
        {

            return _animals;

        }



        public Animal FindAnimalByName(string name)
        {
            foreach(var animal in _animals)
            {
                if (animal.Name.Equals(name))
                {
                    return animal;

                }

            }
            return null;
        }
        public Animal FindAnimalById(int id)
        {
            foreach(var animal in _animals)
            {
                if (animal.Id.Equals(id)){
                    return animal;

                }
              
            }
            return null;


        }
        public int GeneratenextId()
        {
            Random random = new Random();
            int nrradnom = random.Next(100, 1000);

            return nrradnom;





        }
        public Animal AddAnimal(Animal animal)
        {
            animal.Id = GeneratenextId();
            this._animals.Add(animal);
            return animal;
        }

        public Animal DeleteAnimal(int id)
        {
            Animal animal = this.FindAnimalById(id);

            this._animals.Remove(animal);
            return animal;


        }
        public Animal UpdateAnimal(Animal animal)
        {
            Animal editableAnimal = this.FindAnimalById(animal.Id);

            if(animal.Name != null)
            {

                editableAnimal.Name = animal.Name;

            }
            if(animal is Mamiferi)
            {
                Mamiferi anm = ((Mamiferi)animal);
                Mamiferi editableanimal = (Mamiferi)editableAnimal;
                if (anm.Age != 0)
                {

                    editableanimal.Age = anm.Age;

                }


            }
            if(animal is Reptile)
            {
                Reptile rept = ((Reptile)animal);
                Reptile editanimal = (Reptile)editableAnimal;

                if (rept.traiViata!=null)
                {
                    editanimal.traiViata = rept.traiViata;



                }

            }

            if(animal is Anfibieni)
            {

                Anfibieni anf = ((Anfibieni)animal);
                Anfibieni editanf = (Anfibieni)editableAnimal;

                if (anf.Lungime != 0)
                {

                    editanf.Lungime = anf.Lungime;

                }

            }
            if(animal is Pesti)
            {

                Pesti ps = ((Pesti)animal);
                Pesti editps = (Pesti)editableAnimal;
                if(ps.Kilograme!=0)
                {

                    editps.Kilograme = ps.Kilograme;


                }

            }

            return editableAnimal;













        }
      






    }
}
