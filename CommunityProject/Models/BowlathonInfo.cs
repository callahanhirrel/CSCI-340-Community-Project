using System;
namespace CommunityProject.Models
{
    public class BowlathonInfo
    {
        public int CustID { get; set; } // foreign key mapping to GenInfo.ID
        public int TeamID { get; set; } // NULL if no team, will be identical 
                                        //  for each person registered on the same team
    }
}
