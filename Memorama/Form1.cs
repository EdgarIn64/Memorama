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
        private PictureBox[] targetImg;
        private string[] targets;
        private int puntos;

        public Memorama()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cartas = new string[] { "garza", "gato", "tortuga", "gusano", "perro", "rana", "rino", "tigre", "topo"};
            this.puntos = cartas.Length;
            this.targetImg = new PictureBox[2];
            this.targets = new string[] { "", "" };

            Aleatorios aleatorios = new Aleatorios();
            int[] lista1 = aleatorios.generarNumerosAleatoriosNoRepetidos(cartas.Length);
            int[] lista2 = aleatorios.generarNumerosAleatoriosNoRepetidos(cartas.Length);

            this.colocadas = new string[lista1.Length + lista2.Length];

            for (int i = 0; i < lista1.Length; i++)
                colocadas[i] = cartas[lista1[i]];

            for (int i = 0; i < lista2.Length; i++)
                colocadas[lista1.Length + i] = cartas[lista2[i]];

        }

        async private void Evaluar(PictureBox img, string nameImg)
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
                    await Task.Delay(550);
                    targetImg[0].Image = targetImg[1].Image = (Bitmap)Resource2.oculto;
                }
                targets[0] = targets[1] = "";
                targetImg[0] = targetImg[1] = null;
            }
            if (puntos == 0)
            {
                titulo.Text = "Felicidades";
            }
        }

        private void Img1_Click(object sender, EventArgs e)
        {
            if (targets[1] == "")
            {
                img1.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[0]);
                Evaluar(img1, colocadas[0]);
            }
        }

        private void Img2_Click(object sender, EventArgs e)
        {
            if (targets[1] == "")
            {
                img2.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[1]);
                Evaluar(img2, colocadas[1]);
            }
        }

        private void Img3_Click(object sender, EventArgs e)
        {
            if (targets[1] == "")
            {
                img3.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[2]);
                Evaluar(img3, colocadas[2]);
            }
        }

        private void Img4_Click(object sender, EventArgs e)
        {
            if (targets[1] == "")
            {
                img4.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[3]);
                Evaluar(img4, colocadas[3]);
            }
        }

        private void Img5_Click(object sender, EventArgs e)
        {
            if (targets[1] == "")
            {
                img5.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[4]);
                Evaluar(img5, colocadas[4]);
            }
        }

        private void Img6_Click(object sender, EventArgs e)
        {
            if (targets[1] == "")
            {
                img6.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[5]);
                Evaluar(img6, colocadas[5]);
            }
        }

        private void Img7_Click(object sender, EventArgs e)
        {
            if (targets[1] == "")
            {
                img7.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[6]);
                Evaluar(img7, colocadas[6]);
            }
        }

        private void Img8_Click(object sender, EventArgs e)
        {
            if (targets[1] == "")
            {
                img8.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[7]);
                Evaluar(img8, colocadas[7]);
            }
        }

        private void Img9_Click(object sender, EventArgs e)
        {
            if (targets[1] == "")
            {
                img9.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[8]);
                Evaluar(img9, colocadas[8]);
            }
        }

        private void Img10_Click(object sender, EventArgs e)
        {
            if (targets[1] == "")
            {
                img10.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[9]);
                Evaluar(img10, colocadas[9]);
            }
        }

        private void Img11_Click(object sender, EventArgs e)
        {
            if (targets[1] == "")
            {
                img11.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[10]);
                Evaluar(img11, colocadas[10]);
            }
        }

        private void Img12_Click(object sender, EventArgs e)
        {
            if (targets[1] == "")
            {
                img12.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[11]);
                Evaluar(img12, colocadas[11]);
            }
        }

        private void Img13_Click(object sender, EventArgs e)
        {
            if (targets[1] == "")
            {
                img13.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[12]);
                Evaluar(img13, colocadas[12]);
            }
        }

        private void Img14_Click(object sender, EventArgs e)
        {
            if (targets[1] == "")
            {
                img14.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[13]);
                Evaluar(img14, colocadas[13]);
            }
        }

        private void Img15_Click(object sender, EventArgs e)
        {
            if (targets[1] == "")
            {
                img15.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[14]);
                Evaluar(img15, colocadas[14]);
            }
        }

        private void Img16_Click(object sender, EventArgs e)
        {
            if (targets[1] == "")
            {
                img16.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[15]);
                Evaluar(img16, colocadas[15]);
            }
        }

        private void Img17_Click(object sender, EventArgs e)
        {
            if (targets[1] == "")
            {
                img17.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[16]);
                Evaluar(img17, colocadas[16]);
            }
        }

        private void Img18_Click(object sender, EventArgs e)
        {
            if (targets[1] == "")
            {
                img18.Image = (Bitmap)Resource2.ResourceManager.GetObject(colocadas[17]);
                Evaluar(img18, colocadas[17]);
            }
        }
    }
}
