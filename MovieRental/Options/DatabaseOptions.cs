namespace MovieRental.Options
{
    public class DatabaseOptions
    {
        public int MaxRetryCount { get; set; }
        public int TimeOut { get; set; }

        public bool EnableDetailsError { get; set; }
        public bool  EnableSensetiveDataLogger { get; set; }
    }
}
