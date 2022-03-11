namespace JokeApi
{
    public class Joke
    {
        public string? question { get; set; }
        public string? answer { get; set; }
        public string? text { get; set; }
        public string? author { get; set; }
        public string? created { get; set; }
        public string[]? tags { get; set; }
        public int rating { get; set; }

    }
}
