namespace ProyectoCiber.Desktop
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnPC_Click_Click(object sender, EventArgs e)
        {
            try
            {
                FormPC formPC = new FormPC();
                formPC.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario de gestión de PCs: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTurnos_Click_Click(object sender, EventArgs e)
        {
            try
            {
                FormTurno formTurno = new FormTurno();
                formTurno.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario de gestión de PCs: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
