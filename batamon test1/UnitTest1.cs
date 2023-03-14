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
            Assert.AreEqual(2, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test2()
        {
            // cantidad de monstruos diferente
            // excepcion esperada

            var hechicera = new List<int>() { 1, 2, 4 };
            var rival = new List<int>() { 1, 1 };
            var resultado = Batamon1.batamon(hechicera, rival);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test3()
        {
            // niveles fuera de rango
            // excepcion esperada

            var hechicera = new List<int>() { 0, 1 };
            var rival = new List<int>() { 1, 3000009 };
            var resultado = Batamon1.batamon(hechicera, rival);
        }

        [TestMethod]
        public void Ejemplo()
        {
            var hechicera = new List<int>() { 8, 10, 5, 23, 10, 10, 2 };
            var rival = new List<int>() { 5, 4, 13, 72, 12, 5, 10 };
            var resultado = Batamon1.batamon(hechicera, rival);
            Assert.AreEqual(5, resultado);
        }
    }
}