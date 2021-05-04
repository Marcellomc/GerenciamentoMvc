
using System.Collections.Generic;
using Entidades.Gerencia;
using Gerenciamento.Dao;

namespace Gerenciamento.Model
{
   public class FornecedorModel
    {
        public static int Inserir(FornecedorEnt objTabela)
        {
            return new FornecedorDao().Inserir(objTabela);
        }

        public List<FornecedorEnt> Lista()
        {
            return new FornecedorDao().Lista();
        }

        
        public static int Excluir(FornecedorEnt objTabela)
        {
            return new FornecedorDao().Excluir(objTabela);
        }

        public static int Editar(FornecedorEnt objTabela)
        {
            return new FornecedorDao().Editar(objTabela);
        }

        public List<FornecedorEnt> Buscar(FornecedorEnt objTabela)
        {
            return new FornecedorDao().Buscar(objTabela);
        }
    }

}
