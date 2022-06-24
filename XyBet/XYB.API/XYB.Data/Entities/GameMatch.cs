using System;

namespace XYB.Data.Entities
{
    public class GameMatch
    {
        public DateTime Time { get; set; }

        public Team FirstTeam { get; set; }

        public Team SecondTeam { get; set; }

        public Game Game { get; set; }
    }
}