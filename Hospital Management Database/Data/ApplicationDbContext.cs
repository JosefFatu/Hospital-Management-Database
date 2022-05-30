using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Hospital_Management_Database.Models;

namespace Hospital_Management_Database.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Hospital_Management_Database.Models.Patient> Patient { get; set; }
        public DbSet<Hospital_Management_Database.Models.Staff> Staff { get; set; }
        public DbSet<Hospital_Management_Database.Models.AdmissionDischarge> AdmissionDischarge { get; set; }
        public DbSet<Hospital_Management_Database.Models.Prescription> Prescription { get; set; }
    }
}
