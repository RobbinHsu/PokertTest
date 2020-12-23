using System.Collections.Generic;
using System.Linq;

namespace PokerTest
{
    public class Poker
    {
        public Dictionary<int, List<int>> Licensing()
        {
            var dictionary = new Dictionary<int, List<int>>()
            {
                {0, new List<int>(Enumerable.Range(1, 13))},
                {1, new List<int>(Enumerable.Range(1, 13))},
                {2, new List<int>(Enumerable.Range(1, 13))},
                {3, new List<int>(Enumerable.Range(1, 13))},
            };

            return dictionary;
        }
    }
}