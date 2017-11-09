using System.Collections.Generic;

namespace Kazi.Core
{
    public class Bug
    {
        public int Id { get; set; }

        public Epic Epic { get; set; }
        public Feature Feature { get; set; }
        public UserStory UserStory { get; set; }

        public string Title { get; set; }
        public string ReproSteps { get; set; }
        public string SystemInfo { get; set; }
        public string AcceptanceCriteria { get; set; }
        public string State { get; set; }
        public int Priority { get; set; }
        public int Estimate { get; set; }
        public string BusinessValue { get; set; }
        public string ValueArea { get; set; }

        public string Area { get; set; }
        public string Iteration { get; set; }

        public List<Impediment> Impediments { get; set; }
        public List<Task> Tasks { get; set; }

        public User AssignedTo { get; set; }

    }
}
