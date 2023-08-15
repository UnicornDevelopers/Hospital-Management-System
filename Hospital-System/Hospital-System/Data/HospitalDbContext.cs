using Hospital_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital_System.Data
{
    public class HospitalDbContext : DbContext
    {

        public HospitalDbContext(DbContextOptions options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<Doctor>()
          .HasMany(a => a.Appointments)
           .WithOne(b => b.doctor)
             .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Appointment>()
             .HasOne(a => a.doctor)
             .WithMany(d => d.Appointments)
             .HasForeignKey(a => a.DoctorId)
             .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.patient)
                .WithMany(p => p.Appointments)
                .HasForeignKey(a => a.PatientId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Doctor>()
      .HasMany(a => a.medicalReports)
      .WithOne(b => b.doctor)
       .OnDelete(DeleteBehavior.ClientSetNull);


            modelBuilder.Entity<Patient>()
      .HasMany(a => a.Appointments)
      .WithOne(b => b.patient);

            modelBuilder.Entity<Patient>()
   .HasMany(a => a.MedicalReports)
   .WithOne(b => b.patient);

            modelBuilder.Entity<Department>()
      .HasMany(a => a.Doctors)
      .WithOne(b => b.department);

            modelBuilder.Entity<Department>()
      .HasMany(a => a.Nurses)
      .WithOne(b => b.department);

            modelBuilder.Entity<Department>()
      .HasMany(a => a.Rooms)
      .WithOne(b => b.department);

            modelBuilder.Entity<MedicalReport>()
      .HasMany(a => a.Medicines)
      .WithOne(b => b.medicalReport);

            modelBuilder.Entity<Room>()
           .HasMany(a => a.Patients)
            .WithOne(b => b.Rooms);

            modelBuilder.Entity<MedicalReport>()
               .HasMany(a => a.Medicines)
              .WithOne(b => b.medicalReport);

            modelBuilder.Entity<MedicalReport>()
           .HasMany(a => a.Medicines)
         .WithOne(b => b.medicalReport);





            // Seed Nurses data
            modelBuilder.Entity<Nurse>().HasData(
                new Nurse
                {
                    Id = 1,
                    FirstName = "Moh ",
                    LastName = "Ahmad",
                    Gender = "Male",
                    ContactNumber = "123-456-7890",
                    shift = Nurse.Shift.Morning,
                    DepartmentId = 1
                },
                new Nurse
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "JG",
                    Gender = "Female",
                    ContactNumber = "987-654-3210",
                    shift = Nurse.Shift.Afternoon,
                    DepartmentId = 2
                },
                new Nurse
                {
                    Id = 3,
                    FirstName = "fname",
                    LastName = "lname",
                    Gender = "Male",
                    ContactNumber = "555-555-5555",
                    shift = Nurse.Shift.Night,
                    DepartmentId = 1
                }
            );


            // Seed Departments data
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    Id = 1,
                    DepartmentName = "Internal Medicine"
                },
                new Department
                {
                    Id = 2,
                    DepartmentName = "Surgery"
                }
            );





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
