using System.ComponentModel.DataAnnotations;

namespace TurneroMedico1.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
    }
}
