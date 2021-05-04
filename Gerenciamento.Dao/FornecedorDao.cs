using System.Data;
using System.Data.SqlClient;
using Entidades.Gerencia;
using System;
using System.Collections.Generic;

namespace Gerenciamento.Dao
{
    public class FornecedorDao
    {
        public int Inserir(FornecedorEnt objTabela)
        {


            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "INSERT INTO TblFornecedor([nome],[cpfCnpj],[sexo],[email]) VALUES(@nome, @cpfCnpj, @sexo, @email)";
                cmd.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                cmd.Parameters.Add("cpfCnpj", SqlDbType.VarChar).Value = objTabela.CpfCnpj;
                cmd.Parameters.Add("sexo", SqlDbType.VarChar).Value = objTabela.Sexo;
                cmd.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Email;

                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();

                return qtd;
            }

        }

        public List<FornecedorEnt> Buscar(FornecedorEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "SELECT * From tblFornecedor WHERE nome LIKE @nome";


                cmd.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome + "%";
                cmd.Connection = con;

                SqlDataReader dr;
                List<FornecedorEnt> lista = new List<FornecedorEnt>();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        FornecedorEnt linha = new FornecedorEnt();
                        linha.IdFornecedor = Convert.ToInt32(dr["idFornecedor"]);
                        linha.Nome = Convert.ToString(dr["nome"]);
                        linha.CpfCnpj = Convert.ToString(dr["cpfCnpj"]);
                        linha.Sexo = Convert.ToString(dr["sexo"]);
                        linha.Email = Convert.ToString(dr["email"]);
                        lista.Add(linha);

                    }

                }

                return lista;
            }
        }

        public int Editar(FornecedorEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "UPDATE tblFornecedor SET nome = @nome, cpfCnpj = @cpfCnpj,sexo = @sexo,email=@email Where idFornecedor=@idFornecedor";
                cmd.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                cmd.Parameters.Add("cpfCnpj", SqlDbType.VarChar).Value = objTabela.CpfCnpj;
                cmd.Parameters.Add("sexo", SqlDbType.VarChar).Value = objTabela.Sexo;
                cmd.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Email;
                cmd.Parameters.Add("idFornecedor", SqlDbType.Int).Value = objTabela.IdFornecedor;

                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();

                return qtd;
            }
        }

        public int Excluir(FornecedorEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "DELETE FROM tblFornecedor Where idFornecedor=@idFornecedor";
                cmd.Parameters.Add("idFornecedor", SqlDbType.Int).Value = objTabela.IdFornecedor;


                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();

                return qtd;
            }

        }

        public List<FornecedorEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "SELECT * From tblFornecedor";


                cmd.Connection = con;

                SqlDataReader dr;
                List<FornecedorEnt> lista = new List<FornecedorEnt>();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        FornecedorEnt linha = new FornecedorEnt();
                        linha.IdFornecedor = Convert.ToInt32(dr["idFornecedor"]);
                        linha.Nome = Convert.ToString(dr["nome"]);
                        linha.CpfCnpj = Convert.ToString(dr["cpfCnpj"]);
                        linha.Sexo = Convert.ToString(dr["sexo"]);
                        linha.Email = Convert.ToString(dr["email"]);

                        lista.Add(linha);

                    }

                }
                return lista;
            }

        }

    }
}
