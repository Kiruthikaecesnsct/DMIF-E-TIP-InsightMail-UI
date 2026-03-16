namespace InsightMailUI.Models
{
    public class Email
    {
        public string Id { get; set; }

        public string Sender { get; set; }

        public List<string> Recipients { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public DateTime ReceivedDate { get; set; }

        public string Category { get; set; }

        public int? Priority { get; set; }

        public string ClassificationReasoning { get; set; }

        public double? ClassificationConfidence { get; set; }

        public DateTime? ClassifiedDate { get; set; }
        public List<string> ActionItemIds { get; set; } = new();
        public bool HasActionItems => ActionItemIds.Any();
    }
}