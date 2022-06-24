using System.Collections.Generic;

namespace XYB.Data.Entities
{
    public class Game
    {
        public int Id { get; set; }

        public string PhotoUrl { get; set; }

        public string Name { get; set; }

        public ICollection<Team> Teams { get; set; }

        public ICollection<GameMatch> GameMatches { get; set; }
    }
}