namespace SistemaMedicoMvc.Models
{
    public class PessoaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set;}
        public TelefoneModal Telefone { get; set;}
        public EnderecoModel Endereco { get; set;}
    }
}
