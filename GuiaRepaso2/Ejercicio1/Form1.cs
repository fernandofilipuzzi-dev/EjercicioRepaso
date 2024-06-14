using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Controlador ejemplo=new Controlador();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            FormRegistro registro = new FormRegistro();
            ;
            if (registro.ShowDialog() == DialogResult.OK)
            {
                string nombre = registro.textBox1.Text;
                int dni = Convert.ToInt32(registro.textBox2.Text);
                double nota = Convert.ToDouble(registro.textBox3.Text);
                ejemplo.AgregarAlumno(nombre, dni, nota); 

            }
        }
    }
}
