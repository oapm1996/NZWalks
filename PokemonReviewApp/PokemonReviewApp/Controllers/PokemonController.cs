using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Interfaces;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _PokemonRepository;
        public PokemonController(IPokemonRepository PokemonRepository)
        {
            _PokemonRepository = PokemonRepository;
        }
        [HttpGet]
        [ProducesResponseType(200, type = typeof(IEnumerable<Pokemon>))]
    }
}
