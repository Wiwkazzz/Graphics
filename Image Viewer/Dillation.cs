using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Viewer
{
    public partial class Dillation : Form
    {
        public Dillation(Bitmap bit)
        {
            InitializeComponent();
            bmp = bit;
            NewBitmap(bit);

            NewBinarMap();
            Dilation();
            pictureBox2.Image = bmp;
            pictureBox2.Refresh();
        }
        Bitmap bmp, bmp2, bin;
        int R, G, B;

        private void NewBinarMap()
        {
            bin = new Bitmap(bmp.Width, bmp.Height);
            Graphics g = Graphics.FromImage(bin);
            g.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);

            Color color = new Color();
            int P = 80;

            for (int j = 0; j < bin.Height; j++)
            {
                for (int i = 0; i < bin.Width; i++)
                {
                    color = bin.GetPixel(i, j);
                    int K = (color.R + color.G + color.B) / 3;
                    bin.SetPixel(i, j, K <= P ? Color.Black : Color.White);
                }
            }
            
        }

        private void Dilation()
        {
            for(int i = 0; i < bin.Width; i++)
            {
                for(int j = 0; j < bin.Height; j++)
                {
                    int BlackCountINT = BlackCount(i,j);
                    if((BlackCountINT > 3) && !IsPixelBlack(i,j))
                    {
                        bmp.SetPixel(i, j, System.Drawing.Color.FromArgb(ColorNeighborsR(i,j), ColorNeighborsG(i, j), ColorNeighborsB(i, j))); 
        }
    }
}
        }

        private bool IsPixelBlack(int i, int j)
{
         if (Convert.ToInt32(bin.GetPixel(i, j).R) == 0 && Convert.ToInt32(bin.GetPixel(i, j).G) == 0 && Convert.ToInt32(bin.GetPixel(i, j).B) == 0)
              return true;
         return false;
}

        private int ColorNeighborsR(int i, int j)
        {
            int sumcolorR = 0;
            int sum = 0;

            for (int k = i-1; k <= i+1; ++k)
            {
                for(int l = j-1; l <= j+1; ++l)
                {
                    if (IsInMap(k, l) && IsPixelBlack(k, l))
                    {
                        sumcolorR += Convert.ToInt32(bmp2.GetPixel(k, l).R);
                        sum++;
                    }
                }
            }
            return Math.Abs(sumcolorR / sum);
        }
        private int ColorNeighborsG(int i, int j)
        {
            int sumcolorG = 0;
            int sum = 0;

            for (int k = i - 1; k <= i + 1; ++k)
            {
                for (int l = j - 1; l <= j + 1; ++l)
                {
                    if (IsInMap(k, l) && IsPixelBlack(k, l))
                    {
                        sumcolorG += Convert.ToInt32(bmp2.GetPixel(k, l).G);
                        sum++;
                    }
                }
            }
            return Math.Abs(sumcolorG / sum);
        }
        private int ColorNeighborsB(int i, int j)
        {
            int sumcolorB = 0;
            int sum = 0;

            for (int k = i - 1; k <= i + 1; ++k)
            {
                for (int l = j - 1; l <= j + 1; ++l)
                {
                    if (IsInMap(k, l) && IsPixelBlack(k, l))
                    {
                        sumcolorB += Convert.ToInt32(bmp2.GetPixel(k, l).B);
                        sum++;
                    }
                }
            }
            return Math.Abs(sumcolorB / sum);
        }


        private int BlackCount(int i, int j)
        {
            
            int Count = 0;
            for(int k = i - 1; k <= i + 1; k++)
            {
                for(int l = j - 1; l <= j + 1; l++)
                {
                    if (IsInMap(k, l) && IsPixelBlack(k,l))
                        Count++;                   
                }
            }
            return Count;
        }

        private bool IsInMap(int i, int j)
        {
            if( i < 0 || i >= bin.Width || j < 0 || j >= bin.Height) 
                return false;

            return true;
        }

        private void NewBitmap(Bitmap bit)
        {
            bmp2 = new Bitmap(bit);
            pictureBox1.Image = bmp2;
            pictureBox1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(bmp2, 0, 0, bmp.Width, bmp.Height);
            pictureBox2.Image = bmp;
            Close();
        }
    }
}
