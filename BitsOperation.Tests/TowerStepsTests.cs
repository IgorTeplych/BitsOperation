using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsOperation.Tests
{
    public class TowerStepsTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test0()
        {
            Assert.AreEqual(Bitboard.TowerSteps(0).GetHashCode(), (14, 72340172838076926).GetHashCode());
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual(Bitboard.TowerSteps(1).GetHashCode(), (14, 144680345676153597).GetHashCode());
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(Bitboard.TowerSteps(2).GetHashCode(), (14, 289360691352306939).GetHashCode());
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(Bitboard.TowerSteps(36).GetHashCode(), (14, 1157443723186933776).GetHashCode());
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(Bitboard.TowerSteps(47).GetHashCode(), (14, 9259541023762186368).GetHashCode());
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual(Bitboard.TowerSteps(48).GetHashCode(), (14, 143553341945872641).GetHashCode());
        }
        [Test]
        public void Test6()
        {
            Assert.AreEqual(Bitboard.TowerSteps(54).GetHashCode(), (14, 4665518383679160384).GetHashCode());
        }
        [Test]
        public void Test7()
        {
            Assert.AreEqual(Bitboard.TowerSteps(55).GetHashCode(), (14, 9259260648297103488).GetHashCode());
        }
        [Test]
        public void Test8()
        {
            Assert.AreEqual(Bitboard.TowerSteps(56).GetHashCode(), (14, 18302911464433844481).GetHashCode());
        }
        [Test]
        public void Test9()
        {
            Assert.AreEqual(Bitboard.TowerSteps(63).GetHashCode(), (14, 9187484529235886208).GetHashCode());
        }
    }
}
