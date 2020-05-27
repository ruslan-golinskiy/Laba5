using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = Rus_OOP_5._1.Doctor.Number();
            Assert.AreEqual(63, result);
        }
    }
}
