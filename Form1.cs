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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            FormEjercicio1 forms = new FormEjercicio1();
            forms.ShowDialog();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            FormEjercicio2 forms = new FormEjercicio2();
            forms.ShowDialog();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            FormEjercicio3 forms = new FormEjercicio3();   
            forms.ShowDialog();
        }

        private void btnEjercicio4_Click(object sender, EventArgs e)
        {
            FormEjercicio4 forms = new FormEjercicio4();
            forms.ShowDialog();
        }
    }
}
