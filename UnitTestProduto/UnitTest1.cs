using FormularioComUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProduto
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestarProdutoSemErros()
        {
            Produto p = new Produto("batatas", 1, "Blabla", 0, 0);
            Assert.IsTrue(p.Validar().Count==0);
        }
        [TestMethod]
        public void TestarProdutoComErros()
        {
            //Este teste deve retornar false por causa da quantidade
            Produto p = new Produto("batatas", 1, "Blabla", 0, -1);
            Assert.IsFalse(p.Validar().Count == 0);
        }
        [TestMethod]
        public void TestarNomeProduto()
        {
            Produto p = new Produto("", 1, "Blabla", 0, 1);
            List<string> erros = p.Validar();
            Assert.IsTrue(erros.Count == 1);
            Assert.IsTrue(erros[0] == "Nome tem de estar preenchido");
        }
    }
}
