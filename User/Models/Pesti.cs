using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ProiectPatterns.User.Models
{
    public class Pesti:Animal
    {
        private double _kg;
        private string _zonaApa;
        public Pesti (string Propietati) : base(Propietati)
        {
            string[] t= Propietati.Split(',');
            this._zonaApa = t[3];
            this._kg = double.Parse(t[4]);
        }

        public Pesti()
        {
            this._zonaApa = null;
            this._kg = 0;
        }


        public string ZonaApa
        {
            get { return _zonaApa; }
            set { _zonaApa = value; }
        }
        public double Kilograme
        {
            get { return _kg; }
            set { _kg = value; }
        }

        public virtual bool Equals(object animal)
        {
            return animal is Pesti other && Kilograme.Equals(other.Kilograme);
        }

        public int CompareTo(Pesti other)
        {
            if (_kg > other._kg )
            {
                return 1;
            }

            if (_kg < other._kg)
            {
                return -1;

            }

            return 0;

        }

        public string ToString()
        {
            string t = " " + base.ToString();
            t += "Zona capturare: " + ZonaApa + "\n";
            t += "Kilograme: " + Kilograme + "\n";
            return t;

        }

        public class PestiBuilder
        {

            private readonly Pesti _animal;

            private PestiBuilder(Pesti animal)
            {

                _animal = animal;


            }
            public static PestiBuilder Create()
            {
                return new PestiBuilder(new Pesti());
            }

            public PestiBuilder Id(int id)
            {
                _animal.Id = id;
                return this;


            }
            public PestiBuilder Name(string name)
            {
                _animal.Name = name;
                return this;


            }
            public PestiBuilder Type(string type)
            {
                _animal.Type = type;
                return this;

            }

            public Pesti Build()
            {
                return _animal;
            }




        }




    }
}
