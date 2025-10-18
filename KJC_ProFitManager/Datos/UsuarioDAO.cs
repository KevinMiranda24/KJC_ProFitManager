using KJC_ProFitManager.Modelos;
using Microsoft.Data.SqlClient;

namespace KJC_ProFitManager.Datos
{
    class UsuarioDAO
    {
        public static Usuario Login(string correo, string hashContrasena)
        {
            using (SqlConnection conexion = ComunDB.ObtenerConexion())
            {
                string query = "SELECT * FROM Usuario WHERE Correo=@Correo AND ContrasenaHash=@Hash AND Estado=1";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Hash", hashContrasena);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Usuario
                            {
                                IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                NombreCompleto = reader["NombreCompleto"].ToString(),
                                Correo = reader["Correo"].ToString(),
                                ContrasenaHash = reader["ContrasenaHash"].ToString(),
                                Rol = reader["Rol"].ToString(),
                                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]),
                                Estado = Convert.ToBoolean(reader["Estado"])
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
