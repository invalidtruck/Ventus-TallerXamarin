using System;

namespace MasterDetailApp.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Pais { get; set; }

        public string NombreCompleto => $"{this.Nombre} {this.Apellido}";
    }
}