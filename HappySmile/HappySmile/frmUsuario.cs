using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappySmile
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
        

        Usuario usuario = new Usuario();
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            usuario = new Usuario();
            txtPesquisa.Clear();
            txtConfirmacao.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtUsuario.Clear();
            rdbAtivo.Checked = true;
            rdbInativo.Checked = false;
            txtPesquisa.Focus();
        }

        private void CarregarGridUsuario()
        {
            try
            {
                grdDados.DataSource = usuario.Consultar();
                grdDados.Columns[0].Visible = false;
                grdDados.Columns[3].Visible = false;
                grdDados.Columns[4].Visible = false;
                //Cabecalho das colunas
                grdDados.Columns[1].HeaderText = "Usuário";
                grdDados.Columns[2].HeaderText = "Nome";
                //Cabeçalho das colunas
                grdDados.Columns[1].Width = 100;
                grdDados.Columns[2].Width = 250;
            }

            catch (Exception ex) { 
            
            MessageBox.Show("Erro -->" + ex.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void grdDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CarregarGridUsuario();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            usuario = new Usuario();
            usuario.nome = txtPesquisa.Text;
            CarregarGridUsuario();
        }

        private void PreencherFormulario()
        {
            txtUsuario.Text = usuario.login;
            txtNome.Text = usuario.nome;
            txtSenha.Text = usuario.password;
            txtConfirmacao.Text = usuario.password;
            rdbAtivo.Checked =  usuario.ativo;
            rdbInativo.Checked = !usuario.ativo;
        }
        private void grdDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                usuario = new Usuario();
                usuario.id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                usuario.Consultar();
                PreencherFormulario();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Erro -->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
