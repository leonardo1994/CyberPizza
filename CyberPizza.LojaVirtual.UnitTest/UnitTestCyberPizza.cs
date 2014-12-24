using System;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using CyberPizza.LojaVirtual.Web.HtmlHelpers;
using CyberPizza.LojaVirtual.Web.Models;
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


        #region Teste de Exibição de páginação por página usando a filtragem pelo método Take

        [TestMethod]

        public void Take()
        {
            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var resultado = from num in numeros.Take(5) select num;

            int[] teste = { 5, 4, 1, 3, 9 };

            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }

        #endregion

        #region Teste de Controle de exibição dos proximos Itens por página pelo método Skip

        [TestMethod]
        public void Skip()
        {
            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var resultado = from num in numeros.Take(5).Skip(2) select num;

            int[] teste = { 1, 3, 9 };

            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }

        #endregion

    }
}

