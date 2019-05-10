using Autofac.Extras.Moq;
using Linx.TesteNivelamento.Sergio.Business;
using Linx.TesteNivelamento.Sergio.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linx.TesteNivelamento.Sergio.Test.Business
{
    [TestClass]
    public class PessoasBusinessTest
    {
        [TestMethod]
        public void Adicionar()
        {
            PessoaBusiness business = new PessoaBusiness();

            var pessoa = new PessoaVO()
            {
                Nome = "Sergio",
                Idade = 22,
                Dinheiro = 1000.00f
            };

            var pessoas = new List<PessoaVO>();

            pessoas = business.Adicionar(pessoa);

            Assert.IsNotNull(pessoas);
        }

        [TestMethod]
        public void Remover_OK()
        {

            PessoaBusiness business = new PessoaBusiness();

            var pessoaRemover = new PessoaVO()
            {
                Nome = "Sergio"
            };
            var pessoas = new List<PessoaVO>();

            pessoas.Add(pessoaRemover);
            pessoas = business.Remover(pessoas, pessoaRemover);

            Assert.IsNotNull(pessoas);
        }

        [TestMethod]
        public void Remover_SemRemocao()
        {

            PessoaBusiness business = new PessoaBusiness();

            var pessoaRemover = new PessoaVO()
            {
                Nome = "Sergio"
            };

            var pessoaNaoRemover = new PessoaVO()
            {
                Nome = "Teste"
            };

            var pessoas = new List<PessoaVO>();

            pessoas.Add(pessoaNaoRemover);
            
            pessoas = business.Remover(pessoas, pessoaRemover);

            Assert.IsNotNull(pessoas);
        }

        [TestMethod]
        public void Atualizar()
        {
            PessoaBusiness business = new PessoaBusiness();

            var atualizar = new PessoaVO()
            {
                Nome = "Sergio"
            };

            var pessoas = new List<PessoaVO>();

            pessoas.Add(atualizar);

            pessoas = business.Atualizar(pessoas, atualizar);

            Assert.IsNotNull(pessoas);
        }
    }
}
