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
    public partial class Dilation : Form
    {
        public Dilation(Bitmap bit)
        {
            InitializeComponent();
            bmp = bit;
            NewBitmap(bit);

            DilationFunc();

            pictureBox2.Image = bmp;
            pictureBox2.Refresh();
        }

        Bitmap bmp, bmp2;

        bool[,] mask = new bool[3, 3] {{false,true,false},
                                       {true, true, true },
                                       {false,true,false}}; 

        private bool IsWhite(Color pix)
        {
            if(pix.R == 255 && pix.G == 255 && pix.B == 255)
                return true;
            return false;
        }
        private void NewBitmap(Bitmap bit)
        {
            bmp2 = new Bitmap(bit);
            pictureBox1.Image = bmp2;
            pictureBox1.Refresh();

        }

        private void DilationFunc()
        {
            for (int y = 3 / 2; y < Height - 3 / 2; y++){
                for (int x = 3 / 2; x < Width - 3 / 2; x++)
{
                    BIT max = 0;
                    for (int j = -3 / 2; j <= 3 / 2; j++)
                        for (int i = -3 / 2; i <= 3 / 2; i++)
                            if ((mask[i, j]) && (source[x + i][y + j] > max))
                            {
                                max = source[x + i][y + j];
                            }
                    result[x][y] = max;
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(bmp2, 0, 0, bmp.Width, bmp.Height);
            pictureBox2.Image = bmp;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
