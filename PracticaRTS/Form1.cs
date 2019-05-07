using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaRTS
{
    public partial class Form1 : Form
    {


        const int SIZE = 50;
        const int HALF = 25;
        Bitmap plano;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            plano = DrawPixel(0, 0);
            pbPlano.Image = plano;
            pbPlano.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnGenT_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (txtTPY.Text.Length == 0 || !IsNumeric(txtTPY.Text))
            {
                MessageBox.Show("El valor de Y para dibujar el punto está vacío o no es válido, favor de comprobarlo", "Error al generar el punto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            if (txtPTX.Text.Length == 0 || !IsNumeric(txtPTX.Text))
            {
                MessageBox.Show("El valor de X para dibujar el punto está vacío o no es válido, favor de comprobarlo", "Error al generar el punto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            if (valid)
            {
                pbPlano.Image = DrawPixel(int.Parse(txtPTX.Text), int.Parse(txtTPY.Text));
                pbPlano.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }


        private bool IsNumeric(string number)
        {
            try
            {
                int res = int.Parse(number);
                return true;
            } catch(Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);
                return false;
            }
        }

        private Bitmap DrawPixel(int x, int y)
        {
            Bitmap newImg = new Bitmap(SIZE, SIZE);
            using (Graphics graphics = Graphics.FromImage(newImg))
            {
                graphics.DrawImage(newImg, 0, 0);
                for(int i = 0; i < SIZE; i++)
                {
                    newImg.SetPixel(HALF, i, Color.Black);
                    newImg.SetPixel(i, HALF, Color.Black);
                }
                newImg.SetPixel(HALF + x, HALF - y, Color.Blue);
            }
            return newImg;
        }

        private Bitmap DrawPixel(int x, int y, int primeX, int primeY)
        {
            Bitmap newImg = new Bitmap(SIZE, SIZE);
            using (Graphics graphics = Graphics.FromImage(newImg))
            {
                graphics.DrawImage(newImg, 0, 0);
                for (int i = 0; i < SIZE; i++)
                {
                    newImg.SetPixel(HALF, i, Color.Black);
                    newImg.SetPixel(i, HALF, Color.Black);
                }
                newImg.SetPixel(HALF + x, HALF - y, Color.Blue);
                newImg.SetPixel(HALF + primeX, HALF - primeY, Color.Red);
            }
            return newImg;
        }

        private Bitmap DrawLine(int x1, int y1, int x2, int y2, Color color)
        {
            Bitmap newImg = new Bitmap(SIZE, SIZE);
            using (Graphics graphics = Graphics.FromImage(newImg))
            {
                graphics.DrawImage(newImg, 0, 0);
                for (int i = 0; i < SIZE; i++)
                {
                    newImg.SetPixel(HALF, i, Color.Black);
                    newImg.SetPixel(i, HALF, Color.Black);
                }
                graphics.DrawLine(new Pen(color), new Point(HALF + x1, HALF - y1), new Point(HALF + x2, HALF - y2));
            }
            return newImg;
        }

        private Bitmap DrawLines(Point p1, Point p2, Point Sp1, Point Sp2)
        {
            Bitmap newImg = new Bitmap(SIZE, SIZE);
            using (Graphics graphics = Graphics.FromImage(newImg))
            {
                graphics.DrawImage(newImg, 0, 0);
                for (int i = 0; i < SIZE; i++)
                {
                    newImg.SetPixel(HALF, i, Color.Black);
                    newImg.SetPixel(i, HALF, Color.Black);
                }
                graphics.DrawLine(new Pen(Color.Blue), p1, p2);
                graphics.DrawLine(new Pen(Color.Red), Sp1, Sp2);
            }
            return newImg;
        }

        private void btnTrasT_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (txtTy.Text.Length == 0 || !IsNumeric(txtTy.Text))
            {
                MessageBox.Show("El valor de Ty para trasladar el punto está vacío o no es válido, favor de comprobarlo", "Error al trasladar el punto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            if (txtPTX.Text.Length == 0 || !IsNumeric(txtPTX.Text))
            {
                MessageBox.Show("El valor de Tx para dibujar el punto está vacío o no es válido, favor de comprobarlo", "Error al trasladar el punto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            if (valid)
            {
                int[] puntos = new int[3];
                puntos[0] = int.Parse(txtPTX.Text);
                puntos[1] = int.Parse(txtTPY.Text);
                puntos[2] = 1;

                int[,] movimiento = new int[,] { { 1, 0, int.Parse(txtTx.Text) }, { 0, 1, int.Parse(txtTy.Text) }, { 0, 0, 1 } };

                int[] res = MultiplicaMatrices(puntos, movimiento);

                pbPlano.Image = DrawPixel(puntos[0], puntos[1], res[0], res[1]);
                pbPlano.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        private int[] MultiplicaMatrices(int[] matrizPunto, int[,] matrizMovimiento)
        {
            int[] resultante = new int[3];

            for (int i = 0; i <= 2; i++)
            {
                resultante[i] = 0;
                for (int j = 0; j <= 2; j++)
                {
                    resultante[i] += matrizPunto[j] * matrizMovimiento[i, j];
                }
            }

            return resultante;

        }

        private float[] MultiplicaMatrices(float[] matrizPunto, float[,] matrizMovimiento)
        {
            float[] resultante = new float[3];

            for (int i = 0; i <= 2; i++)
            {
                resultante[i] = 0;
                for (int j = 0; j <= 2; j++)
                {
                    resultante[i] += matrizPunto[j] * matrizMovimiento[i, j];
                }
            }

            return resultante;

        }

        private void btnGenR_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (txtRx.Text.Length == 0 || !IsNumeric(txtRx.Text))
            {
                MessageBox.Show("El valor de X para dibujar el punto está vacío o no es válido, favor de comprobarlo", "Error al generar el punto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            if (txtRy.Text.Length == 0 || !IsNumeric(txtRy.Text))
            {
                MessageBox.Show("El valor de Y para dibujar el punto está vacío o no es válido, favor de comprobarlo", "Error al generar el punto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            if (valid)
            {
                pbPlano.Image = DrawPixel(int.Parse(txtRx.Text), int.Parse(txtRy.Text));
                pbPlano.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (txtAngR.Text.Length == 0 || !IsNumeric(txtAngR.Text))
            {
                MessageBox.Show("El angulo especificado para trasladar el punto está vacío o no es válido, favor de comprobarlo", "Error al rotar el punto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            if (valid)
            {
                int[] puntos = new int[3];
                puntos[0] = int.Parse(txtRx.Text);
                puntos[1] = int.Parse(txtRy.Text);
                puntos[2] = 1;

                double angle = double.Parse(txtAngR.Text);

                int[,] movimiento = new int[,] { { (int)Math.Round((decimal)Math.Cos(angle), 0), (-1)*(int)(Math.Round(Math.Sin(angle), 0)), 0 }, { (int)Math.Round(Math.Sin(angle), 0), (int)Math.Round(Math.Cos(angle), 0), 0 }, { 0, 0, 1 } };

                int[] res = MultiplicaMatrices(puntos, movimiento);

                pbPlano.Image = DrawPixel(puntos[0], puntos[1], res[0], res[1]);
                pbPlano.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnGenS_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (txtSx1.Text.Length == 0 || !IsNumeric(txtSx1.Text))
            {
                MessageBox.Show("El valor de X para dibujar el punto 1 está vacío o no es válido, favor de comprobarlo", "Error al generar el punto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            if (txtSy1.Text.Length == 0 || !IsNumeric(txtSy1.Text))
            {
                MessageBox.Show("El valor de Y para dibujar el punto 1 está vacío o no es válido, favor de comprobarlo", "Error al generar el punto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            if (txtSx2.Text.Length == 0 || !IsNumeric(txtSx2.Text))
            {
                MessageBox.Show("El valor de X para dibujar el punto 2 está vacío o no es válido, favor de comprobarlo", "Error al generar el punto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            if (txtSy2.Text.Length == 0 || !IsNumeric(txtSy2.Text))
            {
                MessageBox.Show("El valor de Y para dibujar el punto 2 está vacío o no es válido, favor de comprobarlo", "Error al generar el punto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            if (valid)
            {
                pbPlano.Image = DrawLine(int.Parse(txtSx1.Text), int.Parse(txtSy1.Text), int.Parse(txtSx2.Text), int.Parse(txtSy2.Text), Color.Blue);
                pbPlano.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
                float[] p1 = { float.Parse(txtSx1.Text), float.Parse(txtSy1.Text), 1 };
                float[] p2 = { float.Parse(txtSx2.Text), float.Parse(txtSy2.Text), 1 };

                float[,] matriz = { { float.Parse(txtSx.Text), 0, 0 }, { 0, float.Parse(txtSy.Text), 0 }, { 0, 0, 1 } };

                float[] s1 = MultiplicaMatrices(p1, matriz);
                float[] s2 = MultiplicaMatrices(p2, matriz);

                pbPlano.Image = DrawLines(
                    new Point(HALF + (int)Math.Round((decimal)p1[0], 0), HALF - (int)Math.Round((decimal)p1[1], 0)), 
                    new Point(HALF + (int)Math.Round((decimal)p2[0], 0), HALF - (int)Math.Round((decimal)p2[1], 0)), 
                    new Point(HALF + (int)Math.Round((decimal)s1[0], 0), HALF - (int)Math.Round((decimal)s1[1], 0)), 
                    new Point(HALF + (int)Math.Round((decimal)s2[0], 0), HALF - (int)Math.Round((decimal)s2[1], 0))
                    );
                pbPlano.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
