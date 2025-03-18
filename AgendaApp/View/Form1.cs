using AgendaApp.Controller;
using AgendaApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaApp
{
    public partial class Form1 : Form
    {
        UsuarioController controller = new UsuarioController();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string whatsapp = txtWhatsapp.Text;
            string email = txtEmail.Text;
            string msg = controller.AdicionarUsuario(nome, whatsapp, email);

            this.RefreshDGV(); MessageBox.Show(msg);


        }
        private void RefreshDGV()
        {
            List<Usuario> products = controller.GetUsuarios();
            dgv_Usuarios.DataSource = null;
            dgv_Usuarios.DataSource = products;
        }
    }
}
