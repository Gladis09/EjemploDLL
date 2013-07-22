using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Referenciamos al dll herramientas
using Herramientas;

namespace Operaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operaciones opera = new operaciones(); // Creamos el objeto de la clase que existe en el dll Herramientas
            int a = Convert.ToInt32(textBox1.Text); // Conviertiendo los textbox a numeros enteros
            int b = Convert.ToInt32(textBox2.Text);
            String resultado = label3.Text + " " + opera.suma(a, b); // Llamamos al método almacenado en la clase operaciones y enviamos como paramtros los números ingresados
            label3.Text = resultado; // Mostramos el resultado de la suma
        }
    }
}
