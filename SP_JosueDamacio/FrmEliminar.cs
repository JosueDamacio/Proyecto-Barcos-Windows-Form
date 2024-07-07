using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SP_JosueDamacio.FrmAñadir;

namespace SP_JosueDamacio
{
    public partial class FrmEliminar : Form
    {
        List<Barco> listaEmpleados;
        AccesoDatos data;
        //Barco barcoEliminar;

        public FrmEliminar()
        {
            InitializeComponent();
            data = new AccesoDatos("localhost", "taller");
            listaEmpleados = data.SeleccionarEmpleados();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombreBarco = txtNombre.Text;
            int id = int.Parse(txtId.Text);

            try
            {
                listaEmpleados = data.SeleccionarEmpleados();
                data.Eliminar(id, nombreBarco);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "FrmEliminar");
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
