using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsOperation.Tests
{
    public class QueenStepsTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test0()
        {
            Assert.AreEqual(Bitboard.QueenSteps(0).GetHashCode(), (21, 9313761861428380670).GetHashCode());
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual(Bitboard.QueenSteps(1).GetHashCode(), (21, 180779649147209725).GetHashCode());
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(Bitboard.QueenSteps(2).GetHashCode(), (21, 289501704256556795).GetHashCode());
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(Bitboard.QueenSteps(36).GetHashCode(), (27, 10544115227674579473).GetHashCode());
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(Bitboard.QueenSteps(47).GetHashCode(), (21, 11583398706901190788).GetHashCode());
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual(Bitboard.QueenSteps(48).GetHashCode(), (21, 287670746360127809).GetHashCode());
        }
        [Test]
        public void Test6()
        {
            Assert.AreEqual(Bitboard.QueenSteps(54).GetHashCode(), (23, 16194909420462031425).GetHashCode());
        }
        [Test]
        public void Test7()
        {
            Assert.AreEqual(Bitboard.QueenSteps(55).GetHashCode(), (21, 13871017173176583298).GetHashCode());
        }
        [Test]
        public void Test8()
        {
            Assert.AreEqual(Bitboard.QueenSteps(56).GetHashCode(), (21, 18303478847064064385).GetHashCode());
        }
        [Test]
        public void Test9()
        {
            Assert.AreEqual(Bitboard.QueenSteps(63).GetHashCode(), (21, 9205534180971414145).GetHashCode());
        }

    }
}
