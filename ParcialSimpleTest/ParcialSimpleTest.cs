using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculadoraBasica;


namespace ParcialSimpleTest
{
    [TestClass]
    public class ParcialSimpleTest
    {
        [TestMethod]
        public void EjercicioUno()
        {
            Calculadora cal = new Calculadora();
            int resultado = cal.Sumar(2, 2);
            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void EjercicioDos()
        {
            Calculadora cal = new Calculadora();
            int resultado = cal.SumarCaracteres("1", "2");
            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void EjercicioTres()
        {
            Calculadora cal = new Calculadora();
            int resultado = cal.SumarCaracteresB("", "");
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void EjercicioCuatro()
        {
            Calculadora cal = new Calculadora();
            int resultado = cal.Restar(3, 2);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void EjercicioCinco()
        {
            Calculadora cal = new Calculadora();
            int resultado = cal.Sumar(2, 2);
            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void EjercicioSeis()
        {
            Calculadora cal = new Calculadora();
            int resultado = cal.MultiplicarB("", 2);
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void EjercicioSiete()
        {
            Calculadora cal = new Calculadora();
            int resultado = cal.RaizCuadrada(3, 1/2);
            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void EjercicioOcho()
        {
            Calculadora cal = new Calculadora();
            double resultado = cal.Potencia(10, 2);
            Assert.AreEqual(100, resultado);
        }

        [TestMethod]
        public void EjercicioNueve()
        {
            Calculadora cal = new Calculadora();
            int resultado = cal.Dividir(16, 2);
            Assert.AreEqual(8, resultado);
        }

        [TestMethod]
        public void EjercicioDiez()
        {
            Calculadora cal = new Calculadora();
            double resultado = cal.DividirB(5,2);
            Assert.AreEqual(2, resultado);
        }

        [TestMethod]
        public void EjercicioOnce()
        {
            Calculadora cal = new Calculadora();
            int resultado = cal.DividirC(5, 2);
            Assert.AreEqual(1, resultado);
        }
    }
}

