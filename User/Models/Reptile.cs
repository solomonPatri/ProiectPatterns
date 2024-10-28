using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPatterns.User.Models
{
    public class Reptile:Animal
    {
        public string _continent;
        public string _culori;
        public string _traiViata;
        public int _age;

        public Reptile(string Propietati) : base(Propietati) {
            string[] t = Propietati.Split(',');
            this._continent = t[3];
            this._culori = t[4];
            this._traiViata = t[5];
            this._age = int.Parse(t[6]);
        
        
        }

        public Reptile() {
            _continent = null;
            _culori = null;
            _traiViata = null;
            _age = 0;

        
        
        
        
        
        
        }
        public string Continent
        {
            get { return _continent;}
            set { _continent = value; }
        }

        public string Culori
        {
            get { return _culori; }
            set { _culori = value; }
        }
        public string traiViata
        {
            get { return _traiViata; }
            set { _traiViata = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


        public int CompareTo(Reptile other)
        {
            if (_age < other._age)
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
            t += "Continent: " + Continent + "\n";
            t += "Culori: " + Culori + "\n";
            t += "Trai de viata:" + traiViata + "\n";
            t += "Age: " + Age + "\n";
            return t;


        }

        public override bool Equals(object animal)
        {
            return animal is Reptile other && Name.Equals(other.Name);
        }


        public class ReptileBuilder
        {

            private readonly Reptile _animal;

            private ReptileBuilder(Reptile animal)
            {

                _animal = animal;


            }
            public static ReptileBuilder Create()
            {
                return new ReptileBuilder(new Reptile());
            }

            public ReptileBuilder Id(int id)
            {
                _animal.Id = id;
                return this;


            }
            public ReptileBuilder Name(string name)
            {
                _animal.Name = name;
                return this;


            }
            public ReptileBuilder Type(string type)
            {
                _animal.Type = type;
                return this;

            }

            public ReptileBuilder Continent(string continent)
            {
                _animal._continent = continent;
                return this;

            }
            public ReptileBuilder Culori(string culori)
            {
                _animal._culori = culori;
                return this;
            }
            public ReptileBuilder TraiViata(string viata)
            {
                _animal._traiViata = viata;
                return this;
            }

            public ReptileBuilder Age(int age)
            {
                _animal._age = age;
                return this;
            }


            public Reptile Build()
            {
                return _animal;
            }




        }

















    }
}
