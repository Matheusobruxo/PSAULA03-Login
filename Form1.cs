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
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string usuario= txtUser.Text;
            string senha = txtPass.Text;

            if (usuario== "Conradito" && senha == "123")
            {
                MessageBox.Show($"Logado com sucesso no usuário: {usuario} !!");
                panelSaldo.Visible = true;

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
    }
}
