using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace InsightMailUI.Models
{
    public class ThreadSummary
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]  // ← this is the fix
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string ThreadId { get; set; } = "";
        public string ExecutiveSummaryText { get; set; } = "";
        public List<Decision> KeyDecisions { get; set; } = new();
        public List<OpenQuestion> OpenQuestions { get; set; } = new();
        public List<ThreadActionItem> ActionItems { get; set; } = new();
        public List<Participant> Participants { get; set; } = new();
        public List<TimelineEvent> Timeline { get; set; } = new();
        public DateTime GeneratedDate { get; set; }
        public int OriginalEmailCount { get; set; }
        public int ChunkCount { get; set; }
        public decimal ConfidenceScore { get; set; }
        public string ThreadSubject { get; set; } = "";
        public List<string> EmailIds { get; set; } = new();
    }

    public class Decision
    {
        public string DecisionText { get; set; } = "";
        public string? DecidedBy { get; set; }
        public string? Date { get; set; }
        public string? Conditions { get; set; }
    }

    public class OpenQuestion
    {
        public string Question { get; set; } = "";
        public string? RaisedBy { get; set; }
        public string? Importance { get; set; }
        public string? Status { get; set; }
    }

    public class ThreadActionItem
    {
        public string Task { get; set; } = "";
        public string? AssignedTo { get; set; }
        public string? Deadline { get; set; }
        public string Priority { get; set; } = "Medium";
    }

    public class Participant
    {
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Role { get; set; } = "";
        public string Position { get; set; } = "";
        public string KeyContributions { get; set; } = "";
    }

    public class TimelineEvent
    {
        public string Date { get; set; } = "";
        public string Event { get; set; } = "";
        public string Significance { get; set; } = "";
    }

    public class SummaryAnalytics
    {
        public int TotalSummariesGenerated { get; set; }
        public int AverageThreadLength { get; set; }
        public int AverageProcessingTimeSeconds { get; set; }
        public decimal AverageConfidenceScore { get; set; }
    }
}