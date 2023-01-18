using PokemonReviewApp.Data;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class PokemonRepository
    {
        private readonly DataContext _context;

        //An repository is a way to get our database calls
        public PokemonRepository(DataContext context) //Constructor that recive the DataContext
        {
            _context = context;
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }
    }
}
