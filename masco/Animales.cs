using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masco
{
    [Serializable]
    public class Animales
    {
        protected string lugar;   //Si es perro (Pastor Ingles, Daltamata, Chiguagua,etc.)
        protected string sexo;
        public Animales(string l,string x)
        {
            lugar = l;
            sexo = x;

        }
        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

    }
}
