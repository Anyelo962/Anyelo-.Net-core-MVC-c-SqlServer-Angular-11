using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PruebaTecnica.Models
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public string Cedula { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? IdDepartamento { get; set; }
        public string Cargo { get; set; }
        public string SupervisorInmediato { get; set; }

        public virtual Departamento IdDepartamentoNavigation { get; set; }
    }
}
