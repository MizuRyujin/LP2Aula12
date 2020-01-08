using System;

namespace LazySingleFloat
{
    class Program
    {
        static void Main(string[] args)
        {
            SetValue();
            PrintValue();
        }

        static void SetValue()
        {
            Singleton.Instance.FloatValue = 20;
        }

        static void PrintValue()
        {
            Console.WriteLine(Singleton.Instance.FloatValue);
        }
    }
}
