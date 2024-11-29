using System.ComponentModel.DataAnnotations;

namespace TurneroMedico1.Models
{
    public class Horario
    { [Key]
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public int PacienteId { get; set; }
        public int DoctorId { get; set; }
        public Paciente Paciente { get; set; }
        public Doctor Doctor { get; set; }

    }
}
