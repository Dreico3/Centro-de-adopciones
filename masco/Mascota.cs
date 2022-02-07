using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masco
{
    [Serializable]
    public class Mascota : Animales
    {
        public string nombre { get; set; }
        public string raza { get; set; }
        public string Ci { get; set; }
        public int edad { get; set; }
        private string tratamiento;

        //private string nombre, raza, Ci;

        public Mascota(string nomb, string ra, int ed, string tra, string lu,string z):base(lu,z)
        {
            
            nombre = nomb;
            raza = ra;
            edad = ed;
            Ci = "sin adoptar";
            tratamiento=tra;
        }
        //public void mostrar()
        //{
        //    //Nota: mejora codigo

        //    Console.WriteLine("Nombre: {0}\t\tRaza: {1}\t\tCondigo Dueño: {2}", nombre, raza, Ci);
        //    if (Ci.Equals("sin adoptar"))
        //    {
        //        Console.WriteLine("{0}-> nesecito unhogar amoroso", nombre);
        //    }

        //}

        public string Codigo
        {
            get { return Ci; }
            set { Ci = value; }
        }
        public string Tratamiento
        {
            get { return tratamiento; }
            set { tratamiento = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }

    }
}