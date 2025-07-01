using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiContainer
{
    public partial class Fibonacci : Form
    {
        private static Fibonacci instancia = null;
        public static Fibonacci ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new Fibonacci();
                return instancia;

            }
            return instancia;

        }
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();

            if (int.TryParse(txtLimite.Text, out int limite) && limite >= 0)
            {
                List<int> fibonacci = new List<int> { 0, 1 };

                while (fibonacci.Last() + fibonacci[fibonacci.Count - 2] <= limite)
                {
                    fibonacci.Add(fibonacci.Last() + fibonacci[fibonacci.Count - 2]);
                }

                txtResultado.Text = string.Join(", ", fibonacci.Where(n => n <= limite));
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número entero válido mayor o igual a 0.");
            }
        }

    }
}
