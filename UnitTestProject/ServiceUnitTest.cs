using ConsoleUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ServiceUnitTest
    {
        IService s;
        public ServiceUnitTest()
        {
            s = new Service();
        }

        [TestMethod]
        public void Add_Test()
        {
            int actual = s.Add(5, 5);

            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        public void Add2_Test()
        {
            double actual = s.Add(5.8, 5.5);

            Assert.AreEqual(11.3, actual);
        }

        [TestMethod]
        public void Divided_Test()
        {
            double actual = s.Divided(10, 5);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void Divided2_Test()
        {
            double actual = s.Divided(10.8, 2);

            Assert.AreEqual(5.4, actual);
        }

        [TestMethod]
        public void Multiply_Test()
        {
            double actual = s.Multiply(8, 4);

            Assert.AreEqual(32, actual);
        }

        [TestMethod]
        public void Multiply2_Test()
        {
            double actual = s.Multiply(12.5, 3);

            Assert.AreEqual(37.5, actual);
        }

        [TestMethod]
        public void Subtract_Test()
        {
            int actual = s.Subtract(13, 5);

            Assert.AreEqual(8, actual);
        }

        [TestMethod]
        public void Subtract2_Test()
        {
            double actual = s.Subtract(13.8, 5.2);

            Assert.AreEqual((8.6).ToString(), actual.ToString());
        }
    }
}
