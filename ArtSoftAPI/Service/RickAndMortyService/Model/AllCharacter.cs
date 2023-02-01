namespace FeedApi.Service.RickAndMortyService.Model
{
    public class GetAllCharacter
    {
        public Info Info { get; set; }
        public List<CharacterModel>  Results { get; set; }
    }

    public class Info 
    { 
        public int Count { get; set; }
        public int Pages { get; set; }
        public string Next { get; set; }
        public string Prev { get; set; }
    }

    public class CharacterModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public Origin Origin { get; set; }
        public CharacterLocation Location { get; set; }
        public string Image { get; set; }
        public string[] Episode { get; set; }
        public string Url { get; set; }
        public string Created { get; set; }

    }
    public class Origin 
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
    public class CharacterLocation
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}


