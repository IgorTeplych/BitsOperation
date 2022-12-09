namespace BitsOperation.Tests
{
    public class KingStepsTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test0()
        {
            Assert.AreEqual(Bitboard.KingSteps(0).GetHashCode(), (3, 770).GetHashCode());
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual(Bitboard.KingSteps(1).GetHashCode(), (5, 1797).GetHashCode());
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(Bitboard.KingSteps(7).GetHashCode(), (3, 49216).GetHashCode());
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(Bitboard.KingSteps(8).GetHashCode(), (5, 197123).GetHashCode());
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(Bitboard.KingSteps(10).GetHashCode(), (8, 920078).GetHashCode());
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual(Bitboard.KingSteps(15).GetHashCode(), (5, 12599488).GetHashCode());
        }
        [Test]
        public void Test6()
        {
            Assert.AreEqual(Bitboard.KingSteps(54).GetHashCode(), (8, 16186183351374184448).GetHashCode());
        }
        [Test]
        public void Test7()
        {
            Assert.AreEqual(Bitboard.KingSteps(55).GetHashCode(), (5, 13853283560024178688).GetHashCode());
        }
        [Test]
        public void Test8()
        {
            Assert.AreEqual(Bitboard.KingSteps(56).GetHashCode(), (3, 144959613005987840).GetHashCode());
        }
        [Test]
        public void Test9()
        {
            Assert.AreEqual(Bitboard.KingSteps(63).GetHashCode(), (3, 4665729213955833856).GetHashCode());
        }

    }
}