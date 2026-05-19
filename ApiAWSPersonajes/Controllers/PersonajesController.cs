using ApiAWSPersonajes.Models;
using ApiAWSPersonajes.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAWSPersonajes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonajesController : ControllerBase
    {
        private RepositoryTelevision repo;

        public PersonajesController(RepositoryTelevision repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Personaje>>> GetPersonajes()
        {
            return await this.repo.GetPersonajesAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Personaje personaje)
        {
            await this.repo.CreatePersonajeAsync(personaje.Nombre, personaje.Imagen);
            return Ok();
        }
    }
}
