using Clases;
using Clases.Excepciones;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SP_JosueDamacio
{
    public partial class FrmAñadir : Form
    {
        List<Barco> listaBarcos;
        AccesoDatos data; 
        public Barco barcoForm;

        public FrmAñadir()
        {
            InitializeComponent();

            data = new AccesoDatos("localhost", "taller");

            foreach (EOperacion p in Enum.GetValues(typeof(EOperacion)))
            {
                cmBoxOperacion.Items.Add(p);
            }
            foreach (ETipoBarco p in Enum.GetValues(typeof(ETipoBarco)))
            {
                cmBoxTipo.Items.Add(p);
            }
            
            listaBarcos = data.SeleccionarEmpleados();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

            try
            {
                string nombre = txtNombre.Text;
                //lo intente parsear de mil maneras jafhasjs
                ETipoBarco tipo = (ETipoBarco)Enum.Parse(typeof(ETipoBarco), cmBoxTipo.Text);
                EOperacion operacion = (EOperacion)Enum.Parse(typeof(EOperacion), cmBoxOperacion.Text);
                int tripulacion = int.Parse(txtTripulacion.Text);

                if (tipo == ETipoBarco.Marina)
                {
                    barcoForm = new Marina(nombre, tipo, operacion, tripulacion);
                }
                else if (tipo == ETipoBarco.Pirata)
                {
                    barcoForm = new Pirata(nombre, tipo, operacion, tripulacion);
                }

                foreach (var barco in listaBarcos)
                {
                    if (barcoForm == barco)
                    {
                        MessageBox.Show($"El barco con el nombre {barcoForm.Nombre} ya está en el taller. Elige otro nombre");
                        return;
                    }
                }

                //data.InsertarEmpleado(empleadoDelForm);
                this.DialogResult = DialogResult.OK;
                LimpiarTxtBoxes();
            }
            catch (FormatException ex)
            {
                var excepcion = new DatoInvalidoException("Datos no validos, error al intentar añadir", ex.Message);
                MessageBox.Show(excepcion.Message);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void LimpiarTxtBoxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Clear();

                }
            }
        }
    }
}
