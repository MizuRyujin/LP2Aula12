using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPrototypes
{
    public class World
    {
        private int _coolness;
        private float[] _scores;

        public World(int coolness, float[] scores)
        {
            _coolness = coolness;
            _scores = scores;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"{_coolness} ");
            foreach (float sc in _scores)
            {
                sb.Append($" {sc:f2} ");
            }

            return sb.ToString();
        }

        public void IncScore()
        {
            _coolness++;
            for (int i = 0; i < _scores.Length; i++)
            {
                _scores[i] += 1;
            }
        }

        public World ShallowCopy()
        {
            return (World) MemberwiseClone();
        }

        public World DeepCopy()
        {
            World other = (World)MemberwiseClone();
            other._scores = (float[])_scores.Clone();
            return other;
        }
    }
}
