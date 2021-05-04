using System;
using System.Collections.Generic;
using Gerenciamento.View.Fonecedores;
using System.Windows.Forms;
using Entidades.Gerencia;
using Gerenciamento.Model;

namespace Gerenciamento.View.Fonecedores
{
    public partial class frmCadFornecedor : Form
    {
        FornecedorEnt objTabela = new FornecedorEnt();

        public frmCadFornecedor()
        {
            InitializeComponent();
        }

        private void frmCadFornecedor_Load(object sender, EventArgs e)
        {           
            LimparCampos();
            DesabilitarCampos();
            ListarDgv();

        }


        private void ListarDgv()
        {
            try
            {
                List<FornecedorEnt> lista = new List<FornecedorEnt>();
                lista = new FornecedorModel().Lista();
                dgvFornecedor.AutoGenerateColumns = false;
                dgvFornecedor.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar Dados!" + ex.Message);
            }
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
                        objTabela.Nome = txtNome.Text;
                        objTabela.CpfCnpj = txtCnpj.Text;
                        objTabela.Sexo = txtSexo.Text;
                        objTabela.Email = txtEmail.Text;

                        int x = FornecedorModel.Inserir(objTabela);

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

                        objTabela.IdFornecedor = Convert.ToInt32(txtCodigo.Text);

                        int x = FornecedorModel.Excluir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Fornecedor {0} Foi Excluido!", txtNome.Text));
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
                        objTabela.IdFornecedor = Convert.ToInt32(txtCodigo.Text);
                        objTabela.Nome = txtNome.Text;
                        objTabela.CpfCnpj = txtCnpj.Text;
                        objTabela.Sexo = txtSexo.Text;
                        objTabela.Email = txtEmail.Text;

                        int x = FornecedorModel.Editar(objTabela);

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
                        objTabela.Nome = txtBuscar.Text;
                        List<FornecedorEnt> lista = new List<FornecedorEnt>();
                        lista = new FornecedorModel().Buscar(objTabela);
                        dgvFornecedor.AutoGenerateColumns = false;
                        dgvFornecedor.DataSource = lista;
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
            if (Opcao == DialogResult.Cancel)
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

                      
        private void btn_CadEndereco_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Telefones_Click(object sender, EventArgs e)
        {
            
        }

        private void frmCadFornecedor_KeyDown(object sender, KeyEventArgs e)
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
                HabilitarCampos();
                txtNome.Focus();       
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            opc = "SALVAR";
            IniciarOpc();
            ListarDgv();
            DesabilitarCampos();
            LimparCampos();
            btnSalvar.Enabled = false;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                return;
            }
            btnSalvar.Enabled = true;
        }

        private void dgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvFornecedor.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvFornecedor.CurrentRow.Cells[1].Value.ToString();
            txtCnpj.Text = dgvFornecedor.CurrentRow.Cells[2].Value.ToString();
            txtSexo.Text = dgvFornecedor.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvFornecedor.CurrentRow.Cells[4].Value.ToString();
            HabilitarCampos();
            BtnExcluir.Enabled = true;
            btnEditar.Enabled = true;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = false;

        }
    }

   
}
