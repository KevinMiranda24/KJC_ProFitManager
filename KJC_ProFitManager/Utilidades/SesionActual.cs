namespace KJC_ProFitManager.Utilidades
{
    public static class SesionActual
    {
        public static string NombreUsuario { get; set; }
        public static string RolUsuario { get; set; }

        public static void CerrarSesion()
        {
            NombreUsuario = null;
            RolUsuario = null;
        }
    }
}
