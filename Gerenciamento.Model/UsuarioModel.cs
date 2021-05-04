using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerenciamento.Dao;
using Entidades.Gerencia;


namespace Gerenciamento.Model
{
    public class UsuarioModel
    {
        public static int Inserir(tblUsuario objTabela)
        {
            return new UsuarioDao().Inserir(objTabela);
        }

        public List<tblUsuario> Lista()
        {
            return new UsuarioDao().Lista();
        }

        public tblUsuario Login(tblUsuario obj)
        {
            return new UsuarioDao().Login(obj);
        }

        public static int Excluir(tblUsuario objTabela)
        {
            return new UsuarioDao().Excluir(objTabela);
        }

        public static int Editar(tblUsuario objTabela)
        {
            return new UsuarioDao().Editar(objTabela);
        }

        public List<tblUsuario> Buscar(tblUsuario objTabela)
        {
            return new UsuarioDao().Buscar(objTabela);
        }
    }
}
