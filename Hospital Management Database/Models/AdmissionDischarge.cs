using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_Database.Models
{
    public class AdmissionDischarge
    {
        public int AdmissionDischargeId { get; set; }
        [Display(Name = "Ward Number"), Required, MaxLength(50)]
        [StringLength(30, MinimumLength = 3)]
        public int wardnumber { get; set; }
        [Display(Name = "Bed Number"), Required, MaxLength(50)]
        [StringLength(30, MinimumLength = 3)]
        public int bednumber { get; set; }
        [Display(Name = "Date Admitted"), Required, MaxLength(50)]
        [StringLength(30, MinimumLength = 3)]
        public string dateadmitted { get; set; }
        [Display(Name = "Date Discharged"), Required, MaxLength(50)]
        [StringLength(30, MinimumLength = 3)]
        public string datedischarged { get; set; }

        public Patient Patient { get; set; }
    }
}
