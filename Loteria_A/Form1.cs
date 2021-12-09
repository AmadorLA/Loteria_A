using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loteria_A
{
    public partial class Form1 : Form
    {
        const int Cantidad_Cartas = 54;

        private PictureBox[] Tabla;
        Random R = new Random();
        int r = 0, c = 0;
        int a, aux;
       //private PictureBox[] baraja;
        int[] cartas = new int[54];
        public Form1()
        {
            InitializeComponent();
        }


        private void inicializarTabla()
        {

            Tabla = new PictureBox[25];
            for (int i = 0; i < cartas.Length; i++)
            {
                cartas[i] = i + 1;
            }
            for (int i = 0; i < cartas.Length; i++)
            {
                a = R.Next(cartas.Length);
                aux = cartas[i];
                cartas[i] = cartas[a];
                cartas[a] = aux;
            }
            for (int i = 0; i < Tabla.Length; i++)
            {
                Tabla[i] = new PictureBox();
                Tabla[i].Location = new System.Drawing.Point(100 + (c * 90), 25 + (r * 130));
                Tabla[i].Name = "picTabla" + i;
                Tabla[i].Size = new System.Drawing.Size(60, 70);
                Tabla[i].TabIndex = 0 + 1;
                Tabla[i].SizeMode = PictureBoxSizeMode.StretchImage;
                Tabla[i].TabStop = false;
                Tabla[i].Image = Image.FromFile(@"cartas\" + cartas[i] + ".jpg");

                this.Controls.Add(Tabla[i]);
                c++;
                if (c == 5)
                {
                    r++;
                    c = 0;
                }
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            inicializarTabla();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            pictureBox22.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            pictureBox21.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox20.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox19.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void pictureBox27_Click(object sender, EventArgs e)
        {
            pictureBox27.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox27.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBox26.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox26.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pictureBox25.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox25.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox24.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox24.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pictureBox23.Image = Image.FromFile(@"C:\Users\LENOVO\OneDrive\Documentos\Pikachu.png");
            pictureBox23.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        SoundPlayer carta = new SoundPlayer();
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            int num = R.Next(1, 54);
            pictureBox1.Image = Image.FromFile(@"cartas\" + (num) + ".jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            carta.SoundLocation = @"Sonidos\" + num + ".wav";
            carta.Play();
            //inicializar_baraja();
        }

        //private void inicializar_baraja()
        //{
        //    baraja = new PictureBox[54];

        //    for (int i = 0; i < cartas.Length; i++)
        //    {
        //        cartas[i] = i + 1;
        //    }
        //    for (int i = 0; i < cartas.Length; i++)
        //    {
        //        a = R.Next(cartas.Length);
        //        aux = cartas[i];
        //        cartas[i] = cartas[a];
        //        cartas[a] = aux;
        //    }
        //    for (int i = 0; i < baraja.Length; i++)
        //    {
        //        baraja[i] = new PictureBox();
        //        baraja[i].Location = new System.Drawing.Point(850, 50);
        //        baraja[i].Name = "picBaraja" + i;
        //        baraja[i].Size = new System.Drawing.Size(308, 413);
        //        baraja[i].TabIndex = 0 + i;
        //        baraja[i].SizeMode = PictureBoxSizeMode.StretchImage;
        //        baraja[i].TabStop = false;
        //        baraja[i].Image = Image.FromFile(@"cartas\" + (cartas[i]) + ".jpg");
        //        this.Controls.Add(baraja[i]);
        //        c++;
        //        if (c == 5)
        //        {
        //            r++;
        //            c = 0;
        //        }
        //    }
        //}
    }
}
