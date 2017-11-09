using System.Collections.Generic;

namespace Kazi.Core
{
    public class Team
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public List<User> TeamMembers { get; set; }
    }
}
