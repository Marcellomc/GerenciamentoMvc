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


    public class TelefoneDao
    {
        public int Inserir(TelefoneEnt objTabela)
        {


            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "INSERT INTO TblTelefoneCli([Tipo],[Numero], [Id_Cli]) VALUES(@Tipo, @Numero, @Id_Cli)";
                cmd.Parameters.Add("Tipo", SqlDbType.VarChar).Value = objTabela.Tipo;
                cmd.Parameters.Add("Numero", SqlDbType.VarChar).Value = objTabela.Numero;
                cmd.Parameters.Add("Id_Cli", SqlDbType.VarChar).Value = objTabela.Id_Cli;
                
                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();

                return qtd;


            }

        }

        public int Editar(TelefoneEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "UPDATE tblTelefoneCli SET Tipo = @tipo, Numero = @numero,Id_Cli = @id_Cli Where idTelefone=@idTelefone";
                cmd.Parameters.Add("Tipo", SqlDbType.Char).Value = objTabela.Tipo;
                cmd.Parameters.Add("Numero", SqlDbType.VarChar).Value = objTabela.Numero;
                cmd.Parameters.Add("Id_Cli", SqlDbType.Int).Value = objTabela.Id_Cli;
                cmd.Parameters.Add("IdTelefone", SqlDbType.Int).Value = objTabela.IdTelefone;
                

                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();

                return qtd;
            }
        }

        public List<TelefoneEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "SELECT * From tblTelefoneCli";


                cmd.Connection = con;

                SqlDataReader dr;
                List<TelefoneEnt> lista = new List<TelefoneEnt>();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        TelefoneEnt linha = new TelefoneEnt();
                        linha.IdTelefone = Convert.ToInt32(dr["IdTelefone"]);
                        linha.Tipo = Convert.ToString(dr["Tipo"]);
                        linha.Numero = Convert.ToString(dr["Numero"]);
                        linha.Id_Cli = Convert.ToInt32(dr["Id_Cli"]);
                        

                        lista.Add(linha);

                    }

                }
                return lista;
            }

        }


    }   
}       
