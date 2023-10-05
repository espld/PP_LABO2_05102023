
namespace Ejercicio_integrador_laboII
{
    public partial class FmrCalculadora : Form
    {
        public FmrCalculadora()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            

        }
        private void FmrCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperacion.Items.Add("");
            cmbOperacion.Items.Add('+');
            cmbOperacion.Items.Add('-');
            cmbOperacion.Items.Add('*');
            cmbOperacion.Items.Add('/');
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void SetResultado()
        {
                  

        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FmrCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar la calculadora?", "Cerrar calculadora", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}