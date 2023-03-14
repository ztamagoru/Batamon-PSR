using batamon;

namespace batamon_test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            var hechicera = new List<int>() { 1, 1 };
            var rival = new List<int>() { 1, 1 };
            var resultado = Batamon1.batamon(hechicera, rival);
            Assert.AreEqual(0, resultado);
        }
    }
}