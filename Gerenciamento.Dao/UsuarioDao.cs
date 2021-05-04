using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entidades.Gerencia;
using System.Data;




namespace Gerenciamento.Dao
{
    public class UsuarioDao
    {
        public int Inserir(tblUsuario objTabela)
        {
            

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "INSERT INTO TblUsuarios([nome],[usuario],[senha]) VALUES(@nome, @usuario, @senha)";
                cmd.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                cmd.Parameters.Add("usuario", SqlDbType.VarChar).Value = objTabela.Usuario;
                cmd.Parameters.Add("senha", SqlDbType.VarChar).Value = objTabela.Senha;

                cmd.Connection = con;

               int qtd = cmd.ExecuteNonQuery();

               return qtd;
            }
              
        }

        public List<tblUsuario> Buscar(tblUsuario objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "SELECT * From tblUsuarios WHERE nome LIKE @nome";


                cmd.Parameters.Add("nome", SqlDbType.VarChar).Value =  objTabela.Nome +"%";
                cmd.Connection = con;

                SqlDataReader dr;
                List<tblUsuario> lista = new List<tblUsuario>();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        tblUsuario linha = new tblUsuario();
                        linha.Id = Convert.ToInt32(dr["idUsuario"]);
                        linha.Nome = Convert.ToString(dr["nome"]);
                        linha.Usuario = Convert.ToString(dr["usuario"]);
                        linha.Senha = Convert.ToString(dr["senha"]);

                        lista.Add(linha);

                    }

                }

                return lista;
            }
        }

        public int Editar(tblUsuario objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "UPDATE tblUsuarios SET nome = @nome, usuario = @usuario,senha = @senha Where idUsuario=@id";
                cmd.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                cmd.Parameters.Add("usuario", SqlDbType.VarChar).Value = objTabela.Usuario;
                cmd.Parameters.Add("senha", SqlDbType.VarChar).Value = objTabela.Senha;
                cmd.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;

                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();

                return qtd;
            }
        }

        public int Excluir(tblUsuario objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "DELETE FROM tblUsuarios Where idUsuario=@id";
                cmd.Parameters.Add("id",SqlDbType.Int).Value = objTabela.Id;
                

                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();

                return qtd;
            }

        }

        public tblUsuario Login(tblUsuario obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "SELECT * From tblUsuarios Where usuario =@Usuario And senha = @Senha";


                cmd.Connection = con;
                cmd.Parameters.Add("usuario", SqlDbType.VarChar).Value = obj.Usuario;
                cmd.Parameters.Add("senha", SqlDbType.VarChar).Value = obj.Senha;


          

                SqlDataReader dr;
                

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        tblUsuario linha = new tblUsuario();
                        
                        linha.Usuario = Convert.ToString(dr["usuario"]);
                        linha.Senha = Convert.ToString(dr["senha"]);

                    }

                }
                else
                {
                    obj.Usuario = null;
                    obj.Senha = null;
                }

                return obj;


            }  }

        public List<tblUsuario> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "SELECT * From tblUsuarios";
                

                cmd.Connection = con;

                SqlDataReader dr;
                List<tblUsuario> lista = new List<tblUsuario>();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        tblUsuario linha = new tblUsuario();
                        linha.Id = Convert.ToInt32(dr["idUsuario"]);
                        linha.Nome = Convert.ToString(dr["nome"]);
                        linha.Usuario = Convert.ToString(dr["usuario"]);
                        linha.Senha = Convert.ToString(dr["senha"]);

                        lista.Add(linha);

                    }

                }

                return lista;
            }
        }
    }
}
