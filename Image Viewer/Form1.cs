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

namespace Image_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            SetSize();
            
        }
        private bool isMouse = false;
        private int x1click, y1click;
        

        private class ArrayPoint
        {
            private int index = 0;
            private Point[] points;
            public ArrayPoint(int size)
            {
                if (size <= 0) { size = 2; }
                points = new Point[size];
            }
            public void SetPoint(int x, int y)
            {
                if (index >= points.Length)
                {
                    index = 0;
                }
                points[index] = new Point(x, y);
                index++;
            }
            public void ResetPoints()
            {
                index = 0;
            }
            public int GetCountPoints()
            { return index; }
            public Point[] GetPoints()
            {
                return points;
            }
        }
        private ArrayPoint arrayPoint = new ArrayPoint(2);
        Color color = Color.Black;
        Bitmap map;
        int imagew, imageh;
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 1f);
        


        private void SetSizeMode()
        {
            if (RadioButtonNormal.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            else
                if (RadioButtonStretch.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                    if (RadioButtonCenter.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            else
                        if (RadioButtonZoom.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void OpenFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files (*.*) | *.*";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                map = new Bitmap(dialog.FileName);
                imageh = map.Height;
                imagew = map.Width;
                pictureBox1.Image = new Bitmap(imagew,imageh);
                pictureBox1.Refresh();
                graphics = Graphics.FromImage(map);
               

            }
        }

        private void DoNewText(string text)
        {
            Font font = fontDialog1.Font;
            Brush brush = new SolidBrush(color);
            Bitmap pic1 = new Bitmap(map.Width,map.Height);
            Graphics g1;
            g1 = Graphics.FromImage(pic1);
            g1.Clear(pictureBox1.BackColor);
            graphics.DrawString(text, font, brush, x1click, y1click);
            pictureBox1.Refresh();
            g1.DrawImage(map, 0, 0,map.Width,map.Height);
            pictureBox1.Image = pic1;
            
            


            pictureBox1.Refresh();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void AboutUsButton_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void RadioButtonNormal_CheckedChanged(object sender, EventArgs e)
        {
            SetSizeMode();
        }

        private void RadioButtonStretch_CheckedChanged(object sender, EventArgs e)
        {
           SetSizeMode();
        }

        private void RadioButtonCenter_CheckedChanged(object sender, EventArgs e)
        {
            SetSizeMode();
        }

        private void RadioButtonZoom_CheckedChanged(object sender, EventArgs e)
        {
            SetSizeMode();
        }

       

        

        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
            x1click = e.X;
            y1click = e.Y;
            if (RadioButtonText.Checked)
            {
                textBox2.Visible = true;
                textBox2.Location = (e.Location);

                
              

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            arrayPoint.ResetPoints();
            
            if (RadioButtonRectangle.Checked)
            {
                graphics.DrawRectangle(pen, x1click, y1click, e.X - x1click, e.Y - y1click);
            }
            if (RadioButtonLine.Checked)
            { 
                graphics.DrawLine(pen, x1click, y1click, e.X, e.Y);
            }
            if (RadioButtonEllipse.Checked)
            {
                graphics.DrawEllipse(pen, x1click, y1click, e.X, e.Y);
            }
            pictureBox1.Image = map;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse) { return; }



            if (RadioButtonPen.Checked) {
                arrayPoint.SetPoint(e.X, e.Y);
                if (arrayPoint.GetCountPoints() >= 2)
                {
                    graphics.DrawLines(pen, arrayPoint.GetPoints());
                    pictureBox1.Image = map;
                    arrayPoint.SetPoint((int)e.X, (int)e.Y);
                } }
            else
                 if (RadioButtonRectangle.Checked)
            {
                Image pic1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g1 = Graphics.FromImage(pic1);
                g1.DrawImage(map, 0, 0,map.Width,map.Height);
                pictureBox1.Image = pic1;

                int x, y;
                x = x1click;
                y = y1click;
                if (x > e.X) x = e.X;
                if (y > e.Y) y = e.Y;
                
                g1.DrawRectangle(pen, x, y, Math.Abs(e.X - x1click), Math.Abs(e.Y - y1click));

                pictureBox1.Refresh();
                g1.Clear(pictureBox1.BackColor);
                g1.DrawImage(map,0,0, map.Width, map.Height);
                pictureBox1.Image = pic1;
                

            }
            else
                 if (RadioButtonLine.Checked)
            {
                Bitmap pic1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g1 = Graphics.FromImage(pic1);
                g1.DrawImage(map, 0, 0, map.Width, map.Height);
                pictureBox1.Image = pic1;
                
                g1.DrawLine(pen,x1click,y1click,e.X, e.Y);
                pictureBox1.Refresh();
                g1.Clear(pictureBox1.BackColor);
                g1.DrawImage(map,0,0, map.Width, map.Height);
                pictureBox1.Image = pic1;
                
            }
            else
                 if (RadioButtonEllipse.Checked)
            {
                Bitmap pic1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g1 = Graphics.FromImage(pic1);
                g1.DrawImage(map, 0, 0, map.Width, map.Height);
                pictureBox1.Image = pic1;
                
                g1.DrawEllipse(pen, x1click, y1click, e.X, e.Y);
                pictureBox1.Refresh();
                g1.Clear(pictureBox1.BackColor);
                g1.DrawImage(map, 0, 0, map.Width, map.Height);
                pictureBox1.Image = pic1;

                
            }



        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            color = ((Button)sender).BackColor;
            pen.Color = ((Button)sender).BackColor;
        }

        private void ChangeColorButton_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                color = colorDialog1.Color;
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphics.Clear(pictureBox1.BackColor);
            pictureBox1.Image = map;
            SetSize();
        }

        private void ArrialButton_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK) {  }
        }

        private void RadioButtonText_CheckedChanged(object sender, EventArgs e)
        {
            ArrialButton.Visible = true;
            
        }

        private void RadioButtonPen_CheckedChanged(object sender, EventArgs e)
        {
            ArrialButton.Visible = false;
            textBox2.Visible = false;
            textBox2.Text = "";
            textBox2.Location = new Point(863, 729);

        }

        private void линейнаяКоррекцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinearСolorСorrection linearСolorСorrection = new LinearСolorСorrection(map);
            linearСolorСorrection.Show();
            pictureBox1.Image = map;
            pictureBox1.Refresh();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Font font = fontDialog1.Font;
            textBox2.Font = font;
            textBox2.ForeColor = color;
            textBox2.Width = 10 + textBox2.TextLength*Convert.ToInt32(font.Size);

            
            }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoNewText(textBox2.Text);
                textBox2.Visible = false;
                textBox2.Location = new Point(863, 729);
                textBox2.Text = "";
            }
        }

        private void StaticColorCorect_Click(object sender, EventArgs e)
        {
            StaticColorCorect staticColorCorect = new StaticColorCorect(map);
            staticColorCorect.Show();
            pictureBox1.Image = map;
            pictureBox1.Refresh();
           
        }

        private void reflectorMenuStrip_Click(object sender, EventArgs e)
        {
            Reflector reflector = new Reflector(map);
            reflector.Show();
            pictureBox1.Image = map;
            pictureBox1.Refresh();
        }

        private void гауссовскоеРазмытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gauss gauss = new Gauss(map);
            gauss.Show();
            pictureBox1.Image = map;
            pictureBox1.Refresh();
        }

        private void операторСобеляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SobelOperation sobelOperation = new SobelOperation(map);
            sobelOperation.Show();
            pictureBox1.Image = map;
            pictureBox1.Refresh();
        }

        private void ButtunEmboss_Click(object sender, EventArgs e)
        {
            EmbossFoam embossFoam = new EmbossFoam(map);
            embossFoam.Show();
            pictureBox1.Image = map;
            pictureBox1.Refresh();
        }

        private void Akvarel_Click(object sender, EventArgs e)
        {
            AcvarelFoam acvarelFoam = new AcvarelFoam(map);
            acvarelFoam.Show();
            pictureBox1.Refresh();
        }

        private void DilationButton_Click(object sender, EventArgs e)
        {
            Dillation dillation = new Dillation(map);
            dillation.Show();
            pictureBox1.Refresh();

        }

        private void PovorotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp2 = new Bitmap(map.Height, map.Width);

            for (int i = 0; i < map.Width; i++)
            {
                for (int j = 0; j < map.Height; j++)
                {
                    bmp2.SetPixel(bmp2.Width - j - 1, i, map.GetPixel(i, j));
                }
            }
            map = new Bitmap(bmp2);
            graphics = Graphics.FromImage(map);
            graphics.DrawImage(bmp2, 0, 0, bmp2.Width, bmp2.Height);

            pictureBox1.Image = map;
            pictureBox1.Refresh();
        }

        private void BinarImageButton_Click(object sender, EventArgs e)
        {
            Color color = new Color();
            int P = 80;
            
                for (int j = 0; j < map.Height; j++)
                {
                    for (int i = 0; i < map.Width; i++)
                    {
                        color = map.GetPixel(i, j);
                        int K = (color.R + color.G + color.B) / 3;
                        map.SetPixel(i, j, K <= P ? Color.Black : Color.White);
                    }
                }
                pictureBox1.Image=map;
                pictureBox1.Refresh();

            }

        private void BlackWhiteButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) 
            {
                
                Bitmap input = new Bitmap(pictureBox1.Image);
                
                Bitmap output = new Bitmap(input.Width, input.Height);
                
                for (int j = 0; j < input.Height; j++)
                    for (int i = 0; i < input.Width; i++)
                    {
                        
                        UInt32 pixel = (UInt32)(input.GetPixel(i, j).ToArgb());
                        
                        float R = (float)((pixel & 0x00FF0000) >> 16); 
                        float G = (float)((pixel & 0x0000FF00) >> 8); 
                        float B = (float)(pixel & 0x000000FF); 
                                                               
                        R = G = B = (R + G + B) / 3.0f;
                        
                        UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                        
                        output.SetPixel(i, j, Color.FromArgb((int)newPixel));
                    }
               
                pictureBox1.Image = output;
            }
        }

        private void erosionButton_Click(object sender, EventArgs e)
        {
            Erosion erosion = new Erosion(map);
            erosion.Show();
            pictureBox1.Refresh();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                }
            }
        }

    }
}
