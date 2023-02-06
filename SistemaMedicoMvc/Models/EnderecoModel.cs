using System.Net.PeerToPeer.Collaboration;

namespace SistemaMedicoMvc.Models
{
    public class EnderecoModel : PessoaModel
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set;}
        public string Estato { get; set;} 
        public int Cep { get; set;}
    }
}
