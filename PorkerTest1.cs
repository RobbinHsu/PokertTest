using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using ExpectedObjects;
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

        [Test]
        public void First_group_is_different_other_group()
        {
            CompareGroup(0, 1, 2, 3);
        }

        [Test]
        public void Second_group_is_different_other_group()
        {
            CompareGroup(1, 0, 2, 3);
        }

        [Test]
        public void Third_group_is_different_other_group()
        {
            CompareGroup(2, 0, 1, 3);
        }

        [Test]
        public void Fourth_group_is_different_other_group()
        {
            CompareGroup(3, 0, 1, 2);
        }

        private void CompareGroup(int firstGroup, int secondGroup, int thirdGroup, int fourthGroup)
        {
            _actual[firstGroup].ToExpectedObject().ShouldNotEqual(_actual[secondGroup]);
            _actual[firstGroup].ToExpectedObject().ShouldNotMatch(_actual[thirdGroup]);
            _actual[firstGroup].ToExpectedObject().ShouldNotMatch(_actual[fourthGroup]);
        }
    }
}