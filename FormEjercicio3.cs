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
    public partial class FormEjercicio3 : Form
    {
        public FormEjercicio3()
        {
            InitializeComponent();

            var random = new Random();
            var numeros = new List<int>();

            // Generar 100 numeros aleatorios entre 1 y 999
            for (int i = 0; i < 100; i++)
            {
                numeros.Add(random.Next(1, 1000));
            }

            // Mostrar todos los numeros en el primer ListBox
            lstboxNumeros.Items.Clear();
            foreach (var n in numeros)
                lstboxNumeros.Items.Add($"{n}");

            // Tomar los primeros 10 numeros pares
            var primerosPares = numeros.Where(x => x % 2 == 0).Take(10).ToList();

            // Mostrar los pares en el segundo ListBox
            lstboxPares.Items.Clear();
            foreach (var p in primerosPares)
                lstboxPares.Items.Add($"{p}");

            // Calcular y mostrar la suma en el TextBox
            int suma = primerosPares.Sum();
            txtboxTotal.Text = suma.ToString();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que la nota sea un número entre 1 y 100
            if (int.TryParse(txtboxNota.Text, out int nota))
            {
                if (nota >= 1 && nota <= 100)
                {
                    lstboxNotas.Items.Add($"{nota}"); // Agregar la nota al ListBox
                    txtboxNota.Clear(); // Limpiar el TextBox después de agregar la nota
                }
                else
                {
                    // En caso de ingresar un valor fuera del rango
                    MessageBox.Show("La nota debe estar entre 1 y 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // En caso de ingresar un valor no numérico
                MessageBox.Show("Ingrese un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcularNota_Click(object sender, EventArgs e)
        {
            if (lstboxNotas.Items.Count == 0)
            {
                txtboxNotaMedia.Text = "";
                MessageBox.Show("No hay notas registradas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int suma = 0;
            foreach (var item in lstboxNotas.Items)
            {
                suma += Convert.ToInt32(((ListViewItem)item).SubItems[0].Text);
            }
            double media = (double)suma / lstboxNotas.Items.Count;
            txtboxNotaMedia.Text = media.ToString("0.00");
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtboxResultado.Clear();

            if (!int.TryParse(txtboxNumero.Text, out int numero))
            {
                MessageBox.Show("Ingrese un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numero < 0)
            {
                MessageBox.Show("El número debe ser mayor o igual a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                long resultado = Factorial(numero);
                txtboxResultado.Text = resultado.ToString();
            }
            catch (OverflowException)
            {
                MessageBox.Show("El resultado es demasiado grande para mostrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private long Factorial(int n)
        {
            long res = 1;
            for (int i = 2; i <= n; i++)
                res *= i;
            return res;
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
