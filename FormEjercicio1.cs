using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_Estructuras_De_Control
{
    public partial class FormEjercicio1 : Form
    {
        public FormEjercicio1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConvertir_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    throw new ArgumentException("El campo nombre no puede estar vacío");
                }
                string nombre = txtNombre.Text;
                double x = (double)notaNum.Value;
                string Nota = "Vacia";
                CalcularNotas(x, ref Nota);
                lblCalificacion.Text = $"La calificacion de {nombre} es {Nota}";
            }
            catch (ArgumentException ex) when (ex.Message.Contains("vacío"))
            {
                MessageBox.Show("Error: tenes que ingresar un nombre");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CalcularNotas(double x, ref string Nota)
        {
            if (x >= 90)
            {
                Nota = "A";
            }
            else if (x >= 80)
            {
                Nota = "B";
            }
            else if (x >= 70)
            {
                Nota = "C";
            }
            else if (x >= 60)
            {
                Nota = "D";
            }
            else if (x >= 40)
            {
                Nota = "E";
            }
            else
            {
                Nota = "F";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = double.Parse(txtPrimerNum.Text);
                double n2 = double.Parse(txtSegundoNum.Text);
                double n3 = double.Parse(txtTercerNum.Text);
                double n4 = double.Parse(txtCuartoNum.Text);

                double mayor = MAYOR(n1, n2, n3, n4);
                double menor = MENOR(n1, n2, n3, n4);
                double media = MEDIA(n1, n2, n3, n4);

                lblMayor.Text = $" {mayor}";
                lblMenor.Text = $"{menor}";
                lblMedia.Text = $"{media}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: se pueden ingresar solo numeros");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}");
            }
        }

        private double MEDIA(double n1, double n2, double n3, double n4)
        {
            double media = (n1 + n2 + n3 + n4) / 4;
            return media;
        }
        private double MENOR(double n1, double n2, double n3, double n4)
        {
            double menor = n1;

            if (n2 < menor)
            {
                menor = n2;
            }
            if (n3 < menor)
            {
                menor = n3;
            }
            if (n4 < menor)
            {
                menor = n4;
            }
            return menor;
        }
        private double MAYOR(double n1, double n2, double n3, double n4)
        {
            double mayor = n1;

            if (n2 > mayor)
            {
                mayor = n2;
            }
            if (n3 > mayor)
            {
                mayor = n3;
            }
            if (n4 > mayor)
            {
                mayor = n4;
            }
            return mayor;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = double.Parse(N1.Text);
                double n2 = double.Parse(N2.Text);
                double n3 = double.Parse(N3.Text);
                double acumulador;

                if (n1 < 0)
                {
                    acumulador = n1 + n2 + n3;
                    MessageBox.Show($"La suma de los 3 números es {acumulador}");
                }
                else
                {
                    acumulador = n1 * n2 * n3;
                    MessageBox.Show($"El producto de los 3 números es {acumulador}");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: se pueden ingresar solo numeros");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}");
            }
        }

        private void btnCalcularAnio_Click(object sender, EventArgs e)
        {
            try
            {
                int año = int.Parse(txtFecha.Text.Split('/')[2]);
                bool esBisiesto = (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
                MessageBox.Show($"El año {año} {(esBisiesto ? "ES" : "NO ES")} bisiesto");
            }
            catch
            {
                MessageBox.Show("Formato incorrecto. Use DD/MM/AAAA");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalir3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalir4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
