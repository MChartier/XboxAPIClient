using System.Collections.Generic;

namespace XboxAPIClient.Models.V2
{
    public class HomeAddressInfo
    {
        public object street1 { get; set; }
        public object street2 { get; set; }
        public object city { get; set; }
        public object state { get; set; }
        public object postalCode { get; set; }
        public string country { get; set; }
    }

    public class AccountProfile
    {
        public object userKey { get; set; }
        public List<object> administeredConsoles { get; set; }
        public string dateOfBirth { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public string gamerTag { get; set; }
        public HomeAddressInfo homeAddressInfo { get; set; }
        public object homeConsole { get; set; }
        public string imageUrl { get; set; }
        public bool isAdult { get; set; }
        public string lastName { get; set; }
        public string legalCountry { get; set; }
        public string locale { get; set; }
        public bool msftOptin { get; set; }
        public object ownerHash { get; set; }
        public long ownerXuid { get; set; }
        public object midasConsole { get; set; }
        public bool partnerOptin { get; set; }
        public string userHash { get; set; }
        public long userXuid { get; set; }
        public string touAcceptanceDate { get; set; }
        public object gamerTagChangeReason { get; set; }
    }
}