using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.Models.DTOs
{
    public class PatientDTO
    {
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public int RoomID { get; set; }
        public int AppointmentID { get; set; }
        public int MedicalReportID { get; set; }
        //Nav

        public Room? Rooms { get; set; }
        public List<Appointment>? Appointments { get; set; }
        public List<MedicalReport>? MedicalReports { get; set; }


    }
}
