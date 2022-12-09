using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsOperation.Tests
{
    public class HorseStepsTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test0()
        {
            Assert.AreEqual(Bitboard.HorseSteps(0).GetHashCode(), (2, 132096).GetHashCode());
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual(Bitboard.HorseSteps(1).GetHashCode(), (3, 329728).GetHashCode());
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(Bitboard.HorseSteps(2).GetHashCode(), (4, 659712).GetHashCode());
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(Bitboard.HorseSteps(36).GetHashCode(), (8, 11333767002587136).GetHashCode());
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(Bitboard.HorseSteps(47).GetHashCode(), (4, 4620693356194824192).GetHashCode());
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual(Bitboard.HorseSteps(48).GetHashCode(), (3, 288234782788157440).GetHashCode());
        }
        [Test]
        public void Test6()
        {
            Assert.AreEqual(Bitboard.HorseSteps(54).GetHashCode(), (4, 1152939783987658752).GetHashCode());
        }
        [Test]
        public void Test7()
        {
            Assert.AreEqual(Bitboard.HorseSteps(55).GetHashCode(), (3, 2305878468463689728).GetHashCode());
        }
        [Test]
        public void Test8()
        {
            Assert.AreEqual(Bitboard.HorseSteps(56).GetHashCode(), (2, 1128098930098176).GetHashCode());
        }
        [Test]
        public void Test9()
        {
            Assert.AreEqual(Bitboard.HorseSteps(63).GetHashCode(), (2, 9077567998918656).GetHashCode());
        }
    }
}
