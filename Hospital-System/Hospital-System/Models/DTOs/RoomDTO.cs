using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.Models.DTOs
{
    public class RoomDTO
    {

        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public bool RoomAvailability { get; set; }
        public int NumberOfBeds { get; set; }
        public int DepartmentID { get; set; }
        public int PatientID { get; set; }

        //Nav

        public List<Patient>? Patients { get; set; }

    }
}
