using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSAula03_Login
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Size = new Size(377, 227);

        }
        public static int saldo = 0;
        public static int saldoFinal = 0;



        private void btnConectar_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string senha = txtPass.Text;

            if (usuario == "Conradito" && senha == "123")
            {
                MessageBox.Show($"Logado com sucesso no usuário: {usuario} !!");

                panelSaldo.Visible = true;
                Size = new Size(726, 244);



            }
            else if (usuario == "" || senha == "")
            {
                MessageBox.Show("Digita alguma coisa véinho !!");
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos !!");
                txtPass.Clear();
                txtUser.Clear();
            }


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (chkAumentar.Checked)
            {
                saldoFinal = saldoFinal + int.Parse(txtAumentar.Text);
                lblSaldo.Text = $"Seu saldo: R$ {saldoFinal}";
                txtAumentar.Clear();
            }
        }
    }
}
