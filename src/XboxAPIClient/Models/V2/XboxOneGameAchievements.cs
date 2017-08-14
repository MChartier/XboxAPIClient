using System.Collections.Generic;

namespace XboxAPIClient.Models.V2
{
    public class TitleAssociation
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Requirement
    {
        public string id { get; set; }
        public object current { get; set; }
        public int target { get; set; }
        public string operationType { get; set; }
        public string valueType { get; set; }
        public string ruleParticipationType { get; set; }
    }

    public class Progression
    {
        public List<Requirement> requirements { get; set; }
        public string timeUnlocked { get; set; }
    }

    public class MediaAsset
    {
        public string name { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Reward
    {
        public object name { get; set; }
        public object description { get; set; }
        public int value { get; set; }
        public string type { get; set; }
        public object mediaAsset { get; set; }
        public string valueType { get; set; }
    }

    public class Rarity
    {
        public string currentCategory { get; set; }
        public double currentPercentage { get; set; }
    }

    public class XboxOneGameAchievement
    {
        public int id { get; set; }
        public string serviceConfigId { get; set; }
        public string name { get; set; }
        public List<TitleAssociation> titleAssociations { get; set; }
        public string progressState { get; set; }
        public Progression progression { get; set; }
        public List<MediaAsset> mediaAssets { get; set; }
        public List<string> platforms { get; set; }
        public bool isSecret { get; set; }
        public string description { get; set; }
        public string lockedDescription { get; set; }
        public string productId { get; set; }
        public string achievementType { get; set; }
        public string participationType { get; set; }
        public object timeWindow { get; set; }
        public List<Reward> rewards { get; set; }
        public string estimatedTime { get; set; }
        public object deeplink { get; set; }
        public bool isRevoked { get; set; }
        public Rarity rarity { get; set; }
    }
}