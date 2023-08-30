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
            string[] cartas_aux = cartas;
            this.colocadas = new string[cartas.Length];

            Random rnd = new Random();
            for (int i = 0; i < cartas.Length; i++)
            {
                int num = rnd.Next(1,18);
                this.colocadas = new string[] { cartas_aux[num] };
                cartas_aux = Array.FindAll(cartas_aux, (cartas_aux != "fas")).ToArray();

                //cartas_aux = cartas_aux.Where(val => val != num).ToArray();

            }

        }

        private void img1_Click(object sender, EventArgs e)
        {

        }

        private void img2_Click(object sender, EventArgs e)
        {

        }

        private void img3_Click(object sender, EventArgs e)
        {

        }

        private void img4_Click(object sender, EventArgs e)
        {

        }

        private void img5_Click(object sender, EventArgs e)
        {

        }

        private void img6_Click(object sender, EventArgs e)
        {

        }
    }
}
