using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KNN_digit_recognition
{
    public partial class DrawForm : Form
    {
        public DrawForm()
        {
            InitializeComponent();
        }
        
        bool mouse_down = false;
        Color myColor = Color.White;
        int lastX = 0;
        int lastY = 0;
        int mouseX = 0;
        int mouseY = 0;
        int timeSec = 0;
        int lastTime = 0;
        int penSize=20;



        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_down = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_down = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.Black);
                }
                pictureBox1.Image = bmp;
            }
            if ((mouse_down == true) && ((Math.Abs(lastTime - timeSec) >= 50)))
            {
                SolidBrush clr = new SolidBrush(myColor);
                Graphics g = Graphics.FromImage(pictureBox1.Image);

                g.FillEllipse(clr, e.X, e.Y, penSize, penSize);
                lastTime = timeSec;
                timeSec = System.DateTime.Now.TimeOfDay.Milliseconds;
                lastX = mouseX;
                lastY = mouseY;
                mouseX = e.X;
                mouseY = e.Y;
            }
            else if ((mouse_down == true) && ((Math.Abs(lastTime - timeSec) < 50)))
            {
                SolidBrush clr = new SolidBrush(myColor);
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                Pen p = new Pen(clr, penSize);
                g.DrawLine(p, lastX, lastY, mouseX, mouseY);
                lastTime = timeSec;
                timeSec = System.DateTime.Now.TimeOfDay.Milliseconds;

                lastX = mouseX;
                lastY = mouseY;
                mouseX = e.X;
                mouseY = e.Y;
            }
            pictureBox1.Invalidate();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            //Graphics g1 = pictureBox1.CreateGraphics();
            //g1.Clear(pictureBox1.BackColor);
            pictureBox1.Image = null;
        }

        private void Classify_button_Click(object sender, EventArgs e)
        {
            
            Bitmap drawnImage = new Bitmap(pictureBox1.Image);
            Bitmap resized = new Bitmap(drawnImage, new Size(28, 28));
            pictureBox1.Image = resized;
            byte[,] arr = new byte[28, 28];
            for (int i = 0; i < 28; i++)
                for (int j = 0; j < 28; j++)
                    arr[i, j] = resized.GetPixel(j, i).R;

            DigitImage DI = new DigitImage(arr, 0);
            byte pred = KNN.Classify(DI, ReadingInput.trainImages, Convert.ToInt32(K_text.Text));
            predicion_text.Text = pred.ToString();
        }

        private void DrawForm_Shown(object sender, EventArgs e)
        {
           
        }


    }
}
