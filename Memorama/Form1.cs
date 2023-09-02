using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorama
{
    public partial class Memorama : Form
    {
        private string[] cartas;
        private string[] colocadas;
        private PictureBox[] targetImg = new PictureBox[2];
        private string[] targets = new string[] {"", ""};
        private int puntos;

        public Memorama()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cartas = new string[] { "garza", "gato", "tortuga", "gusano", "perro", "rana", "rino", "tigre", "topo"};
            this.puntos = cartas.Length;
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

        async private void evaluar(PictureBox img, string nameImg)
        {
            if (targets[0] == "")
            {
                targets[0] = nameImg;
                targetImg[0] = img;
            }
            else
            {
                targets[1] = nameImg;
                targetImg[1] = img;
                if (targets[0] == targets[1])
                {
                    puntos--;
                }
                else
                {
                    await Task.Delay(750);
                    targetImg[0].Image = targetImg[1].Image = (Bitmap)Resource2.oculto;
                }
                targets[0] = targets[1] = "";
                targetImg[0] = targetImg[1] = null;
            }
        }

        private void img1_Click(object sender, EventArgs e)
        {
            img1.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[0]);
            evaluar(img1, colocadas[0]);
        }

        private void img2_Click(object sender, EventArgs e)
        {
            img2.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[1]);
            evaluar(img2, colocadas[1]);
        }

        private void img3_Click(object sender, EventArgs e)
        {
            img3.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[2]);
            evaluar(img3, colocadas[2]);
        }

        private void img4_Click(object sender, EventArgs e)
        {
            img4.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[3]);
            evaluar(img4, colocadas[3]);
        }

        private void img5_Click(object sender, EventArgs e)
        {
            img5.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[4]);
            evaluar(img5, colocadas[4]);
        }

        private void img6_Click(object sender, EventArgs e)
        {
            img6.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[5]);
            evaluar(img6, colocadas[5]);
        }
    }
}
