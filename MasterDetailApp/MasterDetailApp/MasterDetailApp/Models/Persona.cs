using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetailApp.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Pais { get; set; } 

        public int NombreCompleto
        {
            get { return $"{this.Nombre} {this.Apellido}"; }
        }

    }
}
