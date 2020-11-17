using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TenerifeApp.Test
{
    public class Exercise2_Test
    {
        [Test]
        public void Test_RoundsInCasino_1()
        {
            var numTest = new Exercise2();
            var result = numTest.RoundsInCasino(8,0);
            Assert.AreEqual(7, result);
        }

        [Test]
        public void Test_RoundsInCasino_2()
        {
            var numTest = new Exercise2();
            var result = numTest.RoundsInCasino(10, 10);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test_RoundsInCasino_3()
        {
            var numTest = new Exercise2();
            var result = numTest.RoundsInCasino(20, 5);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Test_RoundsInCasino_4()
        {
            var numTest = new Exercise2();
            var result = numTest.RoundsInCasino(20, 2);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Test_RoundsInCasino_5()
        {
            var numTest = new Exercise2();
            var result = numTest.RoundsInCasino(21, 6);
            Assert.AreEqual(6, result);
        }

        //TESTEANDO AL FLACO
        [Test]
        public void Test_MinimumRoundsInCasino_1()
        {
            var numTest = new Exercise2();
            var result = numTest.MinimumRoundsInCasino(8, 0);
            Assert.AreEqual(7, result);
        }

        [Test]
        public void Test_MinimumRoundsInCasino_2()
        {
            var numTest = new Exercise2();
            var result = numTest.MinimumRoundsInCasino(10, 10);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test_MinimumRoundsInCasino_3()
        {
            var numTest = new Exercise2();
            var result = numTest.RoundsInCasino(20, 5);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Test_MinimumRoundsInCasino_4()
        {
            var numTest = new Exercise2();
            var result = numTest.RoundsInCasino(20, 2);
            Assert.AreEqual(6, result);
        }


        [Test]
        public void Test_MinimumRoundsInCasino_5()
        {
            var numTest = new Exercise2();
            var result = numTest.RoundsInCasino(21, 6);
            Assert.AreEqual(6, result);
        }

        //TESTEANDO AL JIMMY

    }
}
