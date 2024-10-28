using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPatterns.User.Models
{
    public class Animal
    {

        private int _id;
        private string _type;
        private string _name;

        public Animal(string Propietati)
        {

            string[] text = Propietati.Split(',');
            _type = text[0];
            _id = int.Parse(text[1]);
            _name = text[2];



        }

        public Animal()
        {
            
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string ToString()
        {
            string t = " ";
            t += "Id: " + Id + "\n";
            t += "Name: " + Name + "\n";
            t += "Type:" + Type + "\n";
            return t;
        }

        public virtual bool Equals(object animal)
        {
            return animal is Animal other && Id.Equals(other.Id);
        }

        public int CompareTo(Animal other)
        {
            if (_id > other._id)
            {
                return 1;
            }

            if (_id < other._id)
            {
                return -1;

            }

            return 0;

        }

        public class AnimalBuilder
        {

            private readonly Animal _animal;

            private AnimalBuilder(Animal animal) {

                _animal = animal;

            
            }
            public static AnimalBuilder Create()
            {
                return new AnimalBuilder(new Animal());
            }

            public AnimalBuilder Id(int id)
            {
                _animal.Id = id;
                return this;


            }
            public AnimalBuilder Name(string name) {
                _animal.Name = name;
                return this;
             
             
            }
            public AnimalBuilder Type(string type)
            {
                _animal.Type= type;
                return this;

            }

            public Animal Build()
            {
                return _animal;
            }




        }


























    }
}
