﻿using AppointmentSetter.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace AppointmentSetter.DataAccess
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentType> AppointmentTypes { get; set; }
        public DbSet<AppointmentAttender> AppointmentAttenders { get; set; } 

        public ApplicationDbContext()
            : base("AppointmentSetterDB", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}