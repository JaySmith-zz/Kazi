using System.Collections.Generic;

namespace Kazi.Core
{
    public class Epic
    {
        public Epic()
        {
            Features = new List<Feature>();
            UserStories = new List<UserStory>();
            Bugs = new List<Bug>();
            Impediments = new List<Impediment>();
            Tasks = new List<Task>();
        }

        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string AcceptanceCriteria { get; set; }
        public string State { get; set; }
        public int Priority { get; set; }
        public int Estimate { get; set; }
        public string BusinessValue { get; set; }
        public string ValueArea { get; set; }

        public string Area { get; set; }
        public string Iteration { get; set; }

        public List<Feature> Features { get; set; }
        public List<UserStory> UserStories { get; set; }
        public List<Bug> Bugs { get; set; }
        public List<Impediment> Impediments { get; set; }
        public List<Task> Tasks { get; set; }
        //public List<TestCase> TestCases { get; set; }

        public User AssignedTo { get; set; }
    }
}
