using Microsoft.Data.SqlClient;

namespace KJC_ProFitManager.Datos
{
    class ComunDB
    {
        private static string cadenaConexion =
            "Server=MIRANDA\\SQLDEV2022; Database=DB_KJCGym; User Id=estudiantepoec; Password=ITCA321; TrustServerCertificate=True;";
            //"Server=TúServidorRegalo; Database=DB_KJCGym; User Id=estudiantepoec; Password=ITCA321; TrustServerCertificate=True;";
            //"Server=TúServidorCarlos; Database=DB_KJCGym; User Id=estudiantepoec; Password=ITCA321; TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }
    }
}
