using System;

namespace LazySingleFloat
{
    public sealed class Singleton
    {
        private static Lazy<Singleton> instance =
            new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance => instance.Value;

        public float FloatValue { get; set; }

        private Singleton()
        { }

    }
}
