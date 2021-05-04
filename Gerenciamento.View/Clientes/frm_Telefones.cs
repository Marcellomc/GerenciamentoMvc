using System;
using System.Windows.Forms;
using Entidades.Gerencia;
using Gerenciamento.Model;

namespace Gerenciamento.View
{
    public partial class frm_Telefones : Form
    {
        TelefoneEnt objTabela = new TelefoneEnt();

        public frm_Telefones()
        {
            InitializeComponent();
        }

        public frm_Telefones(string Valor)
        {
            InitializeComponent();
            txtCodCli.Text = Valor;
        }

        private void frm_Telefones_KeyDown(object sender, KeyEventArgs e)
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
                        objTabela.IdTelefone = Convert.ToInt32(txtIdTelefone.Text);
                        objTabela.Tipo = cboTipo.Text;
                        objTabela.Numero = txtNumero.Text;
                        objTabela.Id_Cli = Convert.ToInt32(txtCodCli.Text);

                        int x = TelefoneModel.Editar(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("TELEFONE {0} Foi ALTERADO!", txtNumero.Text));
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
                        //objTabela.IdTelefone = Convert.ToInt32(txtIdTelefone.Text);
                        objTabela.Tipo = cboTipo.Text;
                        objTabela.Numero = txtNumero.Text;
                        objTabela.Id_Cli = Convert.ToInt32(txtCodCli.Text);

                        int x = TelefoneModel.Inserir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("O TELEFONE DO CLIENTE COD. {0} Foi Inserido!", txtNumero.Text));
                        }
                        else
                        {
                            MessageBox.Show("Não Inserido!!!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao Salvar!" + ex.Message);

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

  }  } 


        