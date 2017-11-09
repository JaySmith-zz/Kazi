namespace Kazi.Core
{
    public class Task
    {
        public Epic Epic { get; set; }
        public Feature Feature { get; set; }
        public UserStory UserStory { get; set; }
        public Bug BugParent { get; set; }

        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public int Priority { get; set; }

        public string Area { get; set; }
        public string Iteration { get; set; }

        public bool Blocked { get; set; }
        public int RemainingWork { get; set; }

    }
}