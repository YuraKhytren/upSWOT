using FeedApi.ProxyClases.Person;

namespace FeedApi.Data
{
    public class CheckPersonRequest
    {
        public string PersoneName { get; set; }
        public string EpisodeName { get; set; }
        public CheckPersoneResp CheckPersoneResp { get; set; }
    }
}
