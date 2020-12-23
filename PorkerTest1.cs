using System.Collections.Generic;
using NUnit.Framework;

namespace PokerTest
{
    public class Tests
    {
        private Dictionary<int, List<int>> _actual;
        private Poker _poker;

        [SetUp]
        public void Setup()
        {
            _poker = new Poker();
            _actual = _poker.Licensing();
        }

        [Test]
        public void All_card_in_four_group()
        {
            Assert.AreEqual(4, _actual.Count);
        }

        [Test]
        public void Every_group_have_thirteen_cards()
        {
            Assert.AreEqual(13, _actual[0].Count);
            Assert.AreEqual(13, _actual[1].Count);
            Assert.AreEqual(13, _actual[2].Count);
            Assert.AreEqual(13, _actual[3].Count);
        }
    }
}