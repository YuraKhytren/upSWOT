namespace FeedApi.Service.RickAndMortyService.Model
{
    public class GetAllEpisode
    {
        public Info info { get; set; }
        public List<EpisodeModel> Results { get; set; }
    }

    public class EpisodeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Air_date { get; set; }
        public string Episode { get; set; }
        public string[] characters { get; set; }
        public string Url { get; set; }
        public string Created { get; set; }
    }
}
