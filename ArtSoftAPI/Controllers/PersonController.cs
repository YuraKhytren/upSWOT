using FeedApi.BLL.Persone;
using FeedApi.ProxyClases.Person;
using FeedApi.Service.PersoneService;
using Microsoft.AspNetCore.Mvc;

namespace ArtSoftAPI.Controllers
{
    /// <summary>
    /// Person Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly RickAndMortyService _service;

        public PersonController(RickAndMortyService service) 
        {
            _service = service;
        }
        /// <summary>
        /// Endpoint Checks if the actor was in this episode
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<bool>> CheckPersone(CheckPersoneReq request) 
        {
            var method = new CheckPersone();
            var response = await method.CheckPerson(request, _service);

            if (response.WasInEpisode == null)
            {
                return NotFound();
            }
            else if (response.WasInEpisode == true)
            {
                return Ok(true);
            }

            return Ok(false);
        }
        /// <summary>
        /// Endpoint Checks actor data
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<GetPersoneResp>> CheckPersone(string name)
        {
            var method = new GetPersone();
            var response = await method.GetPerson(name, _service);

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);    
        }
    }
}
