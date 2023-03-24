using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Viewer
{
    public partial class LinearСolorСorrection : Form
    {
        public LinearСolorСorrection(Bitmap bmp)
        {
            InitializeComponent();
            bmp2= bmp;
            NewBitmap(bmp);
            LinearCorrection(bmp);
 
        }


        public int R, G, B;
        public int XmaxR, XminR, XmaxG, XminG, XmaxB, XminB;
        public Bitmap bmp2, bmp3;

        private void NewBitmap(Bitmap bit)
        {
            bmp3 = new Bitmap(bit);
            pictureBox1.Image = bmp3;
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Graphics g = Graphics.FromImage(bmp2);
            g.DrawImage(bmp3,0,0,bmp2.Width,bmp2.Height);
            pictureBox2.Image = bmp2;
            Close();
        }

        private void LinearCorrection(Bitmap bmp)
        {

            
            
            Xmaxmin(bmp);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixColor = bmp.GetPixel(i, j);
                    bmp2.SetPixel(i, j, System.Drawing.Color.FromArgb(Y(Convert.ToInt32(pixColor.R), XmaxR, XminR), Y(Convert.ToInt32(pixColor.G), XmaxG, XminG), Y(Convert.ToInt32(pixColor.B), XmaxB, XminB)));
                }
            }
            pictureBox2.Image = bmp2;


        }
        private int Y(int x, int Xmax, int Xmin)
        {
            int y = 0;
            y = (x - Xmin) * (255 / (Xmax - Xmin));

            if (Math.Abs(y) > 255) y = 255;
            return Math.Abs(y);
        }
        private void Xmaxmin(Bitmap bmp)
        {
            XminR = bmp.GetPixel(0, 0).R;
            XmaxR = bmp.GetPixel(0, 0).R;
            XmaxG = bmp.GetPixel(0, 0).G;
            XminG = bmp.GetPixel(0, 0).G;
            XmaxB = bmp.GetPixel(0, 0).B;
            XminB = bmp.GetPixel(0, 0).B;


            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixColor = bmp.GetPixel(i, j);

                    if (XminR > pixColor.R) XminR = pixColor.R;
                    if (XmaxR < pixColor.R) XmaxR = pixColor.R;
                    if (XminG > pixColor.G) XminG = pixColor.G;
                    if (XmaxG < pixColor.G) XmaxG = pixColor.G;
                    if (XminB > pixColor.B) XminB = pixColor.B;
                    if (XmaxB < pixColor.B) XmaxB = pixColor.B;

                }
            }
        }
    }
}
