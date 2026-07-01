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
    public partial class FormEjercicio2 : Form
    {
        // Lista para guardar los valores en Celsius
        List<double> temperaturasCelsius = new List<double>();

        public FormEjercicio2()
        {
            InitializeComponent();
        }

        private void FormEjercicio2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int n;
            if (!int.TryParse(txtN.Text, out n) || string.IsNullOrWhiteSpace(txtN.Text) || n < 0)
            {
                MessageBox.Show("Ingrese un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                int numPar = 2 * i;
                suma += numPar * numPar;
            }
            txtResul.Text = suma.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
        }

        private void txtResulTabla_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            for (double x = -10; x <= 10; x++)
            {
                txtResulTabla.ScrollBars = ScrollBars.Vertical;
                double y = Math.Pow(x, 2) + x + 1;
                txtResulTabla.AppendText($"{x} = {y}\r\n\n");

            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lstFahrenheit.Items.Clear();
            lstKelvin.Items.Clear();

            for (int i = 0; i < temperaturasCelsius.Count; i++)
            {
                double celsius = temperaturasCelsius[i];
                double fahrenheit = (celsius * 9 / 5) + 32;
                double kelvin = celsius + 273.15;

                lstFahrenheit.Items.Add(fahrenheit);
                lstKelvin.Items.Add(kelvin);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCelsius.Text, out double celsius))
            {
                temperaturasCelsius.Add(celsius);
                lstCelsius.Items.Add(celsius); // Mostrar el valor ingresado
                txtCelsius.Clear();
                txtCelsius.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstCelsius.Items.Clear();
            lstFahrenheit.Items.Clear();
            lstKelvin.Items.Clear();
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
    }
}
