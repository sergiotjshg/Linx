using Linx.TesteNivelamento.Sergio.Business.Interfaces;
using Linx.TesteNivelamento.Sergio.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linx.TesteNivelamento.Sergio.Business
{
    public class PessoaBusiness: IPessoaBusiness
    {
        public List<PessoaVO> Adicionar(PessoaVO pessoa)
        {
            var pessoas = new List<PessoaVO>();

            pessoas.Add(pessoa);

            return pessoas;
        }

        public List<PessoaVO> Atualizar(List<PessoaVO> pessoas, PessoaVO pessoaAtualizar)
        {
            foreach (var pessoa in pessoas)
            {
                if (pessoa.Nome == pessoaAtualizar.Nome)
                {
                    pessoa.Nome = pessoaAtualizar.Nome;
                    pessoa.Idade = pessoaAtualizar.Idade;
                    pessoa.Dinheiro = pessoaAtualizar.Dinheiro;
                    break;
                }
            }


            return pessoas;
        }

        public List<PessoaVO> Remover(List<PessoaVO> pessoas, PessoaVO pessoaRemover)
        {

            foreach (var pessoa in pessoas)
            {
                if (pessoa.Nome == pessoaRemover.Nome)
                {
                    pessoas.Remove(pessoa);
                    break;
                }
            }
            return pessoas;
        }


    }
}
