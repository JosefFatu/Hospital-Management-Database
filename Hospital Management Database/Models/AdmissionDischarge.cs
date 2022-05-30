﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_Database.Models
{
    public class AdmissionDischarge
    {
        public int AdmissionDischargeId { get; set; }
        [Display(Name = "Ward Number")]
        public int wardnumber { get; set; }
        [Display(Name = "Bed Number")]
        public int bednumber { get; set; }
        [Display(Name = "Date Admitted")]
        public string dateadmitted { get; set; }
        [Display(Name = "Date Discharged")]
        public string datedischarged { get; set; }

        public Patient Patient { get; set; }
    }
}