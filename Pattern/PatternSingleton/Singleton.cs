using System;

namespace PatternSingleton
{
    public class Singleton
    {
        private static readonly Lazy<Singleton> _instance = 
                                new Lazy<Singleton>(() => new Singleton());

        public string Name { get; set; }

        public DateTime Date { get; set; }

        private Singleton()
        {
            Name = "Pattern Singleto";
            Date = DateTime.Now;
        }

        public static Singleton Instance
        {
            get => _instance.Value;
        }
    }
}
