namespace KJC_ProFitManager.Modelos
{
    public class Sucursal
    {
        public int IdSucursal { get; set; } //Puede ser un Combobox en la interfaz para seleccionar la sucursal, pueden ser 4, datos ya insertados en la base de datos
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }

        //Pueden agregarse más propiedades según sea necesario
        //Puede decirle a chatgpt que apartir de este modelo genere la logica para el CRUD de la clase SucursalDAO y la interfaz WPF, tambien les genera el codigo.
    }
}
