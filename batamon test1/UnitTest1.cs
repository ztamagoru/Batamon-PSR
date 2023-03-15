using batamon;

namespace batamon_test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            // test inicial para ver si el TDD anda

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
        public void Ejemplo1()
        {
            // ejemplo citado en la consigna del trabajo

            var hechicera = new List<int>() { 8, 10, 5, 23, 10, 10, 2 };
            var rival = new List<int>() { 5, 4, 13, 72, 12, 5, 10 };
            var resultado = Batamon1.batamon(hechicera, rival);
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void Test4()
        {
            // caso de prueba inspirado en el ejemplo 1
            // generador de números aleatorios de google utilizado
            // numeros utilizados entre el 100 y el 1000

            var hechicera = new List<int>() { 821, 238, 505, 191, 194 };
            var rival = new List<int>() { 782, 760, 192, 177, 294 };
            var resultado = Batamon1.batamon(hechicera, rival);
            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void Test5()
        {
            // caso de prueba inspirado en el ejemplo 1
            // generador de números aleatorios de google utilizado
            // numeros utilizados entre el 1000 y el 10000

            var hechicera = new List<int>() { 5165, 6286, 4444, 4591, 1327 };
            var rival = new List<int>() { 9089, 4646, 2694, 1914, 5895 };
            var resultado = Batamon1.batamon(hechicera, rival);
            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void Test6()
        {
            // caso de prueba inspirado en el ejemplo 1
            // generador de números aleatorios de google utilizado
            // numeros utilizados entre el 10000 y el 1000000

            var hechicera = new List<int>() { 675089, 274554, 356340, 143533, 88232 };
            var rival = new List<int>() { 624495, 504681, 396814, 551723, 791476 };
            var resultado = Batamon1.batamon(hechicera, rival);
            Assert.AreEqual(1, resultado);
        }
    }
}