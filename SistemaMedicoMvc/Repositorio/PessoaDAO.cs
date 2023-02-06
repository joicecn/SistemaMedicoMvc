using SistemaMedicoMvc.Controllers;
using SistemaMedicoMvc.Data;
using SistemaMedicoMvc.Models;
using System.Collections.Generic;
using System.Linq;
using static SistemaMedicoMvc.Repositorio.IPessoaDAO;

namespace SistemaMedicoMvc.Repositorio
{
    public class PessoaDAO : IPessoaDAO
    {
        private readonly BancoContext _context;
        public PessoaDAO(BancoContext bancoContext) 
        {
            _context= bancoContext;
        }

        public PessoaModel ListarPorId(int id)
        {
            return _context.Pessoas.FirstOrDefault( x => x.Id == id);
        }


        public List<PessoaModel> BuscarTodos()
        {
            return _context.Pessoas.ToList();
        }


        public PessoaModel Adicionar(PessoaModel pessoa)
        {
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
            return pessoa;
        }

        public PessoaModel Atualizar(PessoaModel pessoa)
        {
            PessoaModel pessoaDB = ListarPorId(pessoa.Id);

            if (pessoaDB == null) throw new System.Exception("Houve um erro na atualizaçao do contato");

            pessoaDB.Nome = pessoa.Nome;
            pessoaDB.CPF = pessoa.CPF;

            _context.Pessoas.Update(pessoaDB);
            _context.SaveChanges();

            return pessoaDB;
        }

        public bool Apagar(int id)
        {
            PessoaModel pessoaDB = ListarPorId(id);

            if (pessoaDB == null) throw new System.Exception("Houve um erro ao deletar o contato");

            _context.Pessoas.Remove(pessoaDB);
            _context.SaveChanges();

            return true;
        }

        public TipoTelefoneModel Adicionar(TipoTelefoneModel tipoTelefone)
        {
            _context.TipoTelefone.Add(tipoTelefone);
            _context.SaveChanges();
            return tipoTelefone;

        }

        public TipoTelefoneModel Atualizar(TipoTelefoneModel tipoTelefone)
        {
            TipoTelefoneModel tipoTelefoneDB = ListarPorId(tipoTelefone.Id);

            if (tipoTelefoneDB == null) throw new System.Exception("Houve um erro na atualização");

            tipoTelefoneDB.TipoTelefone = tipoTelefone.TipoTelefone;

            _context.TipoTelefone.Update(tipoTelefoneDB);
            _context.SaveChanges();

            return tipoTelefone;
        }

        public TelefoneModal Adicionar(TelefoneModal telefone)
        {
            _context.Telefone.Add(telefone);
            _context.SaveChanges();
            return telefone;
        }

        public TelefoneModal Atualizar(TelefoneModal telefone)
        {
            TelefoneModal telefoneDB = ListarPorNumeroTelefone(telefone.Id);

            if (telefoneDB == null) throw new System.Exception("Houve um erro na atualização");

            telefoneDB.Telefone = telefone.Telefone;

            _context.Telefone.Update(telefoneDB);
            _context.SaveChanges();

            return telefone;


        }

        public EnderecoModel Adicionar(EnderecoModel endereco)
        {
            _context.Endereco.Add(endereco);
            _context.SaveChanges();
            return endereco;
        }

        public EnderecoModel Atualizar(EnderecoModel endereco)
        {
            throw new System.NotImplementedException();
        }
    }
}
