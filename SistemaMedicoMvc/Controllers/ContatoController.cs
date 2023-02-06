using Microsoft.AspNetCore.Mvc;
using SistemaMedicoMvc.Models;
using SistemaMedicoMvc.Repositorio;
using System.Collections.Generic;

namespace SistemaMedicoMvc.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IPessoaDAO _pessoaRepositorio;
        public ContatoController(IPessoaDAO pessoaRepositorio) 
        {
            _pessoaRepositorio = pessoaRepositorio;
        }
        public IActionResult Index()
        {
         List<PessoaModel> pessoas = _pessoaRepositorio.BuscarTodos();
            return View(pessoas);
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
           PessoaModel pessoa = _pessoaRepositorio.ListarPorId(id);
           return View(pessoa);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            PessoaModel pessoa = _pessoaRepositorio.ListarPorId(id);
            return View(pessoa);
        }

        public IActionResult Apagar(int id) 
        {
            _pessoaRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Adicionar(PessoaModel pessoa, TipoTelefoneModel tipoTelefone, TelefoneModal telefone, EnderecoModel endereco) 
        {
            _pessoaRepositorio.Adicionar(pessoa);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(PessoaModel pessoa, TipoTelefoneModel tipoTelefone, TelefoneModal telefone, EnderecoModel endereco)
        {
            _pessoaRepositorio.Atualizar(pessoa);
            return RedirectToAction("Index");
        }
    }

}

