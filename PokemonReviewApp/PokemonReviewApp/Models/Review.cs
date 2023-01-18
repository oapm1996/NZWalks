namespace PokemonReviewApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }

        public Reviewer Reviewer { get; set; } //No es ICollection porque una review solo puede tener un owner
        public Pokemon Pokemon { get; set; }
    }
}
