using NUnit.Framework;

namespace TenerifeApp.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_FrontBackNumbers1_1()
        {
            var numTest = new NumericSolution();
            var result = numTest.FrontBackNumbers1(123456789);
            Assert.AreEqual(192837465, result);
        }

        [Test]
        public void Test_FrontBackNumbers1_2()
        {
            var numTest = new NumericSolution();
            var result = numTest.FrontBackNumbers1(1234567890);
            Assert.AreEqual(1029384756, result);
        }

        [Test]
        public void Test_FrontBackNumbers2_1()
        {
            var numTest = new NumericSolution();
            var result = numTest.FrontBackNumbers2(123456789);
            Assert.AreEqual(192837465, result);
        }

        [Test]
        public void Test_FrontBackNumbers2_2()
        {
            var numTest = new NumericSolution();
            var result = numTest.FrontBackNumbers2(1234567890);
            Assert.AreEqual(1029384756, result);
        }

        [Test]
        public void Test_FrontBackNumbers2_3()
        {
            var numTest = new NumericSolution();
            var result = numTest.FrontBackNumbers2(1234);
            Assert.AreEqual(1423, result);
        }
    }
}