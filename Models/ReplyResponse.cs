// Models/ReplyResponse.cs
namespace InsightMailUI.Models
{
    public class ReplyResponse
    {
        public string EmailId { get; set; } = "";
        public DateTime GeneratedAt { get; set; }
        public List<EmailReply> Replies { get; set; } = new();
    }

    public class EmailReply
    {
        public string Type { get; set; } = "";
        public string Subject { get; set; } = "";
        public string Body { get; set; } = "";
        public string Tone { get; set; } = "";
        public double Confidence { get; set; }
    }
}