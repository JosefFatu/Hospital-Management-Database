using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_Database.Models
{
    public class Prescription
    {
        public int PrescriptionId {get; set;}
        [Display(Name = "Name")]
        public string Prescriptionname { get; set; }
        [Display(Name = "Lab")]
        public string PrescriptionLab { get; set; }

        public ICollection<Patient> Patient { get; set; }
    }
}
