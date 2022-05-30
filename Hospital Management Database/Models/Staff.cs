using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_Database.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        [Display(Name = "First Name")]
        public string StaffFirstName { get; set; }
        [Display(Name = "Last Name")]
        public string StaffLastName { get; set; }
        [Display(Name = "Gender")]
        public string StaffGender { get; set; }
        [Display(Name = "Age")]
        public int StaffAge { get; set; }
        [Display(Name = "Address")]
        public string StaffAddress { get; set; }

        public ICollection<Patient> Patient { get; set; }

    }
}
