using KJC_ProFitManager.Utilidades;
using System.Windows;

namespace KJC_ProFitManager
{
    /// <summary>
    /// Lógica de interacción para VtaMenuPrincipal.xaml
    /// </summary>
    public partial class VtaMenuPrincipal : Window
    {
        public VtaMenuPrincipal()
        {
            InitializeComponent();
            lblBienvenida.Text = $"Bienvenido, {SesionActual.NombreUsuario}\nRol: {SesionActual.RolUsuario}";
        }

        private void BtnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            SesionActual.CerrarSesion();
            VtaIniciarSesion login = new VtaIniciarSesion();
            login.Show();
            this.Close();
        }
    }
}
