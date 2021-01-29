using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZuritaLeonDanaCecilia_Proyecto
{
    public partial class imc : Form
    {
        public imc()
        {
            InitializeComponent();
        }

       //Si el usuario hace click enn el boton calcular 
        private void btnCalculo_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            double imc, peso, estatura;
            
            //Si los cuadros de texto estan vacios o tienen un valor igual a cero ejecutar el siguiente codigo
            if ((txtEstatura.Text == "0") || (txtPeso.Text == "0") || (txtEstatura.Text == " ") || (txtPeso.Text == " "))
            {
                //Aparece un recuadro con el siguiente mensaje 
                MessageBox.Show("Ingrese datos validos");
            }
            //Si no se cumpe la condición
            else
            {
                peso = double.Parse(txtPeso.Text);
                estatura = double.Parse(txtEstatura.Text);
                imc = Math.Round(peso /(double)Math.Pow(estatura,2),2);

                //Si el cuadro que genero esta selecciondo Mujer
                if (rbMujer.Checked == true)
                {
                    //Dependiendo el valor obtenido en la operación  es el texto que se imprime en el recuadro imc
                    if (imc < 18.5)
                    {
                        txtFin.Text = ("Su IMC es: " + imc);
                        txtFin2.Text = ("Su peso es bajo");
                        imagen1.Image = Properties.Resources.m1;
                    }
                    else
                    {
                        if (imc >= 18.5 && imc <= 24.9)
                        {
                            txtFin.Text = ("Su IMC es: " + imc);
                            txtFin2.Text = ("Su peso es normal");
                            imagen1.Image = Properties.Resources.m2;
                        }
                        else
                        {
                            if (imc >= 25 && imc <= 29.9)
                            {
                                txtFin.Text = ("Su IMC es: " + imc);
                                txtFin2.Text = ("Preobesidad");
                                imagen1.Image = Properties.Resources.m3;
                            }
                            else
                            {
                                if (imc == 30)
                                {
                                    txtFin.Text = ("Su IMC es: " + imc);
                                    txtFin2.Text = ("Obesidad");
                                    imagen1.Image = Properties.Resources.m4;
                                }
                                else
                                {
                                    if (imc > 30 && imc <= 34.9)
                                    {
                                        txtFin.Text = ("Su IMC es: " + imc);
                                        txtFin2.Text = ("Obesidad clase I");
                                        imagen1.Image = Properties.Resources.m5;
                                    }
                                    else
                                    {
                                        if (imc >= 35 && imc <= 39.9)
                                        {
                                            txtFin.Text = ("Su IMC es: " + imc);
                                            txtFin2.Text = ("Obesidad clase II");
                                            imagen1.Image = Properties.Resources.m6;
                                        }
                                        else
                                        {
                                            if (imc >= 40)
                                            {
                                                txtFin.Text = ("Su IMC es: " + imc);
                                                txtFin2.Text = ("Obesidad clase III");
                                                imagen1.Image = Properties.Resources.m7;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
                else
                {
                    //Si en el recuadro de genero esta seleccionado hombre se realiza el siguiente codigo
                    if (rbHombre.Checked == true)
                    {
                        //Dependiendo el valor obtenido en la operación  es el texto que se imprime en el recuadro imc
                        if (imc < 18.5)
                        {
                            txtFin.Text = ("Su IMC es: " + imc);
                            txtFin2.Text = ("Su peso es bajo");
                            imagen1.Image = Properties.Resources.h1;
                        }
                        else
                        {
                            if (imc >= 18.5 && imc <= 24.9)
                            {
                                txtFin.Text = ("Su IMC es: " + imc);
                                txtFin2.Text = ("Su peso es normal");
                                imagen1.Image = Properties.Resources.h2;
                            }
                            else
                            {
                                if (imc >= 25 && imc <= 29.9)
                                {
                                    txtFin.Text = ("Su IMC es: " + imc);
                                    txtFin2.Text = ("Preobesidad");
                                    imagen1.Image = Properties.Resources.h3;
                                }
                                else
                                {
                                    if (imc == 30)
                                    {
                                        txtFin.Text = ("Su IMC es: " + imc);
                                        txtFin2.Text = ("Obesidad");
                                        imagen1.Image = Properties.Resources.h4;
                                    }
                                    else
                                    {
                                        if (imc > 30 && imc <= 34.9)
                                        {
                                            txtFin.Text = ("Su IMC es: " + imc);
                                            txtFin2.Text = ("Obesidad clase I");
                                            imagen1.Image = Properties.Resources.h5;
                                        }
                                        else
                                        {
                                            if (imc >= 35 && imc <= 39.9)
                                            {
                                                txtFin.Text = ("Su IMC es: " + imc);
                                                txtFin2.Text = ("Obesidad clase II");
                                                imagen1.Image = Properties.Resources.h6;
                                            }
                                            else
                                            {
                                                if (imc >= 40)
                                                {
                                                    txtFin.Text = ("Su IMC es: " + imc);
                                                    txtFin2.Text = ("Obesidad clase III");
                                                    imagen1.Image = Properties.Resources.h7;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                
                }
                
            }

            
        }

        //Si el usuario presiona el boton salir se cierra la pagina para calcular el imc y regresa a la ventana principal
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        //Dar click en el boton Limpiar borra los datos ingresados por el usuario ademas de borrar los datos obtenidos por lo que ingreso
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFin.Text = " ";
            txtPeso.Text = " ";
            txtEstatura.Text = " ";
            txtFin2.Text = " ";
            imagen1.Image = null;

        }

        //Valida que solo se ingresen números y puntos en el cuadro de texto del peso
        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtEstatura.Focus();
            }
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puede ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        //Valida que solo se ingresen números y puntos en el cuadro de texto de estatura
        private void txtEstatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnCalculo.Focus();
            }
            if ((e.KeyChar >= 32 && e.KeyChar <= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puede ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void rbHombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void imc_Load(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstatura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
