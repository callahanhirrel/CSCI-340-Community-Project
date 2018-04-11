using System;
namespace CommunityProject.Models
{
    public class BowlathonInfo
    {
        public int ID { get; set; } // seemingly unnecessary primary key to appease framework gods
        public int CustID { get; set; } // foreign key mapping to GenInfo.ID
        public int TeamID { get; set; } // NULL if no team, will be identical 
                                        //  for each person registered on the same team
        public int Payment { get; set; } // will be "online" or "in person"
    }
}
