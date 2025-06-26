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
    public partial class FormPC : Form
    {
        public FormPC()
        {
            InitializeComponent();
            CargarPCs();
        }
        private void CargarPCs()
        {
            try
            {
                using var db = new NuevoTurnoDBContext();
                // Cargar la lista de PCs desde la base de datos
                var pcs = db.PCs.ToList();
                dgvPCs.DataSource = pcs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPCs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPCs.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id"]?.Value?.ToString() ?? "";
                txtTipo.Text = row.Cells["Tipo"]?.Value?.ToString() ?? "";
                txtGama.Text = row.Cells["Gama"]?.Value?.ToString() ?? "";
                txtDuracion.Text = row.Cells["Duracion"]?.Value?.ToString() ?? "";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar campos antes de proceder
            if (string.IsNullOrWhiteSpace(txtTipo.Text) ||
                string.IsNullOrWhiteSpace(txtGama.Text) ||
                string.IsNullOrWhiteSpace(txtDuracion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtDuracion.Text, out int duracion))
            {
                MessageBox.Show("La duración debe ser un número válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var db = new NuevoTurnoDBContext();
            var pc = new PC
            {
                Tipo = txtTipo.Text.Trim(),
                Gama = txtGama.Text.Trim(),
                Duracion = duracion
            };

            db.PCs.Add(pc);
            db.SaveChanges();

            MessageBox.Show("PC agregado exitosamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
            CargarPCs();
        }




        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya seleccionado un ID
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Por favor, seleccione un PC para actualizar.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar campos
                if (string.IsNullOrWhiteSpace(txtTipo.Text) ||
                    string.IsNullOrWhiteSpace(txtGama.Text) ||
                    string.IsNullOrWhiteSpace(txtDuracion.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtId.Text, out int id) ||
                    !int.TryParse(txtDuracion.Text, out int duracion))
                {
                    MessageBox.Show("ID y Duración deben ser números válidos.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var db = new NuevoTurnoDBContext();
                var pc = db.PCs.Find(id);

                if (pc != null)
                {
                    pc.Tipo = txtTipo.Text.Trim();
                    pc.Gama = txtGama.Text.Trim();
                    pc.Duracion = duracion;

                    db.SaveChanges();

                    MessageBox.Show("PC actualizado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                    CargarPCs();
                }
                else
                {
                    MessageBox.Show("No se encontró el PC con el ID especificado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el PC: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                // Validar que se haya seleccionado un ID
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Por favor, seleccione un PC para eliminar.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtId.Text, out int id))
                {
                    MessageBox.Show("ID debe ser un número válido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmar eliminación
                var resultado = MessageBox.Show("¿Está seguro de que desea eliminar este PC?",
                    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    using var db = new NuevoTurnoDBContext();
                    var pc = db.PCs.Find(id);

                    if (pc != null)
                    {
                        db.PCs.Remove(pc);
                        db.SaveChanges();

                        MessageBox.Show("PC eliminado exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarCampos();
                        CargarPCs();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el PC con el ID especificado.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el PC: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtTipo.Text = "";
            txtGama.Text = "";
            txtDuracion.Text = "";
        }
        private void FormPC_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
