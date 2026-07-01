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
    public partial class FormEjercicio4 : Form
    {
        private List<double> numeros = new List<double>();

        public FormEjercicio4()
        {
            InitializeComponent();
            btnAgregar.Click += button2_Click;
            btnOrdenar.Click += btnOrdenar_Click;
        }

        private static readonly string[] NombresMeses = {
            "", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
            "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

        private static readonly string[] NombresDias = {
            "", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado",
            "Domingo"};


        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    throw new ArgumentException("El campo nombre no puede estar vacío");
                }
                string nombre = txtNombre.Text;
                double x = double.Parse(NotaNum.Text);
                string Nota = "Vacia";
                CalcularNotas(x, ref Nota);
                lblResultadoNota.Text = $"La calificacion del alumno {nombre} es {Nota}";
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
            switch (x)
            {
                case double n when n >= 90:
                    Nota = "A";
                    break;
                case double n when n >= 80:
                    Nota = "B";
                    break;
                case double n when n >= 70:
                    Nota = "C";
                    break;
                case double n when n >= 60:
                    Nota = "D";
                    break;
                case double n when n >= 40:
                    Nota = "E";
                    break;
                default:
                    Nota = "F";
                    break;
            }
        }

        private void btnCalcularAnio_Click(object sender, EventArgs e)
        {
            try
            {
                int mes = (int)numericUpDownMes.Value;
                int dias = 0;

                switch (mes)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        dias = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        dias = 30;
                        break;
                    case 2:
                        int anio = (int)numericUpDownAño.Value;
                        if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
                            dias = 29;
                        else
                            dias = 28;
                        break;
                    default:
                        MessageBox.Show("Mes inválido. Ingrese un número entre 1 y 12.");
                        return;
                }
                string nombreMes = NombresMeses[mes];
                lblResultado.Text = $"El mes {nombreMes} tiene {dias} días.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int dias = (int)numericUpDownDias.Value;


                switch (dias)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        break;
                    default:
                        MessageBox.Show("Dia inválido. Ingrese un número entre 1 y 7.");
                        return;
                }
                string nombreDias = NombresDias[dias];
                lblResultadoDias.Text = $"El dia {nombreDias} corresponde al día {dias} de la semana.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum.Text, out double numero))
            {
                numeros.Add(numero);
                txtNum.Clear();
                txtNum.Focus();
                MostrarOriginal();
                lstMenorMayor.Items.Clear();
                lstMayorMenor.Items.Clear();
            }
            
        }

        private void MostrarOriginal()
        {
            lstOriginal.Items.Clear();
            foreach (var n in numeros)
                lstOriginal.Items.Add($"{n}");
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

            if (numeros.Count == 0)
            {
                MessageBox.Show("Agregue al menos un número antes de ordenar.");
                return;
            }

            // Mostrar lista de mayor a menor
            lstMayorMenor.Items.Clear();
            foreach (var n in numeros.OrderByDescending(x => x))
                lstMayorMenor.Items.Add($"{n}");

            // Mostrar lista de menor a mayor
            lstMenorMayor.Items.Clear();
            foreach (var n in numeros.OrderBy(x => x))
                lstMenorMayor.Items.Add($"{n}");
        }

        private void btnSalir1_Click(object sender, EventArgs e)
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
    }
}
