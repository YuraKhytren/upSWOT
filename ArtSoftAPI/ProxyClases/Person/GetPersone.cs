namespace FeedApi.ProxyClases.Person
{
    public class GetPersoneReq 
    {
        public string PersoneName { get; set; }
    }
    public class GetPersoneResp 
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public PersonOrigin Origin { get; set; }
    }

    public class PersonOrigin 
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Demension { get; set; }
    }
}
