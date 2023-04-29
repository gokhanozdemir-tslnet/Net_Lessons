namespace Lesson004_Configuration.Configuration
{
    public interface IRoundTheCodeSync
    {
        string Title { get; set; }

        TimeSpan Interval { get; set; }

        int ConcurrentThreads { get; set; }
    }

    public class RoundTheCodeSync : IRoundTheCodeSync
    {
        public string? Title { get; set; }

        public TimeSpan Interval { get; set; }

        public int ConcurrentThreads { get; set; }
    }
}
