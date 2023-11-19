using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML1
{
    public class Pizza
    {

        // Pizza Klasse
        // Instans Fields

        private int _nummer;
        private string _navn;
        private double _pris;
        private string _beskrivelse;


        
         // Properties
         
        public int Nummer
        {
            get { return _nummer; }
            set { _nummer = value; }
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public double Pris
        {
            get { return _pris; }
            set
            {
                if (!(value >= 0))
                {
                    throw new ArgumentException("Pris skal være nul eller positiv men var " + value);
                }

                _pris = value;
            }
        }
        public string Beskrivelse
        {
            get { return _beskrivelse;  }
            set { _beskrivelse = value;}
        }



         // Constructors


        public Pizza() 
        {
            _nummer = 0;
            _navn = "";
            _pris = 0;
            _beskrivelse = "";

        }

        public Pizza(int nummer, string navn, double pris, string beskrivelse)
        {
            _nummer = nummer;
            _navn = navn;
            _pris = pris;
            _beskrivelse = beskrivelse;
        }

        public override string ToString()
        {
            return $"{{{nameof(Nummer)}={Nummer.ToString()}, {nameof(Navn)}={Navn}, {nameof(Pris)}={Pris.ToString()}, {nameof(Beskrivelse)}={Beskrivelse}}}";
        }
    }
}
