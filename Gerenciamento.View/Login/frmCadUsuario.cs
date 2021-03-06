using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gerenciamento.Model;
using Entidades.Gerencia;

namespace Gerenciamento.View
{
    public partial class frmCadUsuario : Form
     {
        tblUsuario objTabela = new tblUsuario();



        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            opc = "Novo";
            IniciarOpc();

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
                        objTabela.Nome = txtNome.Text;
                        objTabela.Usuario = txtUsuario.Text;
                        objTabela.Senha = txtSenha.Text;

                        int x = UsuarioModel.Inserir(objTabela);

                        if(x > 0)
                        {
                            MessageBox.Show(string.Format("Usuário {0} Foi Inserido!",txtNome.Text));
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
                        
                        objTabela.Id =Convert.ToInt32(txtCodigo.Text);

                        int x = UsuarioModel.Excluir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Usuário {0} Foi Excluido!", txtNome.Text));
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
                        objTabela.Id = Convert.ToInt32(txtCodigo.Text);
                        objTabela.Nome = txtNome.Text;
                        objTabela.Usuario = txtUsuario.Text;
                        objTabela.Senha = txtSenha.Text;

                        int x = UsuarioModel.Editar(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Usuário {0} Foi ALTERADO!", txtNome.Text));
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
                        List<tblUsuario> lista = new List<tblUsuario>();
                        lista = new UsuarioModel().Buscar(objTabela);
                        dgvLogin.AutoGenerateColumns = false;
                        dgvLogin.DataSource = lista;
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
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;

        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtUsuario.Enabled =false;
            txtSenha.Enabled = false;

        }

        private void LimparCampos()
        {
            txtNome.Text="";
            txtUsuario.Text="";
            txtSenha.Text="";
            txtCodigo.Text = "";
              
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            opc = "SALVAR";
            IniciarOpc();
            ListarDgv();
            DesabilitarCampos();

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


        private void ListarDgv()
        {
            try
            {
                List<tblUsuario> lista = new List<tblUsuario>();
                lista = new UsuarioModel().Lista();
                dgvLogin.AutoGenerateColumns = false;
                dgvLogin.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listar Dados!" + ex.Message);
            }
           
        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            ListarDgv();
        }

        private void dgvLogin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvLogin.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvLogin.CurrentRow.Cells[1].Value.ToString();
            txtUsuario.Text = dgvLogin.CurrentRow.Cells[2].Value.ToString();
            
            HabilitarCampos();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            opc = "Buscar";
            IniciarOpc();
           
            
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

        private void frmCadUsuario_KeyDown(object sender, KeyEventArgs e)
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
    }
  }
