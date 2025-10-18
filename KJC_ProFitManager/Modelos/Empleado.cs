namespace KJC_ProFitManager.Modelos
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; } //Creo que deberia ir relacionado con la tabla de Usuarios pero nose. como se repite informacion como (Gerente General, Coach, PersonalLimpieza, PersonalFinanzas, PersonalAdministrativo)
        public string Telefono { get; set; }
        public string Correo { get; set; }

        //Pueden agregarse más propiedades según sea necesario
        //Puede decirle a chatgpt que apartir de este modelo genere la logica para el CRUD de la clase EmpleadoDAO y la interfaz WPF, tambien les genera el codigo.
    }
}
