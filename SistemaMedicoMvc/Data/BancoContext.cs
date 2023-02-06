
using Microsoft.EntityFrameworkCore;
using SistemaMedicoMvc.Models;

namespace SistemaMedicoMvc.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<PessoaModel> Pessoas { get; set; }
        public DbSet<TipoTelefoneModel> TipoTelefone { get; set; }
        public DbSet<TelefoneModal> Telefone { get; set; }
        public DbSet<EnderecoModel> Endereco { get; set; }
    }
}
