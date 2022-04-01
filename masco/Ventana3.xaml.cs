using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace masco
{
    /// <summary>
    /// Lógica de interacción para Ventana3.xaml
    /// </summary>
    public partial class Ventana3 : Window
    {
        List<Adoptador> ListaAdoptar = new List<Adoptador>();
        Archivo mArchivo = new Archivo();
        List<Mascota> lsitaMascota = new List<Mascota>();
        public Ventana3()
        {
            InitializeComponent();
        }

        private void btnAgregarA_Click(object sender, RoutedEventArgs e)
        {
            bool flag = true;

            if (System.IO.File.Exists("Adoptador.dat"))
            {
                 ListaAdoptar = mArchivo.MostrarLAdop();
            }
            lsitaMascota = mArchivo.MostrarL();
            for (int i = 0; i < lsitaMascota.Count; i++)
            {

                if (tbNombreMascota.Text.Equals(lsitaMascota[i].nombre))
                {

                    ListaAdoptar.Add(new Adoptador() { nombre = tbNombreA.Text, apellido = tbApellidoA.Text, direccion = tbDireccionA.Text, ci = tbCiA.Text,phone=tbPhone.Text });
                    lsitaMascota[i].Ci = tbCiA.Text;
                    tbNombreA.Text = "";
                    tbApellidoA.Text = "";
                    tbDireccionA.Text = "";
                    tbCiA.Text = "";
                    tbNombreMascota.Text = "";
                    mArchivo.Guardar(lsitaMascota);
                    mArchivo.GuardarAdop(ListaAdoptar);
                    flag = false;
                    Close();
                    break;
                }
            }
            if (flag)
            {
                MessageBox.Show("el nombre de la mascota no esta registrada intente otra vez");
                tbNombreMascota.Text = "";
            }
            
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

       
    }
}
