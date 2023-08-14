using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.Models.DTOs
{
    public class DoctorDTO
    {

        public int DoctorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Speciality { get; set; }
        public int DepartmentID { get; set; }

        //Nav

        public List<Appointment>? Appointments { get; set; }
        public List<Medicine>? Medicines { get; set; }

    }
}
