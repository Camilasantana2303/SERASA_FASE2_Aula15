using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERASA_Fase2_Aula15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void atualizarInterface()
        {
            for (int i = 0; i < Program.clientes.Count; i++)
            {
                listView1.Items.Add(Program.clientes[i].nome);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string usuarioCadastrado = txtUsuario2.Text;
            string senha = txtSenha2.Text;
            string nome = txtNome2.Text;
            int idade = 2023 - int.Parse(txtNascimento2.Text);
            Usuario usuario = new Usuario(usuarioCadastrado,senha);
            Cliente cliente = new Cliente(nome, idade, usuario);
            Program.clientes.Add(cliente);

            atualizarInterface();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            atualizarInterface();
        }
    }
}
