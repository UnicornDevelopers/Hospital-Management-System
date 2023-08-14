using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        [ForeignKey("Room")]
        public int RoomID { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorID { get; set; }
        [ForeignKey("Nurse")]
        public int NurseID { get; set; }

        //Nav
        public List<Room>? Rooms { get; set; }
        public List<Doctor>? Doctors { get; set; }
        public List<Nurse>? Nurses { get; set; }



    }
}
