using System.Windows;

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
