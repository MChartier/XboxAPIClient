using System.Collections.Generic;

namespace XboxAPIClient.Models.V2
{
    public class Groupproperties
    {
        public int Ordinal { get; set; }
        public string SortOrder { get; set; }
        public string DisplayName { get; set; }
    }

    public class Properties
    {
        public string DisplayName { get; set; }
    }

    public class Stat
    {
        public Groupproperties groupproperties { get; set; }
        public object xuid { get; set; }
        public string scid { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class Statlistscollection
    {
        public string arrangebyfield { get; set; }
        public long arrangebyfieldid { get; set; }
        public List<Stat> stats { get; set; }
    }

    public class Group
    {
        public string name { get; set; }
        public int titleid { get; set; }
        public List<Statlistscollection> statlistscollection { get; set; }
    }

    public class Stat2
    {
        public List<object> groupproperties { get; set; }
        public object xuid { get; set; }
        public string scid { get; set; }
        public int titleid { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public List<object> properties { get; set; }
    }

    public class Statlistscollection2
    {
        public string arrangebyfield { get; set; }
        public long arrangebyfieldid { get; set; }
        public List<Stat2> stats { get; set; }
    }

    public class GameStats
    {
        public List<Group> groups { get; set; }
        public List<Statlistscollection2> statlistscollection { get; set; }
    }
}