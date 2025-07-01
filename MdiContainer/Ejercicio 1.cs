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
    public partial class rgtPersonas : Form
    {
        private static rgtPersonas instancia = null;
        public static rgtPersonas ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new rgtPersonas();
                return instancia;

            }
            return instancia;

        }

        public rgtPersonas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string[] fila = new string[12];

                fila[0] = txtNombre.Text;
                fila[1] = txtApellido.Text;
                fila[2] = txtCedula.Text;
                fila[3] = dtpFechaNacimiento.Text;
                fila[4] = txtTelefono.Text;
                fila[5] = txtCorreo.Text;
                fila[6] = txtDireccion.Text;
                fila[7] = txtCiudad.Text;
                fila[8] = txtpais.Text;
                fila[9] = cbGenero.SelectedItem?.ToString() ?? "";
                fila[10] = cbEstadoCivil.SelectedItem?.ToString() ?? "";
                fila[11] = txtOcupacion.Text;




                dataGridView1.Rows.Add(fila);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



    }
}


