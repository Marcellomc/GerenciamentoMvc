using Entidades.Gerencia;
using Gerenciamento.Model;
using Gerenciamento.View.Clientes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Gerenciamento.View
{
    public partial class frmCadCliente : Form

    {
        ClienteEnt objTabela = new ClienteEnt();

        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            ListarDgv();

        }


        private void ListarDgv()
        {
            try
            {
                List<ClienteEnt> lista = new List<ClienteEnt>();
                lista = new ClienteModel().Lista();
                dgvCliente.AutoGenerateColumns = false;
                dgvCliente.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar Dados!" + ex.Message);
            }
        }
      

        private void frmCadCliente_KeyDown(object sender, KeyEventArgs e)
        {
            Control nextControl;
            //Checks if the Enter Key was Pressed
            if (e.KeyCode == Keys.Enter)
            {
                //If so, it gets the next control and applies the focus to it
                nextControl = GetNextControl(ActiveControl, !e.Shift);
                if (nextControl == null)
                {
                    nextControl = GetNextControl(null, true);
                }
                nextControl.Focus();
                //Finally - it suppresses the Enter Key
                e.SuppressKeyPress = true;
            }
        }

  
        private void btnNovo_Click(object sender, EventArgs e)
        {
            IniciarOpc();
            opc = "Novo";
           

            LimparCampos();
            HabilitarCampos();
            txtNome.Focus();
           
        }

        private string opc = "";

        private void IniciarOpc()
        {
            switch (opc)
            {
                case "NOVO":


                    break;


                case "SALVAR":

                    try
                    {
                        objTabela.NomeCli = txtNome.Text;
                        objTabela.CpfCnpjCli = txtCnpj.Text;
                        objTabela.SexoCli = txtSexo.Text;
                        objTabela.EmailCli = txtEmail.Text;

                        int x = ClienteModel.Inserir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("CLIENTE {0} Foi Inserido!", txtNome.Text));
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


                case "EXCLUIR":
                    try
                    {

                        objTabela.IdCli = Convert.ToInt32(txtCodigo.Text);

                        int x = ClienteModel.Excluir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Cliente {0} Foi Excluido!", txtNome.Text));
                        }
                        else
                        {
                            MessageBox.Show("Não Excluido!!!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao Excluir!" + ex.Message);

                    }


                    break;

                case "EDITAR":
                    try
                    {
                        objTabela.IdCli = Convert.ToInt32(txtCodigo.Text);
                        objTabela.NomeCli = txtNome.Text;
                        objTabela.CpfCnpjCli = txtCnpj.Text;
                        objTabela.SexoCli = txtSexo.Text;
                        objTabela.EmailCli = txtEmail.Text;

                        int x = ClienteModel.Editar(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("CLIENTE {0} Foi ALTERADO!", txtNome.Text));
                        }
                        else
                        {
                            MessageBox.Show("Não Inserido!!!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao EDITAR!" + ex.Message);

                    }


                    break;

                case "Buscar":
                    try
                    {
                        objTabela.NomeCli = txtBuscar.Text;
                        List<ClienteEnt> lista = new List<ClienteEnt>();
                        lista = new ClienteModel().Buscar(objTabela);
                        dgvCliente.AutoGenerateColumns = false;
                        dgvCliente.DataSource = lista;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao Listar Dados!" + ex.Message);
                    }


                    break;


                default:
                    break;

            }
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtCnpj.Enabled = true;
            txtSexo.Enabled = true;
            txtEmail.Enabled = true;

        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCnpj.Enabled = false;
            txtSexo.Enabled = false;
            txtEmail.Enabled = false;

        }

        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtCnpj.Text = "";
            txtSexo.Text = " ";
            txtEmail.Text = " ";

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            
           
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione um Registro na Tabela! ");
                return;
            }
            DialogResult Opcao;
            Opcao = MessageBox.Show("ATENÇÃO!!! O Registro será excluido", "Sistema Gerencia", MessageBoxButtons.OKCancel);
            if(Opcao==DialogResult.Cancel)
            {
                return;
            }

            opc = "EXCLUIR";
            IniciarOpc();
            ListarDgv();
            DesabilitarCampos();
            LimparCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione um Registro na Tabela! ");
                return;
            }

            opc = "EDITAR";
            IniciarOpc();
            DesabilitarCampos();
            LimparCampos();
            ListarDgv();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            txtCnpj.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            txtSexo.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
            HabilitarCampos();
            BtnExcluir.Enabled = true;
            btnEditar.Enabled = true;
            btnSalvar.Enabled = false;
            btn_CadEndereco.Enabled = true;
            btn_Telefones.Enabled = true;
            btnNovo.Enabled = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                ListarDgv();
                return;
            }
            opc = "Buscar";
            IniciarOpc();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            opc = "SALVAR";
            IniciarOpc();
            ListarDgv();
            DesabilitarCampos();
            LimparCampos();
            btnSalvar.Enabled = false;
            btn_CadEndereco.Enabled = true;
            btn_Telefones.Enabled = true;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

            if (txtNome.Text == "")
            {
                return;
            }
            btnSalvar.Enabled = true;
                
         }

        private void btn_CadEndereco_Click(object sender, EventArgs e)
        {
            frmEndereco FormEndereco = new frmEndereco(txtCodigo.Text);
            FormEndereco.Show();
        }

        private void btn_Telefones_Click(object sender, EventArgs e)
        {
            frm_Telefones FormTelefone = new frm_Telefones(txtCodigo.Text);
            FormTelefone.Show();
        }
    }

}
