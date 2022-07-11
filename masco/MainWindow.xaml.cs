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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace masco
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Mascota> ListaPeets = new List<Mascota>();
        List<Adoptador> ListaAdoptador = new List<Adoptador>();
        Archivo mArchivo = new Archivo();
        public MainWindow()
        {
            InitializeComponent();
            ListaPeets = mArchivo.MostrarL();
            ListaAdoptador = mArchivo.MostrarLAdop();
            LboxMascotas.ItemsSource = null;
            LboxMascotas.ItemsSource = ListaPeets;
            LboxAdoptador.ItemsSource = null;
            LboxAdoptador.ItemsSource = ListaAdoptador;
            
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
           
            Ventana2 v = new Ventana2();

            v.Show();
           
            
        }
        //Boton de refrescar
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Actualizar();
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((LboxMascotas.SelectedItem as Mascota) == null)
                {
                    MessageBox.Show("no seleccionate a una mascota ");
                }
                else
                {
                    if ((LboxMascotas.SelectedItem as Mascota).Codigo!="sin adoptar")
                {
                    for (int i = 0; i < ListaAdoptador.Count; i++)
                    {
                        if ((LboxMascotas.SelectedItem as Mascota).Codigo.Equals(ListaAdoptador[i].ci))
                        {
                            ListaAdoptador.RemoveAt(i);
                        }
                    }
                    mArchivo.GuardarAdop(ListaAdoptador);
               
                }
                ListaPeets.Remove((LboxMascotas.SelectedItem as Mascota));
                mArchivo.Guardar(ListaPeets);
                //LboxMascotas.ItemsSource = null;
                //LboxMascotas.ItemsSource = ListaPeets;
                Actualizar();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("no seleccionate a una mascota " + ex);
            }
        }

        private void btnAdoptador_Click(object sender, RoutedEventArgs e)
        {
            Ventana3 v3 = new Ventana3();
            v3.Show();
        }

        private void btnBorrarA_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if((LboxAdoptador.SelectedItem as Adoptador) != null)
                {

                for (int i = 0; i < ListaPeets.Count; i++)
                {
                    if ((LboxAdoptador.SelectedItem as Adoptador).ci.Equals(ListaPeets[i].Codigo))
                    {
                        ListaPeets[i].Codigo = "sin adoptar";
                        mArchivo.Guardar(ListaPeets);
                        LboxMascotas.ItemsSource = null;
                        LboxMascotas.ItemsSource = ListaPeets;
                        break;
                    }
                }
            
                ListaAdoptador.Remove((LboxAdoptador.SelectedItem as Adoptador));
                mArchivo.GuardarAdop(ListaAdoptador);
                LboxAdoptador.ItemsSource = null;
                LboxAdoptador.ItemsSource = ListaAdoptador;
                }
                else
                {
                    MessageBox.Show("No seleeccionaste un adoptador");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No seleccionaste un adoptador");
            }
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        

        private void LboxMascotas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string nom="", dir="", p="";
            for (int i = 0; i < ListaAdoptador.Count; i++)
            {
                if (ListaAdoptador[i].ci.Equals((LboxMascotas.SelectedItem as Mascota).Codigo))
                {
                    nom = ListaAdoptador[i].nombre;
                    dir= ListaAdoptador[i].direccion;
                    p= ListaAdoptador[i].phone;
                    break;
                }
            }
            Ventana4 v4 = new Ventana4((LboxMascotas.SelectedItem as Mascota).nombre, (LboxMascotas.SelectedItem as Mascota).raza, (LboxMascotas.SelectedItem as Mascota).edad.ToString() , (LboxMascotas.SelectedItem as Mascota).Lugar, (LboxMascotas.SelectedItem as Mascota).Tratamiento, (LboxMascotas.SelectedItem as Mascota).Sexo,nom,dir,p);
            v4.Show();
            
        }



        private void lbEstado_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ListaPeets = mArchivo.MostrarL();
            var lsitaOrdenada = ListaPeets.OrderBy(x => x.Codigo).ToList();
                      
            mArchivo.Guardar(lsitaOrdenada);
            Actualizar();

        }

        private void lbNombre_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ListaPeets = mArchivo.MostrarL();
            var lsitaOrdenada = ListaPeets.OrderBy(x => x.nombre).ToList();
            
            mArchivo.Guardar(lsitaOrdenada);
            Actualizar();
            
        }

        private void lbRaza_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ListaPeets = mArchivo.MostrarL();
            var lsitaOrdenada = ListaPeets.OrderBy(x => x.raza).ToList();

            mArchivo.Guardar(lsitaOrdenada);
            Actualizar();
        }
        private void Actualizar()
        {
            ListaPeets = mArchivo.MostrarL();
            LboxMascotas.ItemsSource = null;
            LboxMascotas.ItemsSource = ListaPeets;
            ListaAdoptador = mArchivo.MostrarLAdop();
            LboxAdoptador.ItemsSource = null;
            LboxAdoptador.ItemsSource = ListaAdoptador;
        }

        private void lbEdad_MouseDown(object sender, MouseButtonEventArgs e)
        {

            ListaPeets = mArchivo.MostrarL();
            var lsitaOrdenada = ListaPeets.OrderBy(x => x.edad).ToList();

            mArchivo.Guardar(lsitaOrdenada);
            Actualizar();
        }

        private void lbNombreAdop_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ListaAdoptador = mArchivo.MostrarLAdop();
            var lsitaOrdenada = ListaAdoptador.OrderBy(x => x.nombre).ToList();

            mArchivo.GuardarAdop(lsitaOrdenada);
            Actualizar();
        }
    }
}
