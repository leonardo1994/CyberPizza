using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyberPizza.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestCyberPizza
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void Take()
        {
            int[] numeros = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var resultado = from num in numeros.Take(5) select num;

            int[] teste = {5, 4, 1, 3, 9};
            
            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }

        [TestMethod]
        public void Skip()
        {
             int[] numeros = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var resultado = from num in numeros.Take(5).Skip(2) select num;

            int[] teste = {1, 3, 9};
            
            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }
        }
    }
}
