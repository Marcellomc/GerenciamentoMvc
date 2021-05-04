using System;

namespace Entidades.Gerencia
{
    public class TelefoneEnt
    {
        private int idTelefone;
        private string tipo;
        private string numero;
        private int id_Cli;

        public int IdTelefone { get => idTelefone; set => idTelefone = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Numero { get => numero; set => numero = value; }
        public int Id_Cli { get => id_Cli; set => id_Cli = value; }
    }
}
