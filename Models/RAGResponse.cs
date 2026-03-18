

namespace InsightMailUI.Models
{
    public class RAGAnswer
    {
        public string Answer { get; set; }
        public List<Email> SourceEmails { get; set; } = new();
        public List<float?> RelevanceScores { get; set; } = new();
    }
}
