using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabla_practicas_01
{
    public partial class Form1 : Form
    {
        int i = 0; 
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string producto, referencia, precio;

            producto = textBoxProducto.Text;
            referencia = textBoxReferencia.Text;
            precio = textBoxPrecio.Text;

            tablaDatos.Rows.Add(i, producto, referencia, precio); //Agrega una fila a la tabla

            i += 1;

            limpiar(); //Limpia los campos de texto
        }

        private void limpiar()
        {
            textBoxProducto.Text = "";
            textBoxPrecio.Text = "";
            textBoxReferencia.Text = "";

            buttonModificar.Enabled = false;
            buttonEliminar.Enabled = false;
        }
    }
}
