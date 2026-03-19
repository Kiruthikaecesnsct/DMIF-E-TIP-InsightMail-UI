namespace InsightMailUI.Models
{
    public class ReplyAnalyticsEntry
    {
        public string EmailId { get; set; } = "";
        public string SelectedType { get; set; } = "";
        public string OriginalBody { get; set; } = "";
        public string FinalBody { get; set; } = "";
        public string ToneUsed { get; set; } = "";
        public int MaxWordsUsed { get; set; }
    }

    public class AnalyticsSummary
    {
        public int TotalGenerated { get; set; }
        public int BriefSelected { get; set; }
        public int DetailedSelected { get; set; }
        public int DeclineSelected { get; set; }
        public double AverageEditDistance { get; set; }
        public string MostUsedTone { get; set; } = "";
    }
}