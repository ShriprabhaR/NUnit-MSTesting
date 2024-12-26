using Newtonsoft.Json.Bson;
using NunitTesting;

namespace MsTesting
{
    [TestClass]
    public sealed class Test1
    {
        TestingMethods test = null;

        [TestInitialize]

        public void SetUp()
        {
            test = new TestingMethods();
        }
        [TestCategory("Positive or Negetive")]
        [TestMethod]
        [DataRow(2, true)]
        [DataRow(-5, false)]
        [DataRow(7, true)]
        public void TestPosOrNeg(int data, bool expected)
        {
            //Act
            bool actual = test.PosOrNeg(data);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Sum of Natural Numbers")]
        [TestMethod]
        [DataRow(10, 55)]
        [DataRow(11, 66)]
        [DataRow(5, 15)]
        [DataRow(15, 120)]

        public void TestSumOfNaturalNum(int data, int expected)
        {
            //Act
            int actual = test.SumOfNatNum(data);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Number is Even or Odd")]
        [TestMethod]
        [DataRow(10, true)]
        [DataRow(11, false)]
        [DataRow(5, false)]
        [DataRow(16, true)]

        public void TestEvenOrOdd(int data, bool expected)
        {
            //Act
            bool actual = test.IsEven(data);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Adding two numbers")]
        [TestMethod]
        [DataRow(2, 8, 10)]
        [DataRow(3, 5, 8)]
        [DataRow(8, 7, 15)]

        public void TestSumOfTwoNum(int a,  int b, int expected)
        {
            //Act
            int actual = test.Add(a, b);

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
