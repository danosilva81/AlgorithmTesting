using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TenerifeApp.Test
{
    public class Exercise3_Test
    {
        [Test]
        public void Test_AmountConsecutivesMultiplied_1()
        {
            var numTest = new Exercise3();
            var result = numTest.AmountConsecutivesMultiplied(6, 20);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Test_AmountConsecutivesMultiplied_2()
        {
            var numTest = new Exercise3();
            var result = numTest.AmountConsecutivesMultiplied(21, 29);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test_AmountConsecutivesMultiplied_3()
        {
            var numTest = new Exercise3();
            var result = numTest.AmountConsecutivesMultiplied(6, 29);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Test_AmountConsecutivesMultiplied_4()
        {
            var numTest = new Exercise3();
            var result = numTest.AmountConsecutivesMultiplied(6, 30);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test_AmountConsecutivesMultiplied_5()
        {
            var numTest = new Exercise3();
            var result = numTest.AmountConsecutivesMultiplied(6, 32);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test_AmountConsecutivesMultiplied_6()
        {
            var numTest = new Exercise3();
            var result = numTest.AmountConsecutivesMultiplied(11130, 11775);
            Assert.AreEqual(4, result);
        }
    }
}
