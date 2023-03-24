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
    public partial class EmbossFoam : Form
    {
        public EmbossFoam(Bitmap bit)
        {
            InitializeComponent();
            bmp = bit;
            NewBitmap(bit);
            EmbossFilter();
            pictureBox2.Image = bmp;
            pictureBox2.Refresh();
        }
        Bitmap bmp, bmp2;
        private void NewBitmap(Bitmap bit)
        {
            bmp2 = new Bitmap(bit);
            pictureBox1.Image = bmp2;
            pictureBox1.Refresh();

        }

        private void EmbossFilter()
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color c = bmp.GetPixel(i, j);
                    Color newColor;
                    if ((i == bmp.Width - 1))
                    {
                        newColor = Color.FromArgb(0, 0, 0);
                    }
                    else
                    {
                        Color next = bmp.GetPixel(i + 1, j);

                        newColor = Color.FromArgb(
                            Math.Abs((byte)((int)c.R - (int)next.R)),
                            Math.Abs((byte)((int)c.G - (int)next.G)),
                            Math.Abs((byte)((int)c.B - (int)next.B)));

                    }
                    bmp.SetPixel(i, j, newColor);
                }
            }
            pictureBox2.Image = bmp;
            pictureBox2.Refresh();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(bmp2, 0, 0, bmp.Width, bmp.Height);
            pictureBox2.Image = bmp;
            Close();
        }
    }
}
