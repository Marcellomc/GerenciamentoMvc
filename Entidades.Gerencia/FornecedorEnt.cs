using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Gerencia
{
    public class FornecedorEnt
    {
        private int idFornecedor;
        private string nome;
        private string cpfCnpj;
        private string sexo;
        private string email;

        public int IdFornecedor { get => idFornecedor; set => idFornecedor = value; }
        public string Nome { get => nome; set => nome = value; }
        public string CpfCnpj { get => cpfCnpj; set => cpfCnpj = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Email { get => email; set => email = value; }
    }
}
