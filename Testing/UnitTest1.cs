using NUnit.Framework;
using NunitTesting;

namespace Testing
{
    public class Tests
    {
        private TestingMethods obj;
        [SetUp]
        public void Setup()
        {
            obj = new TestingMethods();
        }

        [Test]
        public void AddMethodShouldReturnInt()
        {
            //Arrange
            int a = 5;
            int b = 9;

            //Act
            int Result = obj.Add(a, b);

            //Assert
            Assert.AreEqual(14, Result);

        }

        [Test]
        public void IsEvenReturnsBoolValue()
        {
            //Arrange
            int n = 6;

            //Act
            bool Result1 = obj.IsEven(n);

            //Assert
            Assert.AreEqual(true, Result1);
        }

        [Test]
        public void GivenNumberIsPositive()
        {
            //Arrange
            int a = 6;

            //Act
            bool Res = obj.PosOrNeg(a);

            //Assert
            Assert.AreEqual(true, Res);

        }
        [Test]
        public void SumOfNaturalNumIsInt()
        {
            //Arrange
            int a = 7;
            //Act
            int sum = obj.SumOfNatNum(a);

            //Assert
            Assert.AreEqual(28, sum);
        }


    }
}