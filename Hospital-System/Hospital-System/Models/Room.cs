using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public bool RoomAvailability { get; set; }
        public int NumberOfBeds { get; set; }
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        [ForeignKey("Patient")]
        public int PatientID { get; set; }

        //Nav

        public List<Patient>? Patients { get; set; }

    }
}
