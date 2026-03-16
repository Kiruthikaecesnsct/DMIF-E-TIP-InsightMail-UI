namespace InsightMailUI.Models
{
    public class ActionItem
    {
        public string Id { get; set; } = "";
        public string EmailId { get; set; } = "";

        public string Description { get; set; } = "";
        public string AssignedTo { get; set; } = "";

        public DateTime? DueDate { get; set; }

        public Priority Priority { get; set; }

        public double ConfidenceScore { get; set; }

        public DateTime ExtractedDate { get; set; }

        public ActionItemStatus Status { get; set; }

        public string? ConfirmedBy { get; set; }
        public DateTime? ConfirmedDate { get; set; }
        public DateTime? CompletedDate { get; set; }

        public string? UserNotes { get; set; }
    }

    public enum Priority
    {
        Low = 1,
        Medium = 2,
        High = 3
    }

    public enum ActionItemStatus
    {
        Extracted,
        Confirmed,
        InProgress,
        Completed,
        Dismissed
    }
}