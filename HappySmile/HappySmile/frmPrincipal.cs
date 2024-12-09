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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        DateTime login;
        private void AbrirForm(Form form)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.Name == form.Name)
                {
                    filho.Activate();
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();

        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = string.Format("Usuario: {0} ({1})",
                Global.nome, Global.usuario);

            lblConexao.Text = string.Format("Servidor: {0} | Banco: {1}",
                Global.servidor, Global.banco);


            login = DateTime.Now;
            Left = 0;
            Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
        }
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação?",
                "Happy Smile", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void tmrPrincipal_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - login;
            lblTempo.Text = string.Format("Tempo: {0}:{1}:{2}",
                ts.Hours.ToString("00"),
                ts.Minutes.ToString("00"),
                ts.Seconds.ToString("00"));
        }
        private void mnuCadastroUsuario_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmUsuario());
        }
       
    }
}
