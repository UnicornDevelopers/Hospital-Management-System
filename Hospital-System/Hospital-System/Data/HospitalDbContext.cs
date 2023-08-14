using Hospital_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital_System.Data
{
    public class HospitalDbContext : DbContext
    {

        public HospitalDbContext(DbContextOptions options) : base(options)
        {


        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<MedicalReport> MedicalReports { get; set; }

    }
}
