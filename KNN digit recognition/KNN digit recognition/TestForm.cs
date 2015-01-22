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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void show_Image_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(28,28);
            int index =Convert.ToInt32(imageIndex.Text);
            index--;
            if (index >= 0 && index < 10000)
            {
                for (int i = 0; i < 28; i++)
                {
                    for (int j = 0; j < 28; j++)
                    {
                        image.SetPixel(j, i, Color.FromArgb(ReadingInput.testImages[index].pixels[i, j], ReadingInput.testImages[index].pixels[i, j], ReadingInput.testImages[index].pixels[i, j]));
                    }
                }
                pictureBox1.Image = image;
                
            }
        }

        private void Classify_button_Click(object sender, EventArgs e)
        {
            int index =Convert.ToInt32(imageIndex.Text);
            index--;
            if (index >= 0 && index < 10000 && Convert.ToInt32(K_text.Text)<=60000)
            {
                byte pred=KNN.Classify(ReadingInput.testImages[index], ReadingInput.trainImages, Convert.ToInt32(K_text.Text));
                predicion_text.Text = pred.ToString();
            }
        }

        private void TestForm_Shown(object sender, EventArgs e)
        {

        }

    }
}
