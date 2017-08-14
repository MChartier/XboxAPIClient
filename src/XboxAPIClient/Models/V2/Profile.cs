namespace XboxAPIClient.Models.V2
{
    public class Profile
    {
        public long id { get; set; }
        public long hostId { get; set; }
        public string Gamertag { get; set; }
        public string GameDisplayName { get; set; }
        public string AppDisplayName { get; set; }
        public int Gamerscore { get; set; }
        public string GameDisplayPicRaw { get; set; }
        public string AppDisplayPicRaw { get; set; }
        public string AccountTier { get; set; }
        public string XboxOneRep { get; set; }
        public string PreferredColor { get; set; }
        public int TenureLevel { get; set; }
        public bool isSponsoredUser { get; set; }
    }
}