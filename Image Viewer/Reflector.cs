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
    public partial class Reflector : Form
    {
        public Reflector(Bitmap bit)
        {

            InitializeComponent();

            bmp = bit;
            NewBitmap(bit);
            ReflectorCount();
            
        }

        public int R, G, B;
        public int XmaxR, XmaxG, XmaxB;
        public Bitmap bmp, bmp2;


       private void ReflectorNew()
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixColor = bmp.GetPixel(i, j);
                    bmp.SetPixel(i, j, System.Drawing.Color.FromArgb(pixColor.R*(255/XmaxR), pixColor.G * (255 / XmaxG), pixColor.B * (255 / XmaxB)));


                }
            }
        }

        private void ReflectorCount()
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixColor = bmp.GetPixel(i, j);

                    if (XmaxR < pixColor.R) XmaxR = pixColor.R;
                    if (XmaxG < pixColor.G) XmaxG = pixColor.G;
                    if (XmaxB < pixColor.B) XmaxB = pixColor.B;

                }
            }
            pictureBox2.Image = bmp; 
            pictureBox2.Refresh();
            ReflectorNew();
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
            Close();
        }
    }
}
