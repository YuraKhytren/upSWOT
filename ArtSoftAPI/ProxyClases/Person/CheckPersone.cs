namespace FeedApi.ProxyClases.Person
{
    public class CheckPersoneReq { 
        public string PersoneName { get; set; }
        public string EpisodeName { get; set; }
    }
    public class CheckPersoneResp 
    {
        public bool? WasInEpisode { get; set; }
    }
}
