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
    /// Lógica de interacción para Ventana4.xaml
    /// </summary>
    public partial class Ventana4 : Window
    {
       
        public Ventana4(string nombre,string raza,string edad,string lugar,string tratamiento,string genero,string nom,string dir,string p)
        {
            InitializeComponent();
            tblNombre.Text = nombre;
            tblRaza.Text = raza;
            tblEdad.Text = edad;
            tblLugar.Text = lugar;
            tblDiacnostico.Text = tratamiento;
            tblGenero.Text = genero;
            tblNombreAdop.Text = nom;
            tblDireccionAdop.Text = dir;
            tblPhoneAdop.Text = p;
        }
    }
}
