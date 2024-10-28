using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPatterns.User.Models
{
    internal class Anfibieni:Animal
    {

        private string _zona;
        private int _nrOua;
        private double _lungimea;


        public Anfibieni(string Propietati):base(Propietati) {
            string[] t = Propietati.Split(",");
           this._zona = t[3];
            this._nrOua = int.Parse(t[4]);
            this._lungimea = double.Parse(t[5]);

        }  

        public Anfibieni()
        {
            this._zona = null;
            this._nrOua = 0;
            this._lungimea = 0;
        }
        public string Zona
        {
            get { return _zona; }
            set { _zona = value; }
        }

        public int NrOua
        {
            get { return _nrOua; }
            set { _nrOua = value; }
        }
        public double Lungime
        {
            get { return _lungimea; }
            set { _lungimea = value; }
        }


        public class AnfibienBuilder
        {

            private readonly Anfibieni _animal;

            private AnfibienBuilder(Anfibieni animal)
            {

                _animal = animal;


            }
            public static AnfibienBuilder Create()
            {
                return new AnfibienBuilder(new Anfibieni());
            }

            public AnfibienBuilder Id(int id)
            {
                _animal.Id = id;
                return this;


            }
            public AnfibienBuilder Name(string name)
            {
                _animal.Name = name;
                return this;


            }
            public AnfibienBuilder Type(string type)
            {
                _animal.Type = type;
                return this;

            }
            public AnfibienBuilder Zona(string zona)
            {
                _animal.Zona = zona;
                return this;
            }
            public AnfibienBuilder NrOua(int nr)
            {
                _animal.NrOua = nr;
                return this;

            }
            public AnfibienBuilder Lungime(double lungime)
            {
                _animal.Lungime = lungime;
                return this;
            }

            public Anfibieni Build()
            {
                return _animal;
            }




        }


        public int CompareTo(Anfibieni other)
        {
            if (_nrOua < other._nrOua)
            {
                return -1;
            }
            if (_nrOua > other._nrOua)
            {
                return 1;

            }
            return 0;

        }    //Comapr dupa nr Oua

        public string ToString()
        {
            string t = "" + base.ToString();
            t += "Zona: " + Zona + "\n";
            t += "Nr Oua: " + NrOua + "\n";
            t += "Lungime: " + Lungime + "\n";
            return t;




        }

        public override bool Equals(object anfibien)
        {
            return anfibien is Anfibieni other && Zona.Equals(other.Zona);
        } //Compar dupa Zona 







    }
}
