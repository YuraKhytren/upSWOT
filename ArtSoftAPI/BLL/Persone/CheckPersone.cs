using FeedApi.Data;
using FeedApi.ProxyClases.Person;
using FeedApi.Service.PersoneService;
using FeedApi.Service.RickAndMortyService.Model;

namespace FeedApi.BLL.Persone
{
    public class CheckPersone
    {
        public async Task<CheckPersoneResp> CheckPerson(CheckPersoneReq request, RickAndMortyService service)
        {
            CheckPersoneResp? response;
            GetAllCharacter? allPersons;
            GetAllEpisode? allEpisodes;
            CharacterModel? person;
            EpisodeModel? episode;
            string personEpisode;

            if (string.IsNullOrEmpty(request.EpisodeName) || string.IsNullOrEmpty(request.PersoneName))
            {
                return response = new CheckPersoneResp() { WasInEpisode = null };
            }

            response = await service.CheckPersoneResp(request);

            if (response != null)
            {
                return response;
            }

            allPersons = await service.GetAllPersone();
            allEpisodes = await service.GetAllEpisode();

            person = allPersons.Results.FirstOrDefault(x => x.Name == request.PersoneName);
            episode = allEpisodes.Results.FirstOrDefault(x => x.Name == request.EpisodeName);

            if (person == default || episode == default)
            {
                return response = new CheckPersoneResp() { WasInEpisode = null };
            }
            else
            {
                personEpisode = person.Episode.FirstOrDefault(x => x == episode.Url);

                if (personEpisode == default)
                {
                    response = new CheckPersoneResp() { WasInEpisode = false };
                }
                else
                {
                    response = new CheckPersoneResp() { WasInEpisode = true };
                }

                await service.SetCheckPersoneResp(new CheckPersonRequest() { PersoneName = request.PersoneName, EpisodeName = request.EpisodeName, CheckPersoneResp = response });
            }

            return response;
        }
    }
}
