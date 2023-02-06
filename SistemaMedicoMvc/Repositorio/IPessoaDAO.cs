using SistemaMedicoMvc.Models;
using System.Collections.Generic;

namespace SistemaMedicoMvc.Repositorio
{
    public interface IPessoaDAO
    {
        PessoaModel ListarPorId(int id);
        List<PessoaModel> BuscarTodos();
        PessoaModel Adicionar(PessoaModel pessoa);
        PessoaModel Atualizar(PessoaModel pessoa);
        bool Apagar(int id);

        TipoTelefoneModel ListarPorNome(int id);
        TipoTelefoneModel Adicionar(TipoTelefoneModel tipoTelefone);
        TipoTelefoneModel Atualizar(TipoTelefoneModel tipoTelefone);

        TelefoneModal ListarPorId(int id);
        TelefoneModal Adicionar(TelefoneModal telefone);
        TelefoneModal Atualizar(TelefoneModal telefone);

        EnderecoModel ListarPorId(int id);
        EnderecoModel Adicionar(EnderecoModel endereco);
        EnderecoModel Atualizar(EnderecoModel endereco);
        

    }
}
