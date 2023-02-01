using FeedApi.ProxyClases.Person;
using FeedApi.Service.PersoneService;
using FeedApi.Data;
using FeedApi.Service.RickAndMortyService.Model;

namespace FeedApi.BLL.Persone
{
    public class GetPersone
    {
        public async Task<GetPersoneResp> GetPerson(string name, RickAndMortyService service)
        {
            GetPersoneResp? getPersoneResp;
            GetAllCharacter? allPersons;
            AllLocation? allLocations;
            CharacterModel? person;
            Location? location;
            PersonOrigin personOrigin = null;

            getPersoneResp = await service.CheckGetPersonResp(name);

            if (getPersoneResp != default)
            {
                return getPersoneResp;
            }

            allPersons = await service.GetAllPersone();
            allLocations = await service.GetAllLocations();

            person = allPersons.Results.FirstOrDefault(x => x.Name == name);

            if (person != default)
            {
                location = allLocations.Results.FirstOrDefault(x => x.Name == person.Origin.Name);

                if (location != default)
                {
                    personOrigin = new PersonOrigin()
                    {
                        Name = location.Name,
                        Type = location.Type,
                        Demension = location.Dimension
                    };
                }
                else
                {
                    personOrigin = new PersonOrigin()
                    {
                        Name = "unknown",
                        Type = "",
                        Demension = "" 
                    };
                }
                getPersoneResp = new GetPersoneResp()
                {
                    Name = person.Name,
                    Status = person.Status,
                    Species = person.Species,
                    Type = person.Type,
                    Gender = person.Gender,
                    Origin = personOrigin
                };

                await service.SetGetPersonResp(new GetPersonRequest() { PersoneName = name, PersoneResp = getPersoneResp });
            }

            return getPersoneResp;
        }
    }
}
