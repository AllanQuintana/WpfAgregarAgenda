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
using System.IO;


namespace WpfMiAgenda
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            this.txtNombre.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
        }

        private void btnGrabar_Click(object sender, RoutedEventArgs e)
        {
            string strNombre, strTelefono;
            strNombre = this.txtNombre.Text;
            strTelefono = this.txtTelefono.Text;

            FileStream f;
            StreamWriter fr;
            string linea;
            f = new FileStream ("MiAgenda.txt", FileMode.Append, FileAccess.Write);
            fr = new StreamWriter (f);
            linea = strNombre.ToUpper()+","+strTelefono;
            fr.WriteLine(linea);
            MessageBox.Show("Contacto agregado");
            fr.Close();
            f.Close();
        }
    }
}
