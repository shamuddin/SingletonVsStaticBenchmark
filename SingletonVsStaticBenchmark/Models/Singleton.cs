namespace SingletonVsStaticBenchmark.Models
{
    public class Singleton
    {
        private static Singleton? _instance;
        private static readonly object _lock = new();

        // Private constructor to prevent instantiation
        private Singleton() { }

        // Singleton instance with thread safety
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }

        // Sample method for testing
        public int GetRandomValue() => new Random().Next();
    }
}
