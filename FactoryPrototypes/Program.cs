using System;

namespace FactoryPrototypes
{
    class Program
    {
        static void Main()
        {
            World newWorld = new World(1, new float[] { 2.3f, 5.25f});
            World newNewWorld = newWorld.ShallowCopy();
            World newNewNewWorld = newWorld.DeepCopy();

            newWorld.IncScore();

            Console.WriteLine(
                newWorld + "\n" + newNewWorld + "\n" + newNewNewWorld);

        }
    }
}
