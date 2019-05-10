using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Autofac.Extras.Moq;
using Linx.TesteNivelamento.Sergio.Business.Interfaces;
using Linx.TesteNivelamento.Sergio.Entity;
using Linx.TesteNivelamento.Sergio.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Linx.TesteNivelamento.Sergio.Test.Controllers
{
    [TestClass]
    public class PessoaControllerTest
    {

        //[TestMethod]
        //public void Adicionar()
        //{
        //    using (var mock = AutoMock.GetStrict())
        //    {
        //////        var pessoa = new PessoaVO()
        //        {
        //            Nome = "Sergio",
        //            Idade = 22,
        //            Dinheiro = 1000f
        //        };
               

        //        mock.Mock<IPessoaBusiness>()
        //            .Setup(x => x.Adicionar(It.IsAny<PessoaVO>()))
        //            .Returns(new List<PessoaVO>())
        //            .Verifiable();

        //        PessoaController controller = mock.Create<PessoaController>();
                
        //        //IActionResult result = controller.Adicionar(pessoa);
        //    }
        //}

    }
}
