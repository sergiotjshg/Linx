using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Linx.TesteNivelamento.Sergio.Business.Interfaces;
using Linx.TesteNivelamento.Sergio.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Linx.TesteNivelamento.Sergio.Controllers
{
    [ExcludeFromCodeCoverage]
    public class PessoaController : Controller
    {

        private readonly IPessoaBusiness _pessoaBusiness;

        public PessoaController(IPessoaBusiness pessoaBusiness)
        {
            _pessoaBusiness = pessoaBusiness;
        }
      
        public IActionResult Adicionar(PessoaVO pessoaValor)
        {

            var pessoa = new PessoaVO()
            {
                Nome = pessoaValor.Nome,
                Idade = pessoaValor.Idade,
                Dinheiro = pessoaValor.Dinheiro
            };

            return View("~/Pages/Index.cshtml",_pessoaBusiness.Adicionar(pessoa));
        }


        public IActionResult MaiorValorDInheiro(List<PessoaVO> pessoas)
        {
            float maiorValor = pessoas.Max(x => x.Dinheiro); ;

            Console.WriteLine(maiorValor);

            return Ok(maiorValor);
        }

        public IActionResult AnoNascimento(PessoaVO pessoa)
        {

            DateTime? AnoNascimento = DateTime.Now.AddYears(-pessoa.Idade);

            return Ok(AnoNascimento);
        }

        public IActionResult Atualizar(List<PessoaVO> pessoas, string nome)
        {
            var pessoa = new PessoaVO()
            {
                Nome = nome
            };

            return View("~/Pages/Index.cshtml", _pessoaBusiness.Atualizar(pessoas,pessoa));
        }

        public IActionResult Remover(List<PessoaVO> pessoas, string nome)
        {
            var pessoa = new PessoaVO()
            {
                Nome = nome
            };

            return View("~/Pages/Index.cshtml", _pessoaBusiness.Remover(pessoas, pessoa));

        }


    }
}