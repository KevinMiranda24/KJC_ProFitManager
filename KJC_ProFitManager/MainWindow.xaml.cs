using System.Windows;

namespace KJC_ProFitManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
			//Quitar siempre los Using no utilizados, click derecho, acciones rapidas, quitar usings no utilizados.
		}

		private void BtnIniciar_Click(object sender, RoutedEventArgs e)
		{
            // Instancia del objeto ventanaLogin que nos lleva a la ventana de iniciar sesion.
            VtaIniciarSesion ventanaLogin = new VtaIniciarSesion();
			ventanaLogin.Show();
			// Cerrar la ventana actual para que no quede encima de la otra.
			this.Close();
		}
	}
}