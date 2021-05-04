using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Gerencia;
using Gerenciamento.Dao;


namespace Gerenciamento.Model
{
    public class TelefoneModel
    {
        public static int Inserir(TelefoneEnt objTabela)
        {
            return new TelefoneDao().Inserir(objTabela);
        }

        public List<TelefoneEnt> Lista()
        {
            return new TelefoneDao().Lista();
        }

        public static int Editar(TelefoneEnt objTabela)
        {
            return new TelefoneDao().Editar(objTabela);
        }

    }
}
