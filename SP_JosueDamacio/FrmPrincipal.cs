using Clases;
using MySql.Data.MySqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SP_JosueDamacio
{
    public partial class FrmPrincipal : Form
    {
        List<Barco> listaBarcos;
        AccesoDatos data;
        Barco barco;

        public List<Barco> ListaBarcos
        {
            get => listaBarcos;
            set => listaBarcos = value;
        }

        public FrmPrincipal()
        {
            InitializeComponent();

            data = new AccesoDatos("localhost", "taller");

            dGridBarcos.Hide();
            rbVerLista.Checked = true;

            listaBarcos = data.SeleccionarEmpleados();
            //hace conexion entre una table o base de datos mapeando y mostrando en la listbox
            lstBarcos.DataSource = listaBarcos;
            dGridBarcos.DataSource = listaBarcos;
            dGridBarcos.Columns["Id"].Visible = true;
            dGridBarcos.Columns["Costo"].Visible = false;
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente quiere cerrar?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            { }
            else { this.Close(); }
        }

        private void checkBoxVer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVer.Checked)
            {
                lstBarcos.Show();
            }
            else
            {
                lstBarcos.Hide();
            }
        }
        private void añadirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAñadir formulario = new FrmAñadir();
                //si el formulario requiere interaccion del usuario, se debe mostrar con ShowDialog
                if (formulario.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        bool guardado;

                        if (formulario.barcoForm is Pirata)
                        {
                            //hago conversion explicita
                            Pirata bPirtata = (Pirata)formulario.barcoForm;

                            bPirtata.Nombre = formulario.barcoForm.Nombre;
                            bPirtata.OPeracion = formulario.barcoForm.OPeracion;
                            bPirtata.Tripulacion = formulario.barcoForm.Tripulacion;
                            bPirtata.Tipo = formulario.barcoForm.Tipo;
                            guardado = data.Guardar(bPirtata);
                        }
                        else if (formulario.barcoForm is Marina)
                        {
                            Marina bMarina = (Marina)formulario.barcoForm;

                            bMarina.Nombre = formulario.barcoForm.Nombre;
                            bMarina.OPeracion = formulario.barcoForm.OPeracion;
                            bMarina.Tripulacion = formulario.barcoForm.Tripulacion;
                            bMarina.Tipo = formulario.barcoForm.Tipo;
                            guardado = data.Guardar(bMarina);
                        }

                        listaBarcos = data.SeleccionarEmpleados();
                        lstBarcos.DataSource = listaBarcos;
                        dGridBarcos.DataSource = listaBarcos;

                        MessageBox.Show("Barco añadido exitosamente");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message + "en FrmPrincipal_1");
                    }
                }
                else
                {
                    MessageBox.Show("Carga de barco cancelada");
                }

            }
            catch (MySqlException Myex)
            {
                MessageBox.Show(Myex.Message + "en FrmPrincipal_2");
            }
        }

        private void modificarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                FrmModificar formulario = new FrmModificar();

                if (formulario.ShowDialog() == DialogResult.OK)
                {
                    if (formulario.barcoMod is Pirata)
                    {
                        barco = new Pirata();

                        barco.Nombre = formulario.barcoMod.Nombre;
                        barco.Tripulacion = formulario.barcoMod.Tripulacion;
                        barco.Tipo = formulario.barcoMod.Tipo;

                        data.Modificar(barco);
                    }
                    else
                    {
                        barco = new Marina();

                        barco.Nombre = formulario.barcoMod.Nombre;
                        barco.Tripulacion = formulario.barcoMod.Tripulacion;
                        barco.Tipo = formulario.barcoMod.Tipo;

                        data.Modificar(barco);
                    }

                    listaBarcos = data.SeleccionarEmpleados();
                    lstBarcos.DataSource = listaBarcos;
                    dGridBarcos.DataSource = listaBarcos;
                    MessageBox.Show($"El barco con Id:{barco.Id} fue modificado");
                }
                else
                {
                    MessageBox.Show("Modificacion de barco cancelada");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEliminar formulario = new FrmEliminar();
                if (formulario.ShowDialog() == DialogResult.OK)
                {

                    listaBarcos = data.SeleccionarEmpleados();
                    lstBarcos.DataSource = listaBarcos;
                    dGridBarcos.DataSource = listaBarcos;
                    MessageBox.Show("Barco eliminado");
                }
                else
                {
                    MessageBox.Show("Ningun Barco eliminado");
                }
            }
            catch (MySqlException x)
            {
                MessageBox.Show(x.Message + "in FrmPrincipal");
            }
        }

        private void rbVerLista_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVerLista.Checked && checkBoxVer.Checked)
            {
                this.lstBarcos.Show();
                this.dGridBarcos.Hide();
            }
        }

        private void rbVerGrilla_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVerGrilla.Checked && checkBoxVer.Checked)
            {
                this.lstBarcos.Hide();
                this.dGridBarcos.Show();
            }
        }

        private void checkBoxVer_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBoxVer.Checked)
            {
                this.lstBarcos.Hide();
                this.dGridBarcos.Hide();
            }
            else
            {
                if (rbVerGrilla.Checked)
                {
                    this.lstBarcos.Hide();
                    this.dGridBarcos.Show();
                }
                else if (rbVerLista.Checked && checkBoxVer.Checked)
                {
                    this.lstBarcos.Show();
                    this.dGridBarcos.Hide();
                }
            }
        }

        private void ordenarlosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto no me dio tiempo de implementar");
        }
    }
}
