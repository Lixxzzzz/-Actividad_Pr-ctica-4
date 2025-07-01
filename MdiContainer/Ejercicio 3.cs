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
    public partial class Impuesto : Form
    {

        private static Impuesto instancia = null;
        public static Impuesto ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new Impuesto();
                return instancia;

            }
            return instancia;

        }
        public Impuesto()
        {
            InitializeComponent();
        }

        private void Impuesto_Load(object sender, EventArgs e)
        {
            {
                cmbImpuesto.Items.AddRange(new object[] { "50%", "10%", "5%" });
                cmbImpuesto.SelectedIndex = 0;
            }
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            {
                CalcularTotal();
            }
        }

        private void cmbImpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                CalcularTotal();
            }
        }
        private void CalcularTotal()
        {
            if (decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                string seleccion = cmbImpuesto.SelectedItem?.ToString().Replace("%", "") ?? "0";
                if (decimal.TryParse(seleccion, out decimal porcentaje))
                {
                    decimal impuesto = monto * (porcentaje / 100);
                    decimal total = monto + impuesto;
                    label1.Text = $"Total: {total:C2}";
                }
            }
            else
            {
                label1.Text = "Total: $0.00";
            }
        }


    }
}

