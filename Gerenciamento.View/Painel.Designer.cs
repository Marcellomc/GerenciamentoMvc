namespace Gerenciamento.View
{
    partial class Painel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Painel));
            this.btnCadUser = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pn_Titulo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCadCli = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlCadastros = new System.Windows.Forms.Panel();
            this.btnCadFornecedor = new System.Windows.Forms.Button();
            this.pnlIdentifica = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlPrincipal.SuspendLayout();
            this.pn_Titulo.SuspendLayout();
            this.pnlCadastros.SuspendLayout();
            this.pnlIdentifica.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadUser
            // 
            this.btnCadUser.BackColor = System.Drawing.Color.Silver;
            this.btnCadUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadUser.Location = new System.Drawing.Point(0, 31);
            this.btnCadUser.Name = "btnCadUser";
            this.btnCadUser.Size = new System.Drawing.Size(178, 28);
            this.btnCadUser.TabIndex = 0;
            this.btnCadUser.Text = "CADASTRAR USUARIOS";
            this.btnCadUser.UseVisualStyleBackColor = false;
            this.btnCadUser.Click += new System.EventHandler(this.btnCadUser_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlPrincipal.Controls.Add(this.pn_Titulo);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPrincipal.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(214, 832);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // pn_Titulo
            // 
            this.pn_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pn_Titulo.Controls.Add(this.button1);
            this.pn_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pn_Titulo.Name = "pn_Titulo";
            this.pn_Titulo.Size = new System.Drawing.Size(214, 106);
            this.pn_Titulo.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(4, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "CADASTROS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadCli
            // 
            this.btnCadCli.BackColor = System.Drawing.Color.Silver;
            this.btnCadCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadCli.Location = new System.Drawing.Point(0, 3);
            this.btnCadCli.Name = "btnCadCli";
            this.btnCadCli.Size = new System.Drawing.Size(178, 28);
            this.btnCadCli.TabIndex = 3;
            this.btnCadCli.Text = "CADASTRAR CLIENTES";
            this.btnCadCli.UseVisualStyleBackColor = false;
            this.btnCadCli.Click += new System.EventHandler(this.btnCadCli_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.Location = new System.Drawing.Point(14, 593);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(78, 26);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlCadastros
            // 
            this.pnlCadastros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlCadastros.Controls.Add(this.btnCadFornecedor);
            this.pnlCadastros.Controls.Add(this.btnCadCli);
            this.pnlCadastros.Controls.Add(this.btnCadUser);
            this.pnlCadastros.Location = new System.Drawing.Point(213, 73);
            this.pnlCadastros.Name = "pnlCadastros";
            this.pnlCadastros.Size = new System.Drawing.Size(181, 159);
            this.pnlCadastros.TabIndex = 5;
            this.pnlCadastros.Visible = false;
            // 
            // btnCadFornecedor
            // 
            this.btnCadFornecedor.BackColor = System.Drawing.Color.Silver;
            this.btnCadFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadFornecedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadFornecedor.Location = new System.Drawing.Point(1, 59);
            this.btnCadFornecedor.Name = "btnCadFornecedor";
            this.btnCadFornecedor.Size = new System.Drawing.Size(177, 28);
            this.btnCadFornecedor.TabIndex = 4;
            this.btnCadFornecedor.Text = "CADASTRAR FORNECEDORES";
            this.btnCadFornecedor.UseVisualStyleBackColor = false;
            this.btnCadFornecedor.Click += new System.EventHandler(this.btnCadFornecedor_Click);
            // 
            // pnlIdentifica
            // 
            this.pnlIdentifica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlIdentifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlIdentifica.Controls.Add(this.lblHora);
            this.pnlIdentifica.Controls.Add(this.lblData);
            this.pnlIdentifica.Controls.Add(this.btnSair);
            this.pnlIdentifica.Location = new System.Drawing.Point(1392, 0);
            this.pnlIdentifica.Name = "pnlIdentifica";
            this.pnlIdentifica.Size = new System.Drawing.Size(227, 832);
            this.pnlIdentifica.TabIndex = 6;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHora.Location = new System.Drawing.Point(51, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(112, 25);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "----------";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblData.Location = new System.Drawing.Point(43, 55);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(132, 25);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "------------";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(63)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1620, 832);
            this.Controls.Add(this.pnlIdentifica);
            this.Controls.Add(this.pnlCadastros);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Painel";
            this.Text = "Painel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Painel_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.pn_Titulo.ResumeLayout(false);
            this.pnlCadastros.ResumeLayout(false);
            this.pnlIdentifica.ResumeLayout(false);
            this.pnlIdentifica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadUser;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pn_Titulo;
        private System.Windows.Forms.Button btnCadCli;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel pnlCadastros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlIdentifica;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCadFornecedor;
    }
}