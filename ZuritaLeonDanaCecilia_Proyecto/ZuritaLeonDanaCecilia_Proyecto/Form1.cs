using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Esta pantalla es la ventana principal
namespace ZuritaLeonDanaCecilia_Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Al hacer click se envia a la ventana correspondiente
        private void ejercicio_Click(object sender, EventArgs e)
        {
            
            Form ejer = new imp();
            ejer.Show();
        }

        //Al hacer click se envia a la ventana correspondiente
        private void enfermedades_Click(object sender, EventArgs e)
        {
            Form enfermedades = new evitar();
            enfermedades.Show();
        }

        //Al hacer click se envia a la ventana correspondiente
        private void imc_Click(object sender, EventArgs e)
        {
            Form calculo = new imc();
            calculo.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
