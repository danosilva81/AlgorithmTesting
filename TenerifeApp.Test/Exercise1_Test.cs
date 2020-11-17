using NUnit.Framework;

namespace TenerifeApp.Test
{
    public class Exercise1_Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_FrontBackNumbers1_1()
        {
            var numTest = new Exercise1();
            var result = numTest.FrontBackNumbers_Solution1(123456789);
            Assert.AreEqual(192837465, result);
        }

        [Test]
        public void Test_FrontBackNumbers1_2()
        {
            var numTest = new Exercise1();
            var result = numTest.FrontBackNumbers_Solution1(1234567890);
            Assert.AreEqual(1029384756, result);
        }

        [Test]
        public void Test_FrontBackNumbers2_1()
        {
            var numTest = new Exercise1();
            var result = numTest.FrontBackNumbers_Solution2(123456789);
            Assert.AreEqual(192837465, result);
        }

        [Test]
        public void Test_FrontBackNumbers2_2()
        {
            var numTest = new Exercise1();
            var result = numTest.FrontBackNumbers_Solution2(1234567890);
            Assert.AreEqual(1029384756, result);
        }

        [Test]
        public void Test_FrontBackNumbers2_3()
        {
            var numTest = new Exercise1();
            var result = numTest.FrontBackNumbers_Solution2(1234);
            Assert.AreEqual(1423, result);
        }

        [Test]
        public void Test_FrontBackNumerRecursive_1()
        {
            var numTest = new Exercise1();
            var result = numTest.FrontBackNumbers_Recursive(123456);
            Assert.AreEqual(162534, result);
        }

        [Test]
        public void Test_FrontBackNumerRecursive_2()
        {
            var numTest = new Exercise1();
            var result = numTest.FrontBackNumbers_Recursive(1234567890);
            Assert.AreEqual(1029384756, result);
        }

        [Test]
        public void Test_FrontBackNumerRecursive_3()
        {
            var numTest = new Exercise1();
            var result = numTest.FrontBackNumbers_Recursive(123456789);
            Assert.AreEqual(192837465, result);
        }
    }
}