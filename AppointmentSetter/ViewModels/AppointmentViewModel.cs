﻿using AppointmentSetter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppointmentSetter.ViewModels
{
    public class AppointmentViewModel
    {
        public string Notes { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        public string Time { get; set; }

        [Display(Name = "Appointment Type"), Required]
        public int AppointmentType { get; set; }

        public IEnumerable<AppointmentType> AppointmentTypes { get; set; }

        public DateTime GetStartTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}