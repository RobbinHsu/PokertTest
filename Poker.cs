using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerTest
{
    public class Poker
    {
        private Dictionary<int, List<int>> _dictionary;
        private List<int> _list;
        private Random _rand;

        public Dictionary<int, List<int>> Licensing()
        {
            _rand = new Random();
            _list = Enumerable.Range(1, 53)
                .OrderBy(num => _rand.Next())
                .ToList();

            _dictionary = new Dictionary<int, List<int>>()
            {
                {0, GetSortGroup(0, 13)},
                {1, GetSortGroup(13, 13)},
                {2, GetSortGroup(26, 13)},
                {3, GetSortGroup(39, 13)},
            };

            return _dictionary;
        }

        private List<int> GetSortGroup(int index, int count)
        {
            var pokerGroup = new List<int>(_list.GetRange(index, count));
            pokerGroup.MySort();
            return pokerGroup;
        }
    }
}