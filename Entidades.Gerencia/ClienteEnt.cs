using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Gerencia
{
   public class ClienteEnt
    {
        private int idCli;
        private string nomeCli;
        private string cpfCnpjCli;
        private string sexoCli;
        private string emailCli;

        public int IdCli { get => idCli; set => idCli = value; }
        public string NomeCli { get => nomeCli; set => nomeCli = value; }
        public string CpfCnpjCli { get => cpfCnpjCli; set => cpfCnpjCli = value; }
        public string SexoCli { get => sexoCli; set => sexoCli = value; }
        public string EmailCli { get => emailCli; set => emailCli = value; }
    }
}
