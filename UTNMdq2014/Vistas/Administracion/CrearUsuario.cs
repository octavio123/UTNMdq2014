using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UTNMdq2014.Vistas.Administracion
{
    public partial class CrearUsuario : Form
    {
        private List<Modelos.Usuario> usuarios;
        public Modelos.Usuario Resultado { get; private set; }

        public CrearUsuario(List<Modelos.Usuario> usuarios)
        {
            this.usuarios = usuarios;
            InitializeComponent();

            foreach (var tipo in Enum.GetValues(typeof(Modelos.UsuarioTipo)))
            {
                cbTipoUsuario.Items.Add(tipo);
            }
            cbTipoUsuario.SelectedItem = cbTipoUsuario.Items[1];
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;

            if (usuarios.Where((usuario) => usuario.Nombre == nombre).Count<Modelos.Usuario>() > 0)
            {
                MensajeUsuarioExistente();
                return;
            }

            if (tbContraseña.Text != tbConfirmacionContraseña.Text)
            {
                MensajeLaContraseñaNoConcuerda();
                return;
            }

            // Si paso la comprobacion
            Resultado = new Modelos.Usuario(tbNombre.Text, tbContraseña.Text, (Modelos.UsuarioTipo)cbTipoUsuario.SelectedItem);
            DialogResult = DialogResult.OK;
        }

        private void MensajeUsuarioExistente()
        {
            MessageBox.Show(
                "El nombre de usuario no se encuentra disponible",
                "Nombre de usuario");
        }

        private void MensajeLaContraseñaNoConcuerda()
        {
            MessageBox.Show(
                "Las contraseñas insertadas no concuerdan",
                "Contraseña incorrecta");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
