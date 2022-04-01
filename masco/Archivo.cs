using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace masco
{
    class Archivo
    {
        private FileStream mArchivo;
        private BinaryFormatter convertidor;

        //NOTA: ESTE ARCHIVO ES MODIFICABLE PARA CUALQUIER USO TENERMOS Q SUBIR A LA FUNETE DE DATOS JEEJEJEE

        public bool Guardar(Mascota mMascota)
        {
            try
            {
                mArchivo = new FileStream("Mascotas.dat", FileMode.OpenOrCreate, FileAccess.Write);
                convertidor = new BinaryFormatter();
                convertidor.Serialize(mArchivo, mMascota);
                mArchivo.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "999999999999999999");
                return false;
            }
        }

        //Guarda la lista de mascotas en un archivo
        public bool Guardar(List<Mascota> lMascota)
        {
            try
            {
                mArchivo = new FileStream("Mascotas.dat", FileMode.OpenOrCreate, FileAccess.Write);
                convertidor = new BinaryFormatter();
                convertidor.Serialize(mArchivo, lMascota);
                mArchivo.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "999999999999999999");
                return false;
            }
        }
        public Mascota Mostrar()
        {
            Mascota mMascota = null;
            try
            {
                mArchivo = new FileStream("Mascotas.dat", FileMode.Open, FileAccess.Read);
                convertidor = new BinaryFormatter();
                mMascota = (Mascota)convertidor.Deserialize(mArchivo);
                mArchivo.Close();
                return mMascota;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "999999999999999999");
                return null;
            }
        }
        //desemcripta y regresa la lista guardada
        public List<Mascota> MostrarL()
        {
            List<Mascota> lMascota = null;
            try
            {
                mArchivo = new FileStream("Mascotas.dat", FileMode.Open, FileAccess.Read);
                convertidor = new BinaryFormatter();
                lMascota = (List<Mascota>)convertidor.Deserialize(mArchivo);
                mArchivo.Close();
                return lMascota;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "999999999999999999");
                return null;
            }
        }

        //Guarda la lista de adoptadores en un archivo
        public bool GuardarAdop(List<Adoptador> lAdoptadores)
        {
            try
            {
                mArchivo = new FileStream("Adoptador.dat", FileMode.OpenOrCreate, FileAccess.Write);
                convertidor = new BinaryFormatter();
                convertidor.Serialize(mArchivo, lAdoptadores);
                mArchivo.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "999999999999999999");
                return false;
            }
        }

        //desemcripta y regresa la lista de adoptadores guardada
        public List<Adoptador> MostrarLAdop()
        {
            List<Adoptador> lAdoptador = null;
            try
            {
                mArchivo = new FileStream("Adoptador.dat", FileMode.Open, FileAccess.Read);
                convertidor = new BinaryFormatter();
                lAdoptador = (List<Adoptador>)convertidor.Deserialize(mArchivo);
                mArchivo.Close();
                return lAdoptador;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "999999999999999999");
                return null;
            }
        }
    }
}
