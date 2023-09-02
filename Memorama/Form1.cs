using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorama
{
    public partial class Memorama : Form
    {
        private string[] cartas;
        private string[] colocadas;

        public Memorama()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cartas = new string[] { "garza", "gato", "tortuga", "gusano", "perro", "rana", "rino", "tigre", "topo"};

            Aleatorios aleatorios = new Aleatorios();

            int[] lista1 = aleatorios.generarNumerosAleatorios(cartas.Length-1);
            int[] lista2 = aleatorios.generarNumerosAleatorios(cartas.Length-1);

            this.colocadas = new string[lista1.Length + lista2.Length];
            
            for (int i = 0; i < lista1.Length; i++)
            {
                colocadas[i] = cartas[lista1[i]];
            }

            for (int i = 0; i < lista2.Length; i++)
            {
                colocadas[i] = cartas[lista2[i]];
            }

        }

        private void img1_Click(object sender, EventArgs e)
        {
            img1.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[0]);
        }

        private void img2_Click(object sender, EventArgs e)
        {
            img2.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[1]);
        }

        private void img3_Click(object sender, EventArgs e)
        {
            img3.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[2]);
        }

        private void img4_Click(object sender, EventArgs e)
        {
            img4.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[3]);
        }

        private void img5_Click(object sender, EventArgs e)
        {
            img5.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[4]);
        }

        private void img6_Click(object sender, EventArgs e)
        {
            img6.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[5]);
        }
    }
}
