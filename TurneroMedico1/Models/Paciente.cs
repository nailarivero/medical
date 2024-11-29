using System.ComponentModel.DataAnnotations;

namespace TurneroMedico1.Models
{
    public class Paciente
    { [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string DNI { get; set; }

    }
}
