using System.Text.Json;

namespace JokeApi
{
    public class JokeService
    {

        private Joke[]? _jokeList = null;

        private Joke[] JokeList { get
            {
                if (_jokeList == null)
                {
                    var json = File.ReadAllText("jokes.json");
                    _jokeList = JsonSerializer.Deserialize<Joke[]>(json);
                    _jokeList = _jokeList!.Where(f => f.question != null).ToArray();
                }
                return _jokeList!;
            } }

        public Joke GetRandomJoke()
        {
            var index = new Random().Next(JokeList.Length);
            return JokeList[index];
        }
    }
}
