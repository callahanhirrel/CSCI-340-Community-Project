using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommunityProject.Models
{
    public class BowlathonInfo
    {
        public int ID { get; set; }
        public int TeamID { get; set; } // NULL if no team, will be identical 
                                        //  for each person registered on the same team
        public string Payment { get; set; } // will be "online" or "in person"

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
        [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}", ErrorMessage = "Please input a valid phone number")] // got this RE from here: https://stackoverflow.com/a/18091377
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [RegularExpression(@"^\d{5}(?:[-\s]\d{4})?$")] // got this RE from here: https://stackoverflow.com/a/14942826
        public int ZIP { get; set; }

        [Required(ErrorMessage = "Field required")]
        [Display(Name = "T-Shirt Size")]
        public string ShirtSize { get; set; }

        [Required(ErrorMessage = "You must give photo consent to participate.")]
        [Display(Name = "I consent to having my photo taken by the CHDC Volunteer Council")]
        public Boolean PicConsent { get; set; }
    }
}
