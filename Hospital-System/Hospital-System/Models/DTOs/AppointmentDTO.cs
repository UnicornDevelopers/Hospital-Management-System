using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.Models.DTOs
{
    public class AppointmentDTO
    {

        public int Id { get; set; }
        public DateTime DateOfAppointment { get; set; }

        public int PatientId { get; set; }

        public int DoctorId { get; set; }

        // Nav
        public Doctor doctor { get; set; }
        public Patient patient { get; set; }

    }
}
