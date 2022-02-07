using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masco
{
    [Serializable]
    class Adoptador
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string ci { get; set; }
        public string phone { get; set; }
        public Adoptador()
        {
            nombre = "";
            apellido = "";
            direccion = "";
            ci = " ";
        }
        public Adoptador(string nom, string ap, string dir, string c,string p)
        {
            nombre = nom;
            apellido = ap;
            direccion = dir;
            ci = c;
            phone = p;
        }
       
        //public void Actualizar()
        //{
        //    Console.WriteLine("introdusca el nombre");
        //    nombre = Console.ReadLine();
        //    Console.WriteLine("introdusca los aplleido");
        //    apellido = Console.ReadLine();
        //    Console.WriteLine("introdusca la direccion de {0}", nombre);
        //    direccion = Console.ReadLine();
        //    Console.WriteLine("introdusca la celula de identidad");
        //    ci = Console.ReadLine();
        //}

        //public void Mostrar()
        //{
        //    Console.WriteLine("Nombre completo: {0} {1}\t\t CI: {2} \t\t Direccion: {3}", nombre, apellido, ci, direccion);
        //}
    }
}
