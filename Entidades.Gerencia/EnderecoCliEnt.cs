using System;


namespace Entidades.Gerencia
{
   public class EnderecoCliEnt
    {
        private int idEndereco;
        private string rua;
        private string cidade;
        private string bairro;
        private string estado;
        private int id_Cliente;

        public int IdEndereco { get => idEndereco; set => idEndereco = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Id_Cliente { get => id_Cliente; set => id_Cliente = value; }
    }
}
