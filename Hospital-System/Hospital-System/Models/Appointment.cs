using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public DateTime DateOfAppointment { get; set; }
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
       


        // Nav
        //public Doctor? doctor { get; set; }

    }
}
