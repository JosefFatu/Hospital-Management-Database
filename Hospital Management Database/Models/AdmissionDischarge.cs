using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_Database.Models
{
    public class AdmissionDischarge
    {
        public int AdmissionDischargeId { get; set; }
        [Display(Name = "Ward Number")]
        [Range(1, 100000, ErrorMessage ="Please use values between 1 and 100000")]
        public int wardnumber { get; set; }
        [Display(Name = "Bed Number")]
        [Range(1, 1000000, ErrorMessage ="Please use values between 1 and 1000000")]
        public int bednumber { get; set; }
        [Display(Name = "Date Admitted")]
        public DateTime dateadmitted { get; set; }
        [Display(Name = "Date Discharged")]
        public DateTime datedischarged { get; set; }

        public Patient Patient { get; set; }
    }
}
