using System.Collections.Generic;

namespace Kazi.Core
{
    public class Impediment
    {
        public Impediment()
        {
            Tasks = new List<Task>();
        }

        public int Id { get; set; }

        public Epic Epic { get; set; }
        public Feature Feature { get; set; }
        public UserStory UserStory { get; set; }
        public Bug BugParent { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Resolution { get; set; }
        public string State { get; set; }
        public int Priority { get; set; }

        public string Area { get; set; }
        public string Iteration { get; set; }

        public List<Task> Tasks { get; set; }

        public User AssignedTo { get; set; }
    }
}