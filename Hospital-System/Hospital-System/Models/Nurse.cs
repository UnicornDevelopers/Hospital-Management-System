﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.Models
{
    public class Nurse
    {
        public int NurseID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Shift { get; set; }
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }

        //Nav
        public List<Appointment>? Appointments { get; set; }


    }
}
