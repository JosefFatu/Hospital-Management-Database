using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_Database.Models
{
    public class Patient
    {
        public int Patientid { get; set; }
        [Display(Name ="First Name")]

        public string PatientFirstname { get; set; }
        [Display(Name = "Last Name")]
        public string PatientLastName { get; set; }
        [Display(Name = "Gender")]
        public string PatientGender { get; set; }
        [Display(Name = "Age")]
        public int PatientAge { get; set; }
        [Display(Name = "Address 1")]
        public string PatientAdress1 { get; set; }
        [Display(Name = "Address 2")]
        public string PatientAddress2 { get; set; }
        [Display(Name = "City")]
        public string PatientCity { get; set; }
        [Display(Name = "Zip")]
        public int PatientZip { get; set;  }
        [Display(Name = "State")]
        public string PatientState { get; set; }
        [Display(Name = "Room Number")]
        public int PatientRoomNumber { get; set; }

        public ICollection<Staff> Staff { get; set; }

        public ICollection<AdmissionDischarge> AdmissionDischarge { get; set; }

        public Prescription Prescription { get; set; }
    }
}
