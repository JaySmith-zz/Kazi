using System.Collections.Generic;

namespace Kazi.Core
{
    public class UserRole
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Permission> Permissions { get; set; }
    }
}
