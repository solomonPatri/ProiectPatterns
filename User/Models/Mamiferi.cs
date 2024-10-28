using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPatterns.User.Models
{
    public class Mamiferi:Animal
    {

        private string _country;
        private int _age;
        private string _stapani;
        private string _medieVarsta;


        public Mamiferi(string Propietati) : base(Propietati)
        {
            string[] t = Propietati.Split(',');
            _country = t[3];
            _age = int.Parse(t[4]);
            _stapani = t[5];
            _medieVarsta = t[6];

        }

        public Mamiferi()
        {
            this._country = null;
            this._age = 0;
            this._stapani = null;
            this._medieVarsta = null;
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Stapani
        {
            get { return _stapani; }
            set { _stapani = value; }
        }
        public string MedieVarsta
        {
            get { return _medieVarsta; }
            set { _medieVarsta = value;}
        }

        public class MamiferBuilder
        {

            private readonly Mamiferi _animal;

            private MamiferBuilder(Mamiferi animal)
            {

                _animal = animal;


            }
            public static MamiferBuilder Create()
            {
                return new MamiferBuilder(new Mamiferi());
            }

            public MamiferBuilder Id(int id)
            {
                _animal.Id = id;
                return this;


            }
            public MamiferBuilder Name(string name)
            {
                _animal.Name = name;
                return this;


            }
            public MamiferBuilder Type(string type)
            {
                _animal.Type = type;
                return this;

            }

            public MamiferBuilder Country(string tara)
            {
                _animal.Country = tara;
                return this;

            }
            public MamiferBuilder Age(int age)
            {
                _animal.Age = age;
                return this;
            }

            public MamiferBuilder Stapani(string stapani)
            {
                _animal.Stapani = stapani;
                return this;

            }
            public MamiferBuilder MedieVarsta(string mdvarsta)
            {
                _animal.MedieVarsta = mdvarsta;
                return this;
            }

            public Mamiferi Build()
            {
                return _animal;
            }




        }

        public int CompareTo(Mamiferi other)
        {
            if(_age < other._age)
            {
                return -1;
            }
            if (_age > other._age)
            {
                return 1;

            }
            return 0;

        }

        public string ToString()
        {
            string t = " " + base.ToString();
            t += "Tara origine:" + Country + "\n";
            t += "Varsta: " + Age + "\n";
            t += "Stapani: " + Stapani + "\n";
            t += "Medie Varsta: " + MedieVarsta + "\n";
            return t;


        }

        public override bool Equals(object animal)
        {
            return animal is Mamiferi other && Name.Equals(other.Name);
        }








    }
}
