namespace PokemonReviewApp.Models
{
    public class Country
    {
        public int id { get; set; }
        public string Name { get; set; }

        public ICollection<Owner> Owners { get; set; } //ICollection porque 1 country puede tener muchos Owners
    }
}
