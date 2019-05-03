using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TanaMao.Domain.Gerencia.ValueObjects;

namespace TaNaMao.Tests.Gerencia.ValueObject
{
    [TestClass]
    public class DescricaoTest
    {
        [TestMethod]
        public void TesteValido()
        {
            var desc1 = new Descricao("Este produto pode ter reação alérgica");            
            Assert.IsTrue(desc1.Valid);
        }

        [TestMethod]
        public void TesteTamanho()
        {
            var desc2 = new Descricao("Este");
            Assert.IsFalse(desc2.Valid);
        }

        [TestMethod]
        public void TesteCaractereInvalido()
        {
            var desc3 = new Descricao("Este produto não pode ser vendido para menores de 18 anos#");

            Assert.IsFalse(desc3.Valid);
        }

        [TestMethod]
        public void TesteVazio()
        {
            var desc4 = new Descricao("         ");
            Assert.IsFalse(desc4.Valid);
        }
    }
}
