using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Crud1
{
    public partial class FmrPelicula : Form
    {
        public FmrPelicula()
        {
            InitializeComponent();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrTest fmr = new FmrTest();
            fmr.MdiParent = this;
            fmr.Show();

        }

        private void peliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrPelicula fmr = new FmrPelicula();
            fmr.MdiParent = this;
            fmr.Show();
        }


       
        public void controlsDisable()
        {
            txtNombre.Enabled = false;
            txtPeliculadirigida.Enabled = false;
            btnCancelar.Enabled = false;
            BtnAgregar.Enabled = false;
        }

        public void controlsEnable()
        {
            txtPeliculadirigida.Enabled = true;
            btnCancelar.Enabled = true;
            BtnAgregar.Enabled = true;
            txtNombre.Enabled = true;
        }

        public void clearControls()
        {
            txtNombre.Text = "";
            txtPeliculadirigida.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguró que quiere salir de el formulario?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguró que quiere cancelar?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) ;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtPeliculadirigida.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe escribir el titulo", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();

            }
            else
            {

                Pelicula pelicula = new Pelicula();

                if (Action == "edit")
                {
                    pelicula._fechaestreno = Convert.ToInt32(txtNombre.Text);
                }


                pelicula._peliculadirigida = txtPeliculadirigida.Text;
                pelicula._nombre = txtNombre.Text;

                string mensaje = "Esta seguro que desea guardar el registro?";
                if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //LLAMAR AL METODO PARA GUARDAR
                    if (pelicula.newEditPelicula(Action))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos se han guardado exitosamente!",
                            "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han guardado!",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }


            }

            clearControls();
            controlsDisable();


        }

       
    }


}

