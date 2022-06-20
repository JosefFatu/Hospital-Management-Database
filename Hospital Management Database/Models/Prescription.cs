using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_Database.Models
{
    public class Prescription
    {
        public int PrescriptionId {get; set;}
        [Display(Name = "Name"), Required, MaxLength(50)]
        [StringLength(30, MinimumLength = 3)]
        public string Prescriptionname { get; set; }
        [Display(Name = "Lab"), Required, MaxLength(50)]
        [StringLength(30, MinimumLength = 3)]
        public string PrescriptionLab { get; set; }

        public ICollection<Patient> Patient { get; set; }
    }
}
