using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.Models
{
    public class Doctor
    {

        public int DoctorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Speciality { get; set; }
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }

        //Nav

        public List<Appointment>? Appointments { get; set; }
        public List<Medicine>? Medicines { get; set; }




    }
}
