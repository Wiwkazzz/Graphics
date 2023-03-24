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
    public partial class Gauss : Form
    {
        public Gauss(Bitmap bit)
        {
            InitializeComponent();
            bmp = bit;
            NewBitmap(bit);

            GaussCorrectarr3x3();
           
            pictureBox2.Image = bmp;
            pictureBox2.Refresh();
        }
        Bitmap bmp, bmp2;
      
        
        int R, G, B;

        int[,] arr1 = new int[3, 3] { {0,1,0 },
                                      {1,2,1 },
                                      {0,1,0 }};
        double[,] arr2 = new double[3, 3] { {0.5, 0.75, 0.5 },
                                            {0.75, 1  , 0.75 },
                                            {0.5, 0.75, 0.5 }};



       

        private void NewBitmap(Bitmap bit)
        {
            bmp2 = new Bitmap(bit);
            pictureBox1.Image = bmp2;
            pictureBox1.Refresh();
           
        }

        private int Count(int[,] arr)
        {
            double pixcolor = 0;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    pixcolor += arr[i,j] * arr2[i, j];
                }
            }
            pixcolor = pixcolor * 1 / 6;

            return Convert.ToInt32(pixcolor);
        }

        private void GaussCorrectarr3x3()
        {
          
            int[,] array = new int[3, 3];

            for (int i = 1 ; i < bmp.Width - 1  ; i++)
            {
                
                for (int j = 1; j < bmp.Height - 1 ; j++) {

                    int[,] arrR = new int[3, 3] {   { Convert.ToInt32((bmp.GetPixel(i-1, j-1)).R), Convert.ToInt32((bmp.GetPixel(i, j-1)).R), Convert.ToInt32((bmp.GetPixel(i+1, j-1)).R) },     //sozdanie 3 massivov 3x3 po kajdomy cvety 
                                                    { Convert.ToInt32((bmp.GetPixel(i-1, j)).R), Convert.ToInt32((bmp.GetPixel(i, j)).R), Convert.ToInt32((bmp.GetPixel(i+1, j)).R) },
                                                    { Convert.ToInt32((bmp.GetPixel(i-1, j+1)).R), Convert.ToInt32((bmp.GetPixel(i, j+1)).R), Convert.ToInt32((bmp.GetPixel(i+1, j+1)).R) } };

                    int[,] arrG = new int[3, 3] {   { Convert.ToInt32((bmp.GetPixel(i-1, j-1)).G), Convert.ToInt32((bmp.GetPixel(i, j-1)).G), Convert.ToInt32((bmp.GetPixel(i+1, j-1)).G) },     
                                                    { Convert.ToInt32((bmp.GetPixel(i-1, j)).G), Convert.ToInt32((bmp.GetPixel(i, j)).G), Convert.ToInt32((bmp.GetPixel(i+1, j)).G) },
                                                    { Convert.ToInt32((bmp.GetPixel(i-1, j+1)).G), Convert.ToInt32((bmp.GetPixel(i, j+1)).G), Convert.ToInt32((bmp.GetPixel(i+1, j+1)).G) } };

                    int[,] arrB = new int[3, 3] {   { Convert.ToInt32((bmp.GetPixel(i-1, j-1)).B), Convert.ToInt32((bmp.GetPixel(i, j-1)).B), Convert.ToInt32((bmp.GetPixel(i+1, j-1)).B) },     
                                                    { Convert.ToInt32((bmp.GetPixel(i-1, j)).B), Convert.ToInt32((bmp.GetPixel(i, j)).B), Convert.ToInt32((bmp.GetPixel(i+1, j)).B) },
                                                    { Convert.ToInt32((bmp.GetPixel(i-1, j+1)).B), Convert.ToInt32((bmp.GetPixel(i, j+1)).B), Convert.ToInt32((bmp.GetPixel(i+1, j+1)).B) } };




                    bmp.SetPixel(i, j, System.Drawing.Color.FromArgb(Count(arrR), Count(arrG), Count(arrB)));
                        
                    
                    
                }

                
                }
            
            pictureBox2.Image = bmp;
            pictureBox2.Refresh();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(bmp2, 0, 0, bmp.Width, bmp.Height);
            pictureBox2.Image = bmp;
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
