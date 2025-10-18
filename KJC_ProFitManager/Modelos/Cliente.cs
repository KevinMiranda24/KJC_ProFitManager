namespace KJC_ProFitManager.Modelos
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string DUI { get; set; }
        public string TipoMembresia { get; set; } //Puede ser Básica, Premium, VIP, un combobox en la interfaz, datos ya insertados en la base de datos
        public string EstadoSalud { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public string Telefono { get; set; }
        public string TelefonoEmergencia { get; set; }

        //Pueden agregarse más propiedades según sea necesario
        //Puede decirle a chatgpt que apartir de este modelo genere la logica para el CRUD de la clase ClienteDAO y la interfaz WPF, tambien les genera el codigo.
    }
}
