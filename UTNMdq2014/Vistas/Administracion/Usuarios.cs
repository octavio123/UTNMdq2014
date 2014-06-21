using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTNMdq2014.Vistas.Administracion;

namespace UTNMdq2014.Vistas.Administracion
{
    public partial class Usuarios : Form
    {
        private BindingList<Modelos.Usuario> dataSource;
        private Datos.UsuarioRepositorio repositorio;

        private BindingList<Modelos.Usuario> DataSource 
        {
            set
            {
                dataSource = value;
                if (dataSource != null)
                {
                    dgvUsuarios.DataSource = dataSource;
                }
            }
        }

        public Usuarios()
        {
            InitializeComponent();

            this.repositorio = new Datos.UsuarioRepositorio();
            DataSource = this.repositorio.Usuarios;
            dgvUsuarios.Columns["Contraseña"].Visible = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            repositorio.Dispose();
            base.OnClosing(e);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CrearUsuario form = new CrearUsuario(this.repositorio.Usuarios.ToList());
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                repositorio.Usuarios.Add(form.Resultado);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                foreach (var selected in dgvUsuarios.SelectedRows)
                {
                    repositorio.Usuarios.Remove(selected as Modelos.Usuario);
                    DataGridViewRow row = selected as DataGridViewRow;
                    if (!row.IsNewRow)
                    {
                        dgvUsuarios.Rows.Remove(selected as DataGridViewRow);
                    }
                }

            }

        }
    }
}
