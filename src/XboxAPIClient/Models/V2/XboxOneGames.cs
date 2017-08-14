using System.Collections.Generic;

namespace XboxAPIClient.Models.V2
{
    public class XboxOneTitle
    {
        public string lastUnlock { get; set; }
        public int titleId { get; set; }
        public string serviceConfigId { get; set; }
        public string titleType { get; set; }
        public string platform { get; set; }
        public string name { get; set; }
        public int earnedAchievements { get; set; }
        public int currentGamerscore { get; set; }
        public int maxGamerscore { get; set; }
    }

    public class XboxOnePagingInfo
    {
        public object continuationToken { get; set; }
        public int totalRecords { get; set; }
    }

    public class XboxOneGames
    {
        public List<XboxOneTitle> titles { get; set; }
        public XboxOnePagingInfo pagingInfo { get; set; }
    }
}