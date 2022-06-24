using System.Collections.Generic;

namespace XYB.Data.Entities
{
    public class Team
    {
        public string LogoPhotoUrl { get; set; }

        public string Name { get; set; }

        public ICollection<Player> Players { get; set; }

        public ICollection<GameMatch> GameMatches { get; set; }

        public Game Game { get; set; }
    }
}