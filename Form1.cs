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
        int fila;
        
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

        private void tablaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablaDatos_CellClick(object sender, DataGridViewCellEventArgs e) //Evento que se ejecuta al hacer click en una celda
        {
            //Capturamos la fila seleccionada al hacer click en una celda
            fila = tablaDatos.CurrentRow.Index;

            //Mostramos los datos de la fila seleccionada
            textBoxProducto.Text = tablaDatos[1, fila].Value.ToString();
            textBoxReferencia.Text = tablaDatos[2, fila].Value.ToString();
            textBoxPrecio.Text = tablaDatos[3, fila].Value.ToString();

            buttonModificar.Enabled = true;  //Habilitamos el botón modificar
            buttonEliminar.Enabled = true;  //Habilitamos el botón eliminar
            buttonAgregar.Enabled = false;  //Deshabilitamos el botón agregar
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            limpiar(); //Limpia los campos de texto

            buttonAgregar.Enabled = true;  //Habilitamos el botón agregar
        }
    }
}
