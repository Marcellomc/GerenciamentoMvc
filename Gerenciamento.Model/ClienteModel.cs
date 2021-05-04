using Entidades.Gerencia;
using System;
using System.Collections.Generic;
using Gerenciamento.Dao;


namespace Gerenciamento.Model
{
    public class ClienteModel
    {
        public static int Inserir(ClienteEnt objTabela)
        {
            return new ClienteDao().Inserir(objTabela);
        }

        public List<ClienteEnt> Lista()
        {
            return new ClienteDao().Lista();
        }

        

        public static int Excluir(ClienteEnt objTabela)
        {
            return new ClienteDao().Excluir(objTabela);
        }

        public static int Editar(ClienteEnt objTabela)
        {
            return new ClienteDao().Editar(objTabela);
        }

        public List<ClienteEnt> Buscar(ClienteEnt objTabela)
        {
            return new ClienteDao().Buscar(objTabela);
        }
    }
}
