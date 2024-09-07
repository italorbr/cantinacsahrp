using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Cantina
{
    public partial class frmFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        public frmFuncionarios()
        {
            InitializeComponent();
            desabilitarCampos();
            //executando o metodo para desabilitar campos
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        // metodo para desabilitar campos
        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtNome.Enabled = false;
            txtNumero.Enabled = false;
            mkbCEP.Enabled = false;
            mkbCPF.Enabled = false;
            mkbTelefone.Enabled = false;
            cbbEstado.Enabled = false;
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
         
        }

        // metodo para desabilitar campos
        public void habilitarCampos()
        {
            txtCodigo.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNome.Enabled = true;
            txtNumero.Enabled = true;
            mkbCEP.Enabled = true;
            mkbCPF.Enabled = true;
            mkbTelefone.Enabled = true;
            cbbEstado.Enabled = true;
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
            txtNome.Focus();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //verificando se os campos estão preenchidos
            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("")
                || mkbCPF.Text.Equals("   .   .   -")
                || mkbCEP.Text.Equals("     -")
                || mkbTelefone.Text.Equals("     -")
                || txtEndereco.Text.Equals("")
                || txtNumero.Text.Equals("")
                || txtBairro.Text.Equals("")
                || txtCidade.Text.Equals("")
                || cbbEstado.Text.Equals(""))
            {
                //message box com o simbolo do x vermelho dentro e o botao 
                MessageBox.Show("Por favor, preencha todos os campos.", "Sistema",MessageBoxButtons.OK,
                    MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
            
        }
    }
}
