using Microsoft.EntityFrameworkCore;
using ProyectoCiber.Data;
using ProyectoCiber.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCiber.Desktop
{
    public partial class FormTurno : Form
    {
        public FormTurno()
        {
            InitializeComponent();
            CargarTurnos();
          

            CargarIdsDisponibles();
        }
    

        private void CargarTurnos()
        {
            try
            {
                using var db = new NuevoTurnoDBContext();
                var turnos = db.Turnos.Include(t => t.PC).ToList();
                dgvTurnos.DataSource = turnos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar turnos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearTurno_Click(object sender, EventArgs e)
        {

            try
            {
                // Validar que haya una ID de PC seleccionada
                if (cbIdPC.SelectedItem == null || cbIdPC.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione un ID válido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(cbIdPC.SelectedValue.ToString(), out int idPC))
                {
                    MessageBox.Show("El ID seleccionado no es válido. Por favor, seleccione un ID numérico.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var db = new NuevoTurnoDBContext();

                // Obtener la PC seleccionada por su ID para conocer su tipo
                var pcSeleccionada = db.PCs.FirstOrDefault(p => p.Id == idPC);

                if (pcSeleccionada == null)
                {
                    MessageBox.Show("La PC seleccionada no existe.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear el turno con la información obtenida
                var turno = new Turno
                {
                    PCId = idPC,
                    HorarioDeInicio = dtInicio.Value
                };

                db.Turnos.Add(turno);
                db.SaveChanges();

                MessageBox.Show("Turno creado exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarTurnos(); // Refrescar el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el turno: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            
            dtInicio.Value = DateTime.Now;
        }

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvTurnos.Rows[e.RowIndex];

                    // Cargar datos del turno seleccionado en los controles
                    var pcIdValue = row.Cells["PCId"]?.Value?.ToString();
                    if (!string.IsNullOrEmpty(pcIdValue) && int.TryParse(pcIdValue, out int id))
                    {
                        cbIdPC.SelectedValue = id;
                    }

                    if (row.Cells["HorarioDeInicio"]?.Value != null)
                    {
                        string fechaString = row.Cells["HorarioDeInicio"].Value?.ToString() ?? string.Empty;

                        if (DateTime.TryParse(fechaString, out DateTime fecha))
                        {
                            dtInicio.Value = fecha;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al seleccionar el turno: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormTurno_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            ;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarIdsDisponibles()
        {
            try
            {
                using var db = new NuevoTurnoDBContext();
                var pcs = db.PCs.ToList();
                cbIdPC.DataSource = pcs;
                cbIdPC.DisplayMember = "Id";     // Muestra el ID
                cbIdPC.ValueMember = "Id";       // Usa el ID como valor
                cbIdPC.SelectedIndex = -1;       // Sin selección inicial
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar IDs disponibles: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtpcid_Leave(object sender, EventArgs e)
        {
          
        }
    }
}
