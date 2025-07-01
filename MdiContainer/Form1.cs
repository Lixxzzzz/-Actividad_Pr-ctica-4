using System.Security.Cryptography;

namespace MdiContainer
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void conversorDeDivisasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDePersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDePersonasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form ejercicio1 = rgtPersonas.ventana_unica(); // Obtener la instancia única del formulario
            ejercicio1.MdiParent = this; // Establecer el formulario principal como padre
            ejercicio1.Show();
            ejercicio1.BringToFront(); // Traer el formulario al frente si ya está abierto
        }

        private void conversorDeDivisasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form ejercicio2 = csDivisa.ventana_unica();
            ejercicio2.MdiParent = this; // Establecer el formulario principal como padre
            ejercicio2.Show();
            ejercicio2.BringToFront(); // Traer el formulario al frente si ya está abierto

        }

        private void cálculoDeImpuestosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form ejercicio3 = Impuesto.ventana_unica();
            ejercicio3.MdiParent = this; // Establecer el formulario principal como padre
            ejercicio3.Show();
            ejercicio3.BringToFront();

        }

        private void fibonacciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form ejercicio4 = Fibonacci.ventana_unica();
            ejercicio4.MdiParent = this; // Establecer el formulario principal como padre
            ejercicio4.Show();
            ejercicio4.BringToFront();
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {
            tssUsuario.Text = "Yinna Rivera";
        }
    }
}
