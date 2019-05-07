using System;
using Imposto;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoftplayerCalcTest.Tests.Imposto
{
    [TestClass]
    public class CalculaTest
    {
        [TestMethod]
        public void CalcularJurosCompostos()
        {
            ICalcula imposto = new Calcula();

            decimal result = imposto.JurosCompostos(100.00M, 5);
            Assert.AreEqual(105.10M, result);
        }
    }
}
