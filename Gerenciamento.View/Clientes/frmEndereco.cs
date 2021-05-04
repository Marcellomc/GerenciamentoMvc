using System;
using System.Windows.Forms;
using Entidades.Gerencia;
using Gerenciamento.Model;

namespace Gerenciamento.View.Clientes
{
    public partial class frmEndereco : Form
    {
        EnderecoCliEnt objTabela = new EnderecoCliEnt();

        public frmEndereco()
        {
            InitializeComponent();
        }

        public frmEndereco(string Valor)
        {
            InitializeComponent();
            txt_IdCli.Text = Valor;
        }

        private void frmEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            Control nextControl;
            //Verifica se a tecla Enter foi pressionada
            if (e.KeyCode == Keys.Enter)
            {
                //Se assim for, ele obtém o próximo controle e aplica o foco a ele
                nextControl = GetNextControl(ActiveControl, !e.Shift);
                if (nextControl == null)
                {
                    nextControl = GetNextControl(null, true);
                }
                nextControl.Focus();
                //Finalmente - ele suprime a chave enter
                e.SuppressKeyPress = true;
            }
        }

        private string opc = "";

        private void IniciarOpc()
        {
            switch (opc)
            {
                case "NOVO":


                    break;

                case "EDITAR":
                    try
                    {
                        objTabela.IdEndereco = Convert.ToInt32(txtIdEndereco.Text);
                        objTabela.Rua = txtRua.Text;
                        objTabela.Cidade = txtRua.Text;
                        objTabela.Bairro = txtBairro.Text;
                        objTabela.Estado = cboEstado.Text;
                        objTabela.Id_Cliente = Convert.ToInt32(txt_IdCli.Text);


                        int x = EnderecoCliModel.Editar(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Endereço {0} Foi ALTERADO!", txtIdEndereco.Text));
                        }
                        else
                        {
                            MessageBox.Show("Não Alterado!!!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao EDITAR!" + ex.Message);

                    }


                    break;

                case "SALVAR":

                    try
                    {
                        //objTabela.IdEndereco = Convert.ToInt32(txtIdEndereco.Text);
                        objTabela.Rua = txtRua.Text;
                        objTabela.Cidade = txtRua.Text;
                        objTabela.Bairro = txtBairro.Text;
                        objTabela.Estado = cboEstado.Text;
                        objTabela.Id_Cliente = Convert.ToInt32(txt_IdCli.Text);

                        int x = EnderecoCliModel.Inserir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("O ENDEREÇO DO CLIENTE COD. {0} Foi Inserido!", txt_IdCli.Text));
                        }
                        else
                        {
                            MessageBox.Show("Não Inserido!!!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ENDEREÇO JÁ CADASTRADOS!");

                    }
                    break;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            opc = "EDITAR";
            IniciarOpc();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            opc = "SALVAR";
            IniciarOpc();
            this.Close();
        }

        private void txtRua_TextChanged(object sender, EventArgs e)
        {
            if (txt_IdCli.Text == "")
            {
                MessageBox.Show("Selecione um Cliente No Grid! ");
            }
            return;
        }
    }

}
