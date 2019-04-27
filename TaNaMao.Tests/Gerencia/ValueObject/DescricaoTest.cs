using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TanaMao.Domain.Gerencia.ValueObjects;

namespace TaNaMao.Tests.Gerencia.ValueObject
{
    [TestClass]
    public class DescricaoTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var desc1 = new Descricao("Este produto pode ter reação alérgica");            
            Assert.IsTrue(desc1.Valid);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var desc2 = new Descricao("Este produto não pode ser vendido para menores de 18 anos");
            Assert.IsTrue(desc2.Valid);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var desc3 = new Descricao("Este produto não pode ser vendido para menores de 18 anos#");

            Assert.IsTrue(desc3.Valid);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var desc4 = new Descricao("         ");
            Assert.IsTrue(desc4.Valid);
        }
    }
}
