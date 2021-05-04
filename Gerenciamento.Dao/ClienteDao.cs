using Entidades.Gerencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Gerenciamento.Dao
{
     public class ClienteDao
    {
        public int Inserir(ClienteEnt objTabela)
        {


            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "INSERT INTO TblCliente([nomeCli],[cpfCnpjCli],[sexoCli],[emailCli]) VALUES(@nomeCli, @cpfCnpjCli, @sexoCli, @emailCli)";
                cmd.Parameters.Add("nomeCli", SqlDbType.VarChar).Value = objTabela.NomeCli;
                cmd.Parameters.Add("cpfCnpjCli", SqlDbType.VarChar).Value = objTabela.CpfCnpjCli;
                cmd.Parameters.Add("sexoCli", SqlDbType.VarChar).Value = objTabela.SexoCli;
                cmd.Parameters.Add("emailCli", SqlDbType.VarChar).Value = objTabela.EmailCli;

                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();

                return qtd;
            }

        }

        public List<ClienteEnt> Buscar(ClienteEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "SELECT * From tblCliente WHERE nomeCli LIKE @nomeCli";


                cmd.Parameters.Add("nomeCli", SqlDbType.VarChar).Value = objTabela.NomeCli + "%";
                cmd.Connection = con;

                SqlDataReader dr;
                List<ClienteEnt> lista = new List<ClienteEnt>();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ClienteEnt linha = new ClienteEnt();
                        linha.IdCli = Convert.ToInt32(dr["idCli"]);
                        linha.NomeCli = Convert.ToString(dr["nomeCli"]);
                        linha.CpfCnpjCli = Convert.ToString(dr["cpfCnpjCli"]);
                        linha.SexoCli = Convert.ToString(dr["sexoCli"]);
                        linha.EmailCli = Convert.ToString(dr["emailCli"]);
                        lista.Add(linha);

                    }

                }

                return lista;
            }
        }

        public int Editar(ClienteEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "UPDATE tblCliente SET nomeCli = @nomeCli, cpfCnpjCli = @cpfCnpjCli,sexoCli = @sexoCli,emailCli=@emailCli Where idCli=@idCli";
                cmd.Parameters.Add("nomeCli", SqlDbType.VarChar).Value = objTabela.NomeCli;
                cmd.Parameters.Add("cpfCnpjCli", SqlDbType.VarChar).Value = objTabela.CpfCnpjCli;
                cmd.Parameters.Add("sexoCli", SqlDbType.VarChar).Value = objTabela.SexoCli;
                cmd.Parameters.Add("emailCli", SqlDbType.VarChar).Value = objTabela.EmailCli;
                cmd.Parameters.Add("idCli", SqlDbType.Int).Value = objTabela.IdCli;

                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();

                return qtd;
            }
        }

        public int Excluir(ClienteEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "DELETE FROM tblCliente Where idCli=@idCli";
                cmd.Parameters.Add("idCli", SqlDbType.Int).Value = objTabela.IdCli;


                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();

                return qtd;
            }

        }

        
        public List<ClienteEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "SELECT * From tblCliente";


                cmd.Connection = con;

                SqlDataReader dr;
                List<ClienteEnt> lista = new List<ClienteEnt>();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ClienteEnt linha = new ClienteEnt();
                        linha.IdCli = Convert.ToInt32(dr["idCli"]);
                        linha.NomeCli = Convert.ToString(dr["nomeCli"]);
                        linha.CpfCnpjCli = Convert.ToString(dr["cpfCnpjCli"]);
                        linha.SexoCli = Convert.ToString(dr["sexoCli"]);
                        linha.EmailCli = Convert.ToString(dr["emailCli"]);

                        lista.Add(linha);

                    }
                    
                }
                return lista;
            }
            
        }
    }
}
