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
    /// Lógica de interacción para Ventana2.xaml
    /// </summary>
    public partial class Ventana2 : Window
    {
        public List<Mascota> miLista = new List<Mascota>();
        Archivo mArchivo = new Archivo();
        public Ventana2()
        {
            InitializeComponent();
            
           
           
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
           
            string sux = "Hembra";
            try
            {

                if (System.IO.File.Exists("C:\\Users\\Stoya\\Desktop\\pes¿rsistencia\\masco\\Mascotas.dat"))
                {
                    miLista = mArchivo.MostrarL();
                }
                
                if (rBtnGenero.IsChecked==true)
                {
                    sux = "Macho";
                }
                else
                {
                    sux = "Hembra";
                }
                miLista.Add(new Mascota(tbNombre.Text, tbRaza.Text, int.Parse(tbEdad.Text), tbTratamiento.Text,tbReogida.Text,sux));
                tbNombre.Text = "";
                tbRaza.Text = "";
                tbEdad.Text = "";
                tbReogida.Text = "";
                tbTratamiento.Text = "";
                mArchivo.Guardar(miLista);
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "TALVES NO INCERTASTE UN NUMEO ENTERO EN EDAD  \nNota: recuerda q la edad es reprecentada en meses");

            }

        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

       
    }
}
