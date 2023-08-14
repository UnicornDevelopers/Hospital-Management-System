using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.Models.DTOs
{
    public class AppointmentDTO
    {

        public int AppointmentID { get; set; }
        public DateTime DateOfAppointment { get; set; }
        
        public int PatientID { get; set; }



        // Nav
        public Doctor doctor { get; set; }

    }
}
