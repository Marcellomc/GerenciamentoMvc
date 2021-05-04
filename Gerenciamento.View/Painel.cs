using Gerenciamento.View.Fonecedores;
using System;
using System.Windows.Forms;

namespace Gerenciamento.View
{
    public partial class Painel : Form
    {
        public Painel()
        {
            InitializeComponent();
        }

        private void btnCadUser_Click(object sender, EventArgs e)
        {
            frmCadUsuario FormUser = new frmCadUsuario();
            FormUser.Show();
            pnlCadastros.Visible = false;
        }

        private void Painel_Load(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Close();
            lblData.Text = DateTime.Today.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            frmCadCliente CadCli = new frmCadCliente();
            CadCli.Show();
            pnlCadastros.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlCadastros.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnCadFornecedor_Click(object sender, EventArgs e)
        {
            frmCadFornecedor CadForn = new frmCadFornecedor();
            CadForn.Show();
            pnlCadastros.Visible = false;
        }
    }
}
