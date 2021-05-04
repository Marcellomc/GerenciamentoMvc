using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Gerencia;
using Gerenciamento.Dao;

namespace Gerenciamento.Model
{
     public class EnderecoCliModel
    {
        public static int Inserir(EnderecoCliEnt objTabela)
        {
            return new EnderecoCliDao().Inserir(objTabela);
        }

        public static int Editar(EnderecoCliEnt objTabela)
        {
            return new EnderecoCliDao().Editar(objTabela);
        }

    }
}
