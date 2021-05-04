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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Preencha o Campo Usuário!");
                    txtUsuario.Focus();
                    return;
                }

                if (txtSenha.Text == "")
                {
                    MessageBox.Show("Preencha o Campo Senha!");
                    txtSenha.Focus();
                    return;
                }

                tblUsuario obj = new tblUsuario();
                obj.Usuario = txtUsuario.Text;
                obj.Senha = txtSenha.Text;

                obj = new UsuarioModel().Login(obj);
                if (obj.Usuario == null) {

                    lblMensagem.Text = "Usuario Invalido!";
                    lblMensagem.ForeColor = Color.Red;
                    return;
                }

               Painel form = new Painel();
                this.Hide();
                form.Show();
                


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Logar! " + ex.Message);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
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
