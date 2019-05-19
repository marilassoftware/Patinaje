namespace Patinaje.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Patinador
    {
        [Key]
        public int idPatinador { get; set; }

        public String Identificacion { get; set; }

        public String Nombre { get; set; }

        public String Apellido1 { get; set; }

        public String Apellido2 { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }
}
