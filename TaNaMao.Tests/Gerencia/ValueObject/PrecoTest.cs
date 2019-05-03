using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TanaMao.Domain.Gerencia.ValueObject;

namespace TaNaMao.Tests.Gerencia.ValueObject
{
    [TestClass]
    public class PrecoTest
    {
        [TestMethod]
        public void TestNegativeValor()
        {
            float valor1 = -50;
            string moeda1 = "R$";
            var Preco1 = new Preco(valor1, moeda1);
            Assert.IsFalse(Preco1.Valid);

        }

        [TestMethod]
        public void TestInvalidCurrency()
        {
            float valor2 = 50;
            string moeda2 = "dollar";
            var Preco2 = new Preco(valor2, moeda2);
            Assert.IsFalse(Preco2.Valid);
        }

        [TestMethod]
        public void TestValid()
        {
            float valor3 = 50;
            string moeda3 = "R$";
            var preco3 = new Preco(valor3, moeda3);
            Assert.IsTrue(preco3.Valid);
        }
    }
}
