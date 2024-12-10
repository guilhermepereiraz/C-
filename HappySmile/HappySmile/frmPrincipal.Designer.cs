namespace HappySmile
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConexao = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrPrincipal = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroConvenio = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDentista = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroDentista = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroEspecialidade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAgendamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDominios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEspecialidade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormadepagamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcedimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSituacaoAgendamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTiposCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTiposTelefone = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblConexao,
            this.lblTempo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(261, 17);
            this.lblUsuario.Spring = true;
            this.lblUsuario.Text = "Usuario: ";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConexao
            // 
            this.lblConexao.Name = "lblConexao";
            this.lblConexao.Size = new System.Drawing.Size(261, 17);
            this.lblConexao.Spring = true;
            this.lblConexao.Text = "Servidor: 192.168.10.15 | Banco: Cliente";
            // 
            // lblTempo
            // 
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(261, 17);
            this.lblTempo.Spring = true;
            this.lblTempo.Text = "Tempo: 00:00:00";
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrPrincipal
            // 
            this.tmrPrincipal.Enabled = true;
            this.tmrPrincipal.Interval = 1000;
            this.tmrPrincipal.Tick += new System.EventHandler(this.tmrPrincipal_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuarios,
            this.mnuPacientes,
            this.mnuDentista,
            this.mnuAgendamentos,
            this.mnuDominios,
            this.mnuSobre,
            this.mnuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroUsuario});
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(64, 20);
            this.mnuUsuarios.Text = "&Usuários";
            // 
            // mnuCadastroUsuario
            // 
            this.mnuCadastroUsuario.Name = "mnuCadastroUsuario";
            this.mnuCadastroUsuario.Size = new System.Drawing.Size(180, 22);
            this.mnuCadastroUsuario.Text = "&Cadastro Usuário";
            this.mnuCadastroUsuario.Click += new System.EventHandler(this.mnuCadastroUsuario_Click);
            // 
            // mnuPacientes
            // 
            this.mnuPacientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroPacientes,
            this.mnuCadastroConvenio});
            this.mnuPacientes.Name = "mnuPacientes";
            this.mnuPacientes.Size = new System.Drawing.Size(69, 20);
            this.mnuPacientes.Text = "&Pacientes";
            // 
            // mnuCadastroPacientes
            // 
            this.mnuCadastroPacientes.Name = "mnuCadastroPacientes";
            this.mnuCadastroPacientes.Size = new System.Drawing.Size(180, 22);
            this.mnuCadastroPacientes.Text = "Cadastro Paciente";
            // 
            // mnuCadastroConvenio
            // 
            this.mnuCadastroConvenio.Name = "mnuCadastroConvenio";
            this.mnuCadastroConvenio.Size = new System.Drawing.Size(180, 22);
            this.mnuCadastroConvenio.Text = "Cadastro Convénio";
            // 
            // mnuDentista
            // 
            this.mnuDentista.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroDentista,
            this.mnuCadastroEspecialidade});
            this.mnuDentista.Name = "mnuDentista";
            this.mnuDentista.Size = new System.Drawing.Size(62, 20);
            this.mnuDentista.Text = "&Dentista";
            // 
            // mnuCadastroDentista
            // 
            this.mnuCadastroDentista.Name = "mnuCadastroDentista";
            this.mnuCadastroDentista.Size = new System.Drawing.Size(202, 22);
            this.mnuCadastroDentista.Text = "Cadastro Dentista";
            // 
            // mnuCadastroEspecialidade
            // 
            this.mnuCadastroEspecialidade.Name = "mnuCadastroEspecialidade";
            this.mnuCadastroEspecialidade.Size = new System.Drawing.Size(202, 22);
            this.mnuCadastroEspecialidade.Text = "Cadastro Especifialidade";
            // 
            // mnuAgendamentos
            // 
            this.mnuAgendamentos.Name = "mnuAgendamentos";
            this.mnuAgendamentos.Size = new System.Drawing.Size(100, 20);
            this.mnuAgendamentos.Text = "Agendamentos";
            // 
            // mnuDominios
            // 
            this.mnuDominios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEspecialidade,
            this.mnuFormadepagamento,
            this.mnuProcedimentos,
            this.mnuSituacaoAgendamento,
            this.mnuTiposCliente,
            this.mnuTiposTelefone});
            this.mnuDominios.Name = "mnuDominios";
            this.mnuDominios.Size = new System.Drawing.Size(70, 20);
            this.mnuDominios.Text = "Dominios";
            // 
            // mnuEspecialidade
            // 
            this.mnuEspecialidade.Name = "mnuEspecialidade";
            this.mnuEspecialidade.Size = new System.Drawing.Size(219, 22);
            this.mnuEspecialidade.Text = "Especialidade";
            // 
            // mnuFormadepagamento
            // 
            this.mnuFormadepagamento.Name = "mnuFormadepagamento";
            this.mnuFormadepagamento.Size = new System.Drawing.Size(219, 22);
            this.mnuFormadepagamento.Text = "Forma de Pagamento";
            // 
            // mnuProcedimentos
            // 
            this.mnuProcedimentos.Name = "mnuProcedimentos";
            this.mnuProcedimentos.Size = new System.Drawing.Size(219, 22);
            this.mnuProcedimentos.Text = "Procedimentos";
            // 
            // mnuSituacaoAgendamento
            // 
            this.mnuSituacaoAgendamento.Name = "mnuSituacaoAgendamento";
            this.mnuSituacaoAgendamento.Size = new System.Drawing.Size(219, 22);
            this.mnuSituacaoAgendamento.Text = "Situações de Agendamento";
            // 
            // mnuTiposCliente
            // 
            this.mnuTiposCliente.Name = "mnuTiposCliente";
            this.mnuTiposCliente.Size = new System.Drawing.Size(219, 22);
            this.mnuTiposCliente.Text = "Tipos de Clientes";
            // 
            // mnuTiposTelefone
            // 
            this.mnuTiposTelefone.Name = "mnuTiposTelefone";
            this.mnuTiposTelefone.Size = new System.Drawing.Size(219, 22);
            this.mnuTiposTelefone.Text = "Tipos de Telefone";
            // 
            // mnuSobre
            // 
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(49, 20);
            this.mnuSobre.Text = "Sobre";
            this.mnuSobre.Click += new System.EventHandler(this.mnuSobre_Click);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(38, 20);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappySmile.Properties.Resources.HappySmile;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senac - Happy Smile - Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblConexao;
        private System.Windows.Forms.ToolStripStatusLabel lblTempo;
        private System.Windows.Forms.Timer tmrPrincipal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnuPacientes;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroPacientes;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroConvenio;
        private System.Windows.Forms.ToolStripMenuItem mnuDentista;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroDentista;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroEspecialidade;
        private System.Windows.Forms.ToolStripMenuItem mnuAgendamentos;
        private System.Windows.Forms.ToolStripMenuItem mnuDominios;
        private System.Windows.Forms.ToolStripMenuItem mnuEspecialidade;
        private System.Windows.Forms.ToolStripMenuItem mnuFormadepagamento;
        private System.Windows.Forms.ToolStripMenuItem mnuProcedimentos;
        private System.Windows.Forms.ToolStripMenuItem mnuSituacaoAgendamento;
        private System.Windows.Forms.ToolStripMenuItem mnuTiposCliente;
        private System.Windows.Forms.ToolStripMenuItem mnuTiposTelefone;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
    }
}