using System;
using System.ComponentModel.DataAnnotations;

namespace CommunityProject.Models
{
    public class GenInfo
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZIP { get; set; }
        public string ShirtSize { get; set; }
        public Boolean PicConsent { get; set; }
    }
}
