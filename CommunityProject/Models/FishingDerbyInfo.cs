﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommunityProject.Models
{
    public class FishingDerbyInfo
    {
        public int ID { get; set; } // seemingly unnecessary primary key to appease framework gods
        public Boolean Consent { get; set; } // separate from GenInfo.PicConsent

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public int ZIP { get; set; }

        [Required(ErrorMessage = "Field required")]
        [Display(Name = "T-Shirt Size")]
        public string ShirtSize { get; set; }

        [Display(Name = "I consent to having my photo taken by the CHDC Volunteer Council")]
        public Boolean PicConsent { get; set; }
    }
}
