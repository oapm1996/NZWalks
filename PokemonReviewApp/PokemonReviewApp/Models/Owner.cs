namespace PokemonReviewApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gym { get; set; }
        public Country Country { get; set; } //No es una ICollection porque solo habra 1 country por Owner
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
    }
}
