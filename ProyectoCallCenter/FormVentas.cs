using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCallCenter
{
    public partial class FormVentas : Form
    {
        int codigo = 1;
        public FormVentas()
        {
            InitializeComponent();
        }
        void limpiar()
        {
            txtcodigo.Text = codigo.ToString();
            txtnombres.Text = "";
            txtprecio.Text = "";
            txtproducto.Text = "";
            txtfecha.Text = "";
            txthora.Text = "";
            txtcantidad.Text = "";
            txttotal.Text = "";
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            object[] agregardato =
                       {
                    codigo.ToString(),
                    txtnombres.Text,
                    txtprecio.Text,
                    txtproducto.Text,
                    txtfecha.Text,
                    txthora.Text,
                    txtcantidad.Text,
                    txttotal.Text
                    };
            dataGridView1.Rows.Add(agregardato);

            MessageBox.Show("Venta Registrada.", "Mensaje");
            codigo++;
            txtcodigo.Text = codigo.ToString();
            limpiar();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtcodigo.Text = codigo.ToString();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#1760D6");
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int fil = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(fil);
                MessageBox.Show("Venta eliminada.", "Mensaje");
            }
            limpiar();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int indice = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows[indice].Cells[0].Value = txtcodigo.Text;
                dataGridView1.Rows[indice].Cells[1].Value = txtnombres.Text;
                dataGridView1.Rows[indice].Cells[2].Value = txtprecio.Text;
                dataGridView1.Rows[indice].Cells[3].Value = txtproducto.Text;
                dataGridView1.Rows[indice].Cells[4].Value = txtfecha.Text;
                dataGridView1.Rows[indice].Cells[5].Value = txthora.Text;
                dataGridView1.Rows[indice].Cells[5].Value = txtcantidad.Text;
                dataGridView1.Rows[indice].Cells[5].Value = txttotal.Text;
                MessageBox.Show("Venta modificada.", "Mensaje");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int fila = dataGridView1.CurrentCell.RowIndex;
                txtcodigo.Text = dataGridView1[0, fila].Value.ToString();
                txtnombres.Text = dataGridView1[1, fila].Value.ToString();
                txtprecio.Text = dataGridView1[2, fila].Value.ToString();
                txtproducto.Text = dataGridView1[3, fila].Value.ToString();
                txtfecha.Text = dataGridView1[4, fila].Value.ToString();
                txthora.Text = dataGridView1[5, fila].Value.ToString();
                txtcantidad.Text = dataGridView1[6, fila].Value.ToString();
                txttotal.Text = dataGridView1[7, fila].Value.ToString();
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double total;
            total = double.Parse(txtprecio.Text) * double.Parse(txtcantidad.Text);
            txttotal.Text = total.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
