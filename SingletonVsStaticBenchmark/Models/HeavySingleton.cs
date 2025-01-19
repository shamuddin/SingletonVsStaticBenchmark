namespace SingletonVsStaticBenchmark.Models
{
    public class HeavySingleton
    {
        private static HeavySingleton? _instance;
        private static readonly object _lock = new();

        private HeavySingleton()
        {
            // Simulate heavy initialization
            Thread.Sleep(100); // Simulates I/O or resource allocation
            Data = new int[1_000_000];
            for (int i = 0; i < Data.Length; i++) Data[i] = i;
        }

        public int[] Data { get; }

        public static HeavySingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new HeavySingleton();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
