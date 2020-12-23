using NUnit.Framework;

namespace PokerTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void All_card_in_four_group()
        {
            var poker = new Poker();
            var actual = poker.Licensing();
            Assert.AreEqual(4, actual.Count);
        }
    }
}