using System;
using System.Collections.Generic;

namespace Kazi.Core
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LastLogedIn { get; set; }
        public DateTime Created { get; set; }

        public List<Team> Teams { get; set; }

        public User AssignedTo { get; set; }

    }
}
