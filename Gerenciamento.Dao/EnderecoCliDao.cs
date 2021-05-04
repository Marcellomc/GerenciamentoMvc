using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Gerencia;
using System.Data.SqlClient;
using System.Data;

namespace Gerenciamento.Dao
{
   public class EnderecoCliDao
    {
        public int Inserir(EnderecoCliEnt objTabela)
        {


            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "INSERT INTO TblEndereco([Rua],[Cidade],[Bairro],[Estado],[Id_Cliente]) VALUES(@Rua, @Cidade, @Bairro,@Estado,@Id_Cliente)";
                cmd.Parameters.Add("Rua", SqlDbType.VarChar).Value = objTabela.Rua;
                cmd.Parameters.Add("Cidade", SqlDbType.VarChar).Value = objTabela.Cidade;
                cmd.Parameters.Add("Bairro", SqlDbType.VarChar).Value = objTabela.Bairro;
                cmd.Parameters.Add("Estado", SqlDbType.Char).Value = objTabela.Estado;
                cmd.Parameters.Add("Id_Cliente", SqlDbType.Int).Value = objTabela.Id_Cliente;

                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();

                return qtd;


            }

        }

        public int Editar(EnderecoCliEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "UPDATE tblEndereco SET Rua = @Rua, Cidade = @Cidade,Bairro = @Bairro,Estado=@Estado,Id_Cliente = @Id_Cliente Where Id_Cliente=@Id_Cliente";
                cmd.Parameters.Add("Rua", SqlDbType.VarChar).Value = objTabela.Rua;
                cmd.Parameters.Add("Cidade", SqlDbType.VarChar).Value = objTabela.Cidade;
                cmd.Parameters.Add("Bairro", SqlDbType.VarChar).Value = objTabela.Bairro;
                cmd.Parameters.Add("Estado", SqlDbType.Char).Value = objTabela.Estado;
                cmd.Parameters.Add("Id_Cliente", SqlDbType.Int).Value = objTabela.Id_Cliente;


                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();

                return qtd;
            }
        }
    }
}
