using System;
using System.Collections.Generic;

namespace proyecto_consola.Models
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Direccion { get; set; }
        public int? Telefono { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Estado { get; set; }
    }
}
