using System.Collections.Generic;

namespace XboxAPIClient.Models.V2
{
    public class Xbox360Title
    {
        public string lastPlayed { get; set; }
        public int currentAchievements { get; set; }
        public int currentGamerscore { get; set; }
        public int sequence { get; set; }
        public int titleId { get; set; }
        public int titleType { get; set; }
        public List<int> platforms { get; set; }
        public string name { get; set; }
        public int totalAchievements { get; set; }
        public int totalGamerscore { get; set; }
    }

    public class Xbox360PagingInfo
    {
        public object continuationToken { get; set; }
        public int totalRecords { get; set; }
    }

    public class Xbox360Games
    {
        public List<Xbox360Title> titles { get; set; }
        public Xbox360PagingInfo pagingInfo { get; set; }
        public string version { get; set; }
    }
}