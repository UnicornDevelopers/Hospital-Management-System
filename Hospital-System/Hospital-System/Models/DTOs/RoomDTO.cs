using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.Models.DTOs
{
    public class RoomDTO
    {

        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public bool RoomAvailability { get; set; }
        public int NumberOfBeds { get; set; }
        public int? DepartmentId { get; set; }
        public int PatientId { get; set; }

        //Nav
        public List<Patient> Patients { get; set; }
        public Department department { get; set; }

    }
}
