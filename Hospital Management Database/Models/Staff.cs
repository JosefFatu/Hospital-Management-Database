using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_Database.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        [Display(Name = "First Name"), Required, MaxLength(50)]
        [StringLength(30, MinimumLength = 3)]
        public string StaffFirstName { get; set; }
        [Display(Name = "Last Name"), Required, MaxLength(50)]
        [StringLength(30, MinimumLength = 3)]
        public string StaffLastName { get; set; }
        [Display(Name = "Gender"), Required, MaxLength(7)]
        [StringLength(7, MinimumLength = 3)]
        public string StaffGender { get; set; }
        [Display(Name = "Age"), Required, MaxLength(3)]
        [StringLength(3, MinimumLength = 1)]
        public int StaffAge { get; set; }
        [Display(Name = "Address"), Required, MaxLength(50)]
        [StringLength(30, MinimumLength = 3)]
        public string StaffAddress { get; set; }

        public ICollection<Patient> Patient { get; set; }

    }
}
