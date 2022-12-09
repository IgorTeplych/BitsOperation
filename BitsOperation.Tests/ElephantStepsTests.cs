using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsOperation.Tests
{
    public class ElephantStepsTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test0()
        {
            Assert.AreEqual(Bitboard.ElephantSteps(0).GetHashCode(), (7, 9241421688590303744).GetHashCode());
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual(Bitboard.ElephantSteps(1).GetHashCode(), (7, 36099303471056128).GetHashCode());
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(Bitboard.ElephantSteps(2).GetHashCode(), (7, 141012904249856).GetHashCode());
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(Bitboard.ElephantSteps(36).GetHashCode(), (13, 9386671504487645697).GetHashCode());
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(Bitboard.ElephantSteps(47).GetHashCode(), (7, 2323857683139004420).GetHashCode());
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual(Bitboard.ElephantSteps(48).GetHashCode(), (7, 144117404414255168).GetHashCode());
        }
        [Test]
        public void Test6()
        {
            Assert.AreEqual(Bitboard.ElephantSteps(54).GetHashCode(), (9, 11529391036782871041).GetHashCode());
        }
        [Test]
        public void Test7()
        {
            Assert.AreEqual(Bitboard.ElephantSteps(55).GetHashCode(), (7, 4611756524879479810).GetHashCode());
        }
        [Test]
        public void Test8()
        {
            Assert.AreEqual(Bitboard.ElephantSteps(56).GetHashCode(), (7, 567382630219904).GetHashCode());
        }
        [Test]
        public void Test9()
        {
            Assert.AreEqual(Bitboard.ElephantSteps(63).GetHashCode(), (7, 18049651735527937).GetHashCode());
        }
    }
}
