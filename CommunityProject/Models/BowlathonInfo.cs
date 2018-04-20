using System;

namespace CommunityProject.Models
{
    public class BowlathonInfo
    {
        public int ID { get; set; } // seemingly unnecessary primary key to appease framework gods
        public int CustID { get; set; } // foreign key mapping to GenInfo.ID
        public int TeamID { get; set; } // NULL if no team, will be identical 
                                        //  for each person registered on the same team
        public string Payment { get; set; } // will be "online" or "in person"
        public string FirstName { get; set; }
        public string LastName { get; set; }
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
