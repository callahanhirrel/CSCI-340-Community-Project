using System;
namespace CommunityProject.Models
{
    public class WalkathonInfo
    {
        public int ID { get; set; } // seemingly unnecessary primary key to appease framework gods
        public int CustID { get; set; } // foreign key mapping to GenInfo.ID
        public int Payment { get; set; } // will be "online" or "in person"
    }
}
