namespace XboxAPIClient.Models.V2
{
    public class Gamercard
    {
        public string gamertag { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string bio { get; set; }
        public int gamerscore { get; set; }
        public string tier { get; set; }
        public string motto { get; set; }
        public string avatarBodyImagePath { get; set; }
        public string gamerpicSmallImagePath { get; set; }
        public string gamerpicLargeImagePath { get; set; }
        public string gamerpicSmallSslImagePath { get; set; }
        public string gamerpicLargeSslImagePath { get; set; }
        public string avatarManifest { get; set; }
    }
}