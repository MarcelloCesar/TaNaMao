using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TanaMao.Domain.Gerencia.ValueObject;

namespace TaNaMao.Tests.Gerencia.ValueObject
{
    [TestClass]
    public class PeriodoTest
    {
        [TestMethod]
        public void TestPeriodoValido()
        {
            var Inicio1  = new DateTime(2019,5,3,17,0,0);
            var Fim1     = new DateTime(2019,5,3,20,0,0);
            var Periodo1 = new Periodo(Inicio1, Fim1);
            Assert.IsTrue(Periodo1.Valid);
        }

        [TestMethod]
        public void TestPeriodoInvalido()
        {
            var Inicio2  = new DateTime(2019, 5, 3, 20, 0, 0);
            var Fim2     = new DateTime(2019, 5, 3, 17, 0, 0);
            var Periodo2 = new Periodo(Inicio2, Fim2);
            Assert.IsFalse(Periodo2.Valid);
        }
    }
}
