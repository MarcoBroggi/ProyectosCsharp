using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moneda;
using System.Collections.Generic;

namespace TestProjectConversiones
{
    [TestClass]
    public class Conversiones
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Peso p = new Peso(100);
            Dolar d = new Dolar(100);

            //Act
            p = (Peso)d;


            double resultado = 20100;

            //Assert
            Assert.AreEqual(resultado, p.Cantidad);
        }

        [TestMethod]
        [ExpectedException(typeof(ValorInvalidoException))]
        public void Test_ExceptionValorInvalido()
        {
            Dolar d = new Dolar(-6);

        }

        [TestMethod]

        public void Test_SonIguales()
        {
            Dolar d = new Dolar(9);
            List<Dolar> lista = new List<Dolar>();
            lista.Add(d);

            Assert.AreSame(d, lista[0]);
        }
    }
}
