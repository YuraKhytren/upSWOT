using FeedApi.Data;
using FeedApi.ProxyClases.Person;
using FeedApi.Service.RickAndMortyService.Model;
using Newtonsoft.Json;

namespace FeedApi.Service.PersoneService
{
    public class RickAndMortyService
    {
        private readonly string _personeURL = @"https://rickandmortyapi.com/api/character";
        private readonly string _episodeURL = @"https://rickandmortyapi.com/api/episode";
        private readonly string _locationURL = @"https://rickandmortyapi.com/api/location";
        private readonly string _CheckPersonejsonPath = @".\Data\CheckPerson.json";
        private readonly string _GetPersonjsonPath = @".\Data\GetPerson.json";

        public async Task<GetAllCharacter> GetAllPersone()
        {
            GetAllCharacter getAllCharacter = new GetAllCharacter();
            string resp = string.Empty;

            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(_personeURL);
                response.EnsureSuccessStatusCode();

                resp = await response.Content.ReadAsStringAsync();
            }

            getAllCharacter = JsonConvert.DeserializeObject<GetAllCharacter>(resp);

            return getAllCharacter;
        }

        public async Task<GetAllEpisode> GetAllEpisode()
        {
            GetAllEpisode getAllEpisode = new GetAllEpisode();
            string resp = string.Empty;

            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(_episodeURL);
                response.EnsureSuccessStatusCode();

                resp = await response.Content.ReadAsStringAsync();
            }

            getAllEpisode = JsonConvert.DeserializeObject<GetAllEpisode>(resp);

            return getAllEpisode;
        }

        public async Task<AllLocation> GetAllLocations()
        {
            AllLocation allLocation = new AllLocation();
            string resp = string.Empty;

            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(_locationURL);
                response.EnsureSuccessStatusCode();

                resp = await response.Content.ReadAsStringAsync();
            }

            allLocation = JsonConvert.DeserializeObject<AllLocation>(resp);

            return allLocation;
        }

        public async Task SetCheckPersoneResp(CheckPersonRequest req)
        {
            string jsonText;
            List<CheckPersonRequest> list;
            string updateJson;

            jsonText = File.ReadAllText(_CheckPersonejsonPath);

            list = JsonConvert.DeserializeObject<List<CheckPersonRequest>>(jsonText) ?? new List<CheckPersonRequest>();
            list.Add(req);

            updateJson = JsonConvert.SerializeObject(list, Formatting.Indented);

            File.WriteAllText(_CheckPersonejsonPath, updateJson);
        }

        public async Task SetGetPersonResp(GetPersonRequest req)
        {
            string jsonText;
            List<GetPersonRequest> list;
            string updateJson;

            jsonText = File.ReadAllText(_GetPersonjsonPath);

            list = JsonConvert.DeserializeObject<List<GetPersonRequest>>(jsonText) ?? new List<GetPersonRequest>();
            list.Add(req);

            updateJson = JsonConvert.SerializeObject(list, Formatting.Indented);

            File.WriteAllText(_GetPersonjsonPath, updateJson);
        }

        public async Task<CheckPersoneResp?> CheckPersoneResp(CheckPersoneReq req)
        {
            string jsonText;
            List<CheckPersonRequest> list;
            string updateJson;
            CheckPersonRequest response;

            jsonText = File.ReadAllText(_CheckPersonejsonPath);

            list = JsonConvert.DeserializeObject<List<CheckPersonRequest>>(jsonText) ?? new List<CheckPersonRequest>();

            response = list.FirstOrDefault(x => x.PersoneName == req.PersoneName && x.EpisodeName == req.EpisodeName);

            if (response != default)
            {
                return response.CheckPersoneResp;
            }

            return default;
        }

        public async Task<GetPersoneResp?> CheckGetPersonResp(string name)
        {
            string jsonText;
            List<GetPersonRequest> list;
            string updateJson;
            GetPersonRequest response;

            jsonText = File.ReadAllText(_GetPersonjsonPath);

            list = JsonConvert.DeserializeObject<List<GetPersonRequest>>(jsonText) ?? new List<GetPersonRequest>();

            response = list.FirstOrDefault(x => x.PersoneName == name);

            if (response != default)
            {
                return response.PersoneResp;
            }

            return default;
        }
    }
}

