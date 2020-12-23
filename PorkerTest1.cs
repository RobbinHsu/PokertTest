using System.Collections.Generic;
using NUnit.Framework;

namespace PokerTest
{
    public class Tests
    {
        private Poker _poker;

        [SetUp]
        public void Setup()
        {
            _poker = new Poker();
        }

        [Test]
        public void All_card_in_four_group()
        {
            var actual = _poker.Licensing();
            Assert.AreEqual(4, actual.Count);
        }

        [Test]
        public void Every_group_have_thirteen_cards()
        {
            var actual = _poker.Licensing();

            Assert.AreEqual(13, actual[0].Count);
            Assert.AreEqual(13, actual[1].Count);
            Assert.AreEqual(13, actual[2].Count);
            Assert.AreEqual(13, actual[3].Count);
        }
    }
}