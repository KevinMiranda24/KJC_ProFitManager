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

namespace KJC_ProFitManager
{
    /// <summary>
    /// Lógica de interacción para VtaIniciarSesion.xaml
    /// </summary>
    public partial class VtaIniciarSesion : Window
    {
        public VtaIniciarSesion()
        {
            InitializeComponent();
        }

		private void btnRegresar_Click(object sender, RoutedEventArgs e)
		{
			MainWindow regresar = new MainWindow();
            regresar.Show();
            this.Close();
        }

		private void btnSalir_Click(object sender, RoutedEventArgs e)
		{
            this.Close();
		}
	}
}
