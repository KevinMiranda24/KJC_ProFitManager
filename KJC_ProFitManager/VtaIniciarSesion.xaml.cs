using KJC_ProFitManager.Datos;
using KJC_ProFitManager.Utilidades;
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

        private void BtnIniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string contrasena = txtContrasena.Password.Trim();

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasena))
            {
                lblError.Text = "Debe ingresar correo y contraseña.";
                return;
            }

            // Encriptar la contraseña
            string hash = Seguridad.SHA256Hash(contrasena);

            var usuario = UsuarioDAO.Login(correo, hash);

            if (usuario != null)
            {
                // Guardar datos en SesionActual
                SesionActual.NombreUsuario = usuario.NombreCompleto;
                SesionActual.RolUsuario = usuario.Rol;

                MessageBox.Show($"Bienvenido {usuario.NombreCompleto} ({usuario.Rol})", "Acceso concedido", MessageBoxButton.OK, MessageBoxImage.Information);

                // Abrir la ventana principal del sistema
                VtaMenuPrincipal menu = new VtaMenuPrincipal();
                menu.Show();

                this.Close();
            }
            else
            {
                lblError.Text = "Correo o contraseña incorrectos.";
            }
        }
    }
}
