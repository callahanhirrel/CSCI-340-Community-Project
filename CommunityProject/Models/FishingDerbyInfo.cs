using System;
namespace CommunityProject.Models
{
    public class FishingDerbyInfo
    {
        public int ID { get; set; } // seemingly unnecessary primary key to appease framework gods
        public int CustID { get; set; } // foreign key mapping to GenInfo.ID
        public Boolean Consent { get; set; } // separate from GenInfo.PicConsent
    }
}
