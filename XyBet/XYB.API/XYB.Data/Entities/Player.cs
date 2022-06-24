using System.Collections.Generic;

namespace XYB.Data.Entities
{
    public class Player
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NickName { get; set; }

        public Team CurrentTeam { get; set; }

        public string PhotoUrl { get; set; }

        public string Description { get; set; }

        public int Age { get; set; }

        public ICollection<Team> PreviousTeams { get; set; }
    }
}