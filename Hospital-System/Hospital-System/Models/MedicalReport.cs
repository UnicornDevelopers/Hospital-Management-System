using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.Models
{
    public class MedicalReport
    {
        public int MedicalReportID { get; set; }
        [ForeignKey("Medicine")]
        public int MedicineID { get; set; }
        public DateTime ReportDate { get; set; }
        public string Description { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorID { get; set; }
        [ForeignKey("Patient")]
        public int PatientID { get; set; }

        //Nav


        public List<Medicine> Medicines { get; set; }


    }
}
