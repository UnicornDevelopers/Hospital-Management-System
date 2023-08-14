using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.Models.DTOs
{
    public class DepartmentDTO
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public int RoomID { get; set; }
        public int DoctorID { get; set; }
        public int NurseID { get; set; }

        //Nav
        public List<Room>? Rooms { get; set; }
        public List<Doctor>? Doctors { get; set; }
        public List<Nurse>? Nurses { get; set; }


    }
}
