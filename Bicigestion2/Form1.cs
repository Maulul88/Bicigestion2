using BLL;
using Entity;

namespace Bicigestion2
{
    public partial class Form1 : Form
    {
        private AlquilerBusiness alquilerBusiness = new AlquilerBusiness();
        private TipoBicicletaBusiness tipoBicicletaBusiness = new TipoBicicletaBusiness();
        private List<Alquiler> alquileresPendientes = new List<Alquiler>();
        public Form1()
        {
            InitializeComponent();
        }
        private void CargarTiposBicicleta()
        {
            try
            {
                cmbTipoBicicleta.DataSource = null;
                cmbTipoBicicleta.DataSource = tipoBicicletaBusiness.GetAll();
                cmbTipoBicicleta.DisplayMember = "Descripcion";
                cmbTipoBicicleta.ValueMember = "IdTipoBicicleta";
            }
            catch
            {
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CargarTiposBicicleta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Alquiler CrearAlquiler()
        {
            try
            {
                if (!decimal.TryParse(txtImporte.Text, out decimal importe))
                {
                    throw new Exception("El importe debe ser numérico.");
                }

                TipoBicicleta tipo = (TipoBicicleta)cmbTipoBicicleta.SelectedItem;

                Alquiler alquiler;

                if (tipo.Descripcion == "Urbana")
                {
                    alquiler = new AlquilerUrbana();
                }
                else if (tipo.Descripcion == "Montaña")
                {
                    alquiler = new AlquilerMontana();
                }
                else
                {
                    alquiler = new AlquilerElectrica();
                }

                alquiler.TipoBicicleta = tipo;
                alquiler.DniCliente = txtDni.Text;
                alquiler.ImporteTotal = importe;
                alquiler.FechaRegistro = DateTime.Now;
                alquiler.FechaAlquiler = dtpFechaAlquiler.Value;

                return alquiler;
            }
            catch
            {
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Alquiler alquiler = CrearAlquiler();

                alquilerBusiness.ValidarAlquiler(alquiler);

                alquileresPendientes.Add(alquiler);

                dgvPendientes.DataSource = null;
                dgvPendientes.DataSource = alquileresPendientes.ToList();

                LimpiarCarga();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LimpiarCarga()
        {
            txtDni.Clear();
            txtImporte.Clear();
            dtpFechaAlquiler.Value = DateTime.Now;
        }

        private void btnConfirmarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                alquilerBusiness.CargarMultiplesAlquileres(alquileresPendientes);

                MessageBox.Show("Alquileres guardados correctamente.");

                alquileresPendientes.Clear();
                dgvPendientes.DataSource = null;

                CargarAlquileres();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarAlquileres()
        {
            try
            {
                dgvAlquileres.DataSource = null;
                dgvAlquileres.DataSource = alquilerBusiness.GetAll();
            }
            catch
            {
                throw;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarAlquileres();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIdModificar.Text);
                decimal importe = Convert.ToDecimal(txtNuevoImporte.Text);
                DateTime fecha = dtpNuevaFecha.Value;

                alquilerBusiness.Modificar(id, importe, fecha);

                MessageBox.Show("Alquiler modificado correctamente.");

                CargarAlquileres();

                txtIdModificar.Clear();
                txtNuevoImporte.Clear();
                dtpNuevaFecha.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIdEliminar.Text);

                alquilerBusiness.Eliminar(id);

                MessageBox.Show("Alquiler eliminado correctamente.");

                CargarAlquileres();

                txtIdEliminar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAlquileres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvAlquileres.Rows[e.RowIndex];

                    txtIdModificar.Text = fila.Cells["IdAlquiler"].Value.ToString();
                    txtIdEliminar.Text = fila.Cells["IdAlquiler"].Value.ToString();
                    txtNuevoImporte.Text = fila.Cells["ImporteTotal"].Value.ToString();
                    dtpNuevaFecha.Value = Convert.ToDateTime(fila.Cells["FechaAlquiler"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
