using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoCallCenter.BD;
using ProyectoCallCenter.Bean;
using ProyectoCallCenter.Dao;

namespace ProyectoCallCenter
{
    public partial class FormLogin : Form
    {
        Usuario Usuario;
        daoUsuario daoUsuario = new daoUsuario();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            
            
                Usuario = new Usuario();
                Usuario.User = txtusuario.Text;
                Usuario.Password = txtcontraseña.Text;
                daoUsuario.ValidaLogin(Usuario);
                MessageBox.Show(Usuario.Valido ? "Bienvenido " + Usuario.User + " " : "Usuario y/o contraseña inválidos");            
                FormVentas form = new FormVentas();
                form.Show();
                

        }
    }
}
