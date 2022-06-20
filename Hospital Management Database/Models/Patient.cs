using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_Database.Models
{
    public class Patient
    {
        public int Patientid { get; set; }
        [Display(Name ="First Name"), Required, MaxLength(50)]
        [StringLength(30, MinimumLength = 3)]
        public string PatientFirstname { get; set; }
        [Display(Name = "Last Name"), Required, MaxLength(50)]
        [StringLength(30, MinimumLength = 3)]
        public string PatientLastName { get; set; }
        [Display(Name = "Gender"), Required, MaxLength(7)]
        [StringLength(7, MinimumLength = 3)]
        public string PatientGender { get; set; }
        [Display(Name = "Age"), Required, MaxLength(3)]
        [StringLength(3, MinimumLength = 1)]
        public int PatientAge { get; set; }
        [Display(Name = "Address 1"), Required, MaxLength(50)]
        [StringLength(30, MinimumLength = 3)]
        public string PatientAdress1 { get; set; }
        [Display(Name = "Address 2"), Required, MaxLength(50)]
        [StringLength(30, MinimumLength = 3)]
        public string PatientAddress2 { get; set; }
        [Display(Name = "City"), Required, MaxLength(50)]
        [StringLength(30, MinimumLength = 3)]
        public string PatientCity { get; set; }
        [Display(Name = "Zip"), Required, MaxLength(4)]
        [StringLength(4, MinimumLength = 3)]
        public int PatientZip { get; set;  }
        [Display(Name = "State"), Required, MaxLength(50)]
        [StringLength(30, MinimumLength = 3)]
        public string PatientState { get; set; }
        [Display(Name = "Room Number"), Required, MaxLength(50)]
        [StringLength(30, MinimumLength = 3)]
        public int PatientRoomNumber { get; set; }

        public ICollection<Staff> Staff { get; set; }

        public ICollection<AdmissionDischarge> AdmissionDischarge { get; set; }

        public Prescription Prescription { get; set; }
    }
}
