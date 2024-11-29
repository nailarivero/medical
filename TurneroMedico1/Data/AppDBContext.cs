using TurneroMedico1.Models;
using Microsoft.EntityFrameworkCore;

namespace TurneroMedico1.Data
{
    public class AppDBContext : DbContext // HEREDA DE ENTITy FRAMEWORK
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Horario> Horarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar relaciones en la tabla Horarios
            modelBuilder.Entity<Horario>()
                .HasOne(h => h.Paciente)
                .WithMany()
                .HasForeignKey(h => h.PacienteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Horario>()
                .HasOne(h => h.Doctor)
                .WithMany()
                .HasForeignKey(h => h.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
