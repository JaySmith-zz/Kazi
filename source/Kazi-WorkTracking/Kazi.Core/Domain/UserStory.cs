using System.Collections.Generic;

namespace Kazi.Core
{
    public class UserStory
    {
        public UserStory()
        {
            Bugs = new List<Bug>();
            Impediments = new List<Impediment>();
            Tasks = new List<Task>();
        }

        public Epic EpicParent { get; set; }
        public Feature FeatureParent { get; set; }

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

        public List<Bug> Bugs { get; set; }
        public List<Impediment> Impediments { get; set; }
        public List<Task> Tasks { get; set; }

        //public Feature ToFeature()
        //{
        //    return AutoMapper.Mapper.Map<Feature>(this);
        //}
    }
}