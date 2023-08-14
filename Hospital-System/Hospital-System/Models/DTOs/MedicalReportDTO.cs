using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.Models.DTOs
{
    public class MedicalReportDTO
    {

        public int MedicialReportID { get; set; }
        public int MedicineID { get; set; }
        public DateTime ReportDate { get; set; }
        public string Description { get; set; }
        public int DoctorID { get; set; }
        public int PatientID { get; set; }

       


    }
}
