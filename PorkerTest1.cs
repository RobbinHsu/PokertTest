using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using ExpectedObjects;
using NUnit.Framework;

namespace PokerTest
{
    [TestFixture]
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
            WhenHaveFourGroup();
        }


        [Test]
        public void Different_results_every_time()
        {
            WhenEachResultIsDifferent();
        }

        [Test]
        public void Every_group_have_thirteen_cards()
        {
            WhenEveryGroupHaveThirteenCards();
        }

        [Test]
        public void First_group_is_different_other_group()
        {
            WhenDifferentWithOtherGroup(0, 1, 2, 3);
        }

        [Test]
        public void Fourth_group_is_different_other_group()
        {
            WhenDifferentWithOtherGroup(3, 0, 1, 2);
        }

        [Test]
        public void No_duplicate_number()
        {
            NoDuplicateNumberInGroup(0);
            NoDuplicateNumberInGroup(1);
            NoDuplicateNumberInGroup(2);
            NoDuplicateNumberInGroup(3);
        }

        [Test]
        public void Porker_number_between_1_53()
        {
            PorkerGroupBetween1_53(0);
            PorkerGroupBetween1_53(1);
            PorkerGroupBetween1_53(2);
            PorkerGroupBetween1_53(3);
        }

        [Test]
        public void Second_group_is_different_other_group()
        {
            WhenDifferentWithOtherGroup(1, 0, 2, 3);
        }

        [Test]
        public void Third_group_is_different_other_group()
        {
            WhenDifferentWithOtherGroup(2, 0, 1, 3);
        }

        private void NoDuplicateNumberInGroup(int index)
        {
            Assert.IsTrue(_actual[index]
                .GroupBy(num => num)
                .Any(grouping => grouping.Count() == 1));
        }


        private void PorkerGroupBetween1_53(int porkerGroupIndex)
        {
            Assert.IsTrue(_actual[porkerGroupIndex].Any(num => num > 0 && num < 53));
        }

        private void WhenEachResultIsDifferent()
        {
            _poker.Licensing().ToExpectedObject().ShouldNotEqual(_poker.Licensing());
        }

        private void WhenEveryGroupHaveThirteenCards()
        {
            Assert.AreEqual(13, _actual[0].Count);
            Assert.AreEqual(13, _actual[1].Count);
            Assert.AreEqual(13, _actual[2].Count);
            Assert.AreEqual(13, _actual[3].Count);
        }

        private void WhenHaveFourGroup()
        {
            Assert.AreEqual(4, _actual.Count);
        }


        private void WhenDifferentWithOtherGroup(int firstGroup, int secondGroup, int thirdGroup, int fourthGroup)
        {
            _actual[firstGroup].ToExpectedObject().ShouldNotEqual(_actual[secondGroup]);
            _actual[firstGroup].ToExpectedObject().ShouldNotEqual(_actual[thirdGroup]);
            _actual[firstGroup].ToExpectedObject().ShouldNotEqual(_actual[fourthGroup]);
        }
    }
}