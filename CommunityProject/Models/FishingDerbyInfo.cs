using System;
namespace CommunityProject.Models
{
    public class FishingDerbyInfo
    {
        public int CustID { get; set; } // foreign key mapping to GenInfo.ID
        public Boolean Consent { get; set; } // separate from GenInfo.PicConsent
    }
}
