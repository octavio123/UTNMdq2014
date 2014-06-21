using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTNMdq2014.Datos;
using UTNMdq2014.Login;
using UTNMdq2014.Modelos;

namespace UTNMdq2014.Vistas
{
    public partial class DialogoLogin : Form
    {
        public DialogoLogin()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Usuario usuario = null;

            if (string.IsNullOrEmpty(tbContraseña.Text))
            {
                MensajeDatosIncorrectos();
                return;
            }

            using (var repo = new UsuarioRepositorio())
            {
                var resultado = repo.Usuarios.Where((user) => user.Nombre == tbUsername.Text);
                if (resultado.Count<Usuario>() > 0) {
                    usuario = resultado.Single();
                }

                // Comparar la hash del usuario que hizo login con la hash del usuario guardado
                if (usuario != null &&
                    !usuario.Contraseña.Equals(PasswordHashFactory.HashPasswordWithSalt(tbContraseña.Text, usuario.Contraseña.Salt))) {
                    usuario = null;
                }
            }

            if (usuario == null)
            {
                MensajeDatosIncorrectos();
                return;
            }

            MensajeAccesoAutorizado(usuario.Tipo);

            Principal mainForm = new Principal(this);
            Hide();
            mainForm.Show();
            
        }

        private void MensajeAccesoAutorizado(UsuarioTipo tipo)
        {
            MessageBox.Show(
                "Acceso autorizado de " + tipo,
                "Bienvenido",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        private void MensajeDatosIncorrectos()
        {
            MessageBox.Show(
                "No existe el usuario especificado o la constraseña es incorrecta",
                "Datos incorrectos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
