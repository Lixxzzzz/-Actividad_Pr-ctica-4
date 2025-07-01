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
    public partial class csDivisa : Form

    {
        Dictionary<string, double> tasasCambio = new Dictionary<string, double>()
{
    {"USD", 1.0},
    {"EUR", 0.92},
    {"DOP", 59.0},
    {"JPY", 159.0}
};





        private static csDivisa instancia = null;
        public static csDivisa ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new csDivisa();
                return instancia;

            }
            return instancia;
        }
       
        public csDivisa()
        {
            InitializeComponent();

            // Agregamos las monedas a los ComboBox
            cmbDe.Items.AddRange(new object[] { "USD", "EUR", "DOP", "JPY" });
            cmbA.Items.AddRange(new object[] { "USD", "EUR", "DOP", "JPY" });

            cmbDe.SelectedIndex = 0;
            cmbA.SelectedIndex = 1;
        }





        private void btnConvertir_Click(object sender, EventArgs e)
        {


            {
                try
                {
                    double cantidad = double.Parse(txtCantidad.Text);
                    string monedaOrigen = cmbDe.SelectedItem.ToString();
                    string monedaDestino = cmbA.SelectedItem.ToString();

                    double tasaOrigen = tasasCambio[monedaOrigen];
                    double tasaDestino = tasasCambio[monedaDestino];

                    double resultado = cantidad / tasaOrigen * tasaDestino;
                    lblResultado.Text =  $"El resultado es: {cantidad} {monedaOrigen} = {resultado:F2} {monedaDestino}";
                }
                catch
                {
                    MessageBox.Show("Por favor, introduce una cantidad válida.");
                }
            }
        }

    }
}