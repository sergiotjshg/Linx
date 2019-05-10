using Linx.TesteNivelamento.Sergio.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linx.TesteNivelamento.Sergio.Business.Interfaces
{
    public interface IPessoaBusiness
    {
        List<PessoaVO> Adicionar(PessoaVO pessoa);
        List<PessoaVO> Atualizar(List<PessoaVO> pessoas, PessoaVO pessoaAtualizar);
        List<PessoaVO> Remover(List<PessoaVO> pessoas, PessoaVO pessoaRemover);


    }
}
