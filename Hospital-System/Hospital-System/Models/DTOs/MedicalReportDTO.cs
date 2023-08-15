using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.Models.DTOs
{
    public class MedicalReportDTO
    {

        public int Id { get; set; }
        public int MedicineId { get; set; }
        public DateTime ReportDate { get; set; }
        public string Description { get; set; }
        public int DoctorId { get; set; }

        public int PatientId { get; set; }

        //Nav


        public List<Medicine> Medicines { get; set; }
        public Doctor doctor { get; set; }
        public Patient patient { get; set; }



    }
}
