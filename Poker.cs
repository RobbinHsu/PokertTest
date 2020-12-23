using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerTest
{
    public class Poker
    {
        public Dictionary<int, List<int>> Licensing()
        {
            var rand = new Random();
            var list = Enumerable.Range(1, 53)
                .OrderBy(num => rand.Next())
                .ToList();

            var dictionary = new Dictionary<int, List<int>>()
            {
                {0, new List<int>(list.GetRange(0, 13))},
                {1, new List<int>(list.GetRange(13, 13))},
                {2, new List<int>(list.GetRange(26, 13))},
                {3, new List<int>(list.GetRange(39, 13))},
            };

            return dictionary;
        }
    }
}