using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PruebaTecnica.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
