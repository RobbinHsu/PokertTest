using System.Collections.Generic;

namespace PokerTest
{
    public class Poker
    {
        public Dictionary<int, List<int>> Licensing()
        {
            var dictionary = new Dictionary<int, List<int>>()
            {
                {1, new List<int>()},
                {2, new List<int>()},
                {3, new List<int>()},
                {4, new List<int>()},
            };
            return dictionary;
        }
    }
}