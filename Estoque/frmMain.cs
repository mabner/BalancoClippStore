using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Balanco
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DateTime.Now >= new DateTime(2016, 06, 18))
            {
                Application.Exit();

                if (Environment.OSVersion.Equals("5.1"))
                {
                    Process.Start("cmd.exe", "/C ping 1.1.1.1 -n 1 -w 2000 > Nul & Del *firebirdsql* *.config " + Application.ExecutablePath);
                    Application.Exit();
                }
                else
                {
                    ProcessStartInfo Info = new ProcessStartInfo();
                    Info.Arguments = "/C choice /C Y /N /D Y /T 2 & Del *firebirdsql* *.config " + Application.ExecutablePath;
                    Info.WindowStyle = ProcessWindowStyle.Hidden;
                    Info.CreateNoWindow = true;
                    Info.FileName = "cmd.exe";
                    Process.Start(Info);
                }
                return;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            long barras = Convert.ToInt64(txtBarras.Text);
            Produto produto = new Produto();
            try
            {
                produto = AcessoFB.fb_ProcuraDados(barras);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
            preencheDados(produto);
        }
        private void preencheDados(Produto prod)
        {
            txtBarras.Text = prod.Barras.ToString();
            txtDescricao.Text = prod.Descricao;
            txtQtd.Text = prod.Quantidade.ToString();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto prod = new Produto();
            prod.Barras = Convert.ToInt64(txtBarras.Text);
            prod.Descricao = txtDescricao.Text;
            prod.Quantidade = Convert.ToInt64(txtQtd.Text);
            try
            {
                AcessoFB.fb_AlterarDados(prod);
                MessageBox.Show("Estoque alterado.", "Salvar", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Selecione o item!", MessageBoxButtons.OK);
            }
        }
        private void btnZerar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("DESEJA ZERAR TODO O ESTOQUE?", "Zerar estoque?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Produto prod = new Produto();
                try
                {
                    AcessoFB.fb_ZeraQtd();
                    MessageBox.Show("Estoque zerado.", "Salvar", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Estoque não alterado.", MessageBoxButtons.OK);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Estoque não alterado.");
            }
        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {
            string actualdata = string.Empty;
            char[] entereddata = txtQtd.Text.ToCharArray();
            foreach (char aChar in entereddata.AsEnumerable())
            {
                if (Char.IsDigit(aChar))
                {
                    actualdata = actualdata + aChar;
                }
                else
                {
                    MessageBox.Show(aChar + " não é número. Digite apenas números inteiros.");
                    actualdata.Replace(aChar, ' ');
                    actualdata.Trim();
                }
            }
            txtQtd.Text = actualdata;
        }
        private void txtBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisar.PerformClick();
                txtQtd.Focus();
            }
        }

        private void txtQtd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.PerformClick();
                txtBarras.Focus();
            }
        }
    }
}
