using Clases;
using Clases.Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_JosueDamacio
{
    public partial class FrmModificar : Form
    {
        List<Barco> listaBarcos;
        AccesoDatos data;
        public Barco barcoMod;

        public FrmModificar()
        {
            InitializeComponent();

            data = new AccesoDatos("localhost", "taller");

            listaBarcos = data.SeleccionarEmpleados();
            dGridBarcos.DataSource = listaBarcos;
            dGridBarcos.Columns["Id"].Visible = false;
            dGridBarcos.Columns["Costo"].Visible = false;
            dGridBarcos.Columns["OPeracion"].Visible = false;
            dGridBarcos.Columns["EstadoReparado"].Visible = false;

            foreach (ETipoBarco p in Enum.GetValues(typeof(ETipoBarco)))
            {
                cmBoxTipo.Items.Add(p);
            }
        }

        private void FrmModificarEliminar_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente quiere cerrar?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            { }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnHecho_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dGridBarcos.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                ETipoBarco tipo = (ETipoBarco)Enum.Parse(typeof(ETipoBarco), cmBoxTipo.Text);
                if (tipo == ETipoBarco.Marina)
                {
                    barcoMod = new Marina();
                }
                else
                {
                    barcoMod = new Pirata();
                }

                barcoMod.Nombre = txtNombreBarco.Text;
                barcoMod.Tipo = tipo;

                this.DialogResult = DialogResult.OK;
            }
            catch (FormatException ex)
            {
                var excepcion = new DatoInvalidoException("Datos no validos, error al intentar modificar", ex.Message);
                MessageBox.Show(excepcion.Message);
            }
        }

        private void dGridBarcos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGridBarcos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dGridBarcos.SelectedRows[0];

                // obtengo el dato de las columnasd e la fila seleccionada
                txtNombreBarco.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                cmBoxTipo.Text = filaSeleccionada.Cells["tipo"].Value.ToString();
            }
        }
    }
}
