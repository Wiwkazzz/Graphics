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
    public partial class StaticColorCorect : Form
    {
        public StaticColorCorect(Bitmap bit)
        {
            InitializeComponent();
            bmp = bit;  // bmp new bitmap for new color bmp2- original bmp3 - color 
            NewBitmap(bit);
            Nt = bmp.Width * bmp.Height;
            CountEtDt();
            
        }
        Bitmap bmp,bmp2,bmp3;
         int R, G, B;
         int EtR, EtG, EtB = 0;    //E - matem ozidanie  t - iznacal image s- image svet R G B - Kanali 
         int EsR, EsG, EsB = 0;
         int DtR, DtG, DtB = 0;
         int DsR, DsG, DsB = 0;
         int Nt, Ns; //kol-vo pixel 

        private void NewBitmap(Bitmap bit)
        {
            bmp2 = new Bitmap(bit);
            pictureBox2.Image = bmp2;
        }
        private void CountEsDs()
        {
            for (int i = 0; i < bmp3.Width; i++) // Es
            {
                for (int j = 0; j < bmp3.Height; j++)
                {
                    Color pixColor = bmp3.GetPixel(i, j);
                    EsR += pixColor.R;
                    EsG += pixColor.G;
                    EsB += pixColor.B;
                }
            }

            EsR = EsR / Ns;
            EsG = EsG / Ns;
            EsB = EsB / Ns;

            for (int i = 0; i < bmp3.Width; i++) // Ds
            {
                for (int j = 0; j < bmp3.Height; j++)
                {
                    Color pixColor = bmp3.GetPixel(i, j);

                    DsR += Convert.ToInt32(Math.Pow((pixColor.R - EsR), 2));
                    DsG += Convert.ToInt32(Math.Pow((pixColor.G - EsG), 2)); 
                    DsB += Convert.ToInt32(Math.Pow((pixColor.B - EsB), 2)); 
                }
            }
            DsR = Convert.ToInt32(Math.Pow((DsR / Ns), 0.5));
            DsG = Convert.ToInt32(Math.Pow((DsG / Ns), 0.5));
            DsB = Convert.ToInt32(Math.Pow((DsB / Ns), 0.5));
        }
        private void CountEtDt()
        {
            for (int i = 0; i < bmp.Width; i++) // Et 
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixColor = bmp.GetPixel(i, j);
                    EtR += pixColor.R;
                    EtG += pixColor.G;
                    EtB += pixColor.B;
                }
            }

            EtR = EtR / Nt;
            EtG = EtG / Nt;
            EtB = EtB / Nt;

            for (int i = 0; i < bmp.Width; i++) // Dt
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixColor = bmp.GetPixel(i, j);

                    DtR += Convert.ToInt32(Math.Pow((pixColor.R - EtR), 2));
                    DtG += Convert.ToInt32(Math.Pow((pixColor.G - EtG), 2)); 
                    DtB += Convert.ToInt32(Math.Pow((pixColor.B - EtB), 2)); 
                }
            }
            DtR = Convert.ToInt32(Math.Pow((DtR/Nt),0.5));
            DtG = Convert.ToInt32(Math.Pow((DtG/Nt),0.5));
            DtB = Convert.ToInt32(Math.Pow((DtB/Nt),0.5));
        }
        private int NewC(int C,int Es, int Et, int Ds, int Dt) {
            int Ctnew = 0;
            Ctnew = Es +((C-Et)*(Ds/Dt));
            if(Math.Abs(Ctnew) > 255) Ctnew = 255;
            return Math.Abs(Ctnew);

        }

        private void ColorCorect() {
            for (int i = 0; i < bmp.Width; i++) // Dt
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixColor = bmp.GetPixel(i, j);
                    bmp.SetPixel(i, j, System.Drawing.Color.FromArgb(NewC(pixColor.R,EsR,EtR,DsR,DtR), NewC(pixColor.G, EsG, EtG, DsG, DtG), NewC(pixColor.B, EsB, EtB, DsB, DtB)));

                }
            }
            pictureBox3.Image = bmp;
            pictureBox3.Refresh();
        }

        private void buttonNewcollor_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files (*.*) | *.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bmp3 = new Bitmap(dialog.FileName);
                pictureBox1.Image = bmp3; // picture box 1 dlya image-svet  2 dlya originala 3 dlya result
                pictureBox1.Refresh();
                Ns = bmp3.Width * bmp3.Height;
            }
            CountEsDs();
            ColorCorect();

            }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(bmp2, 0, 0, bmp.Width, bmp.Height);
            Close();
        }
    }
}
