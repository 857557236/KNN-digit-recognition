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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Test_mode_Click(object sender, EventArgs e)
        {
            TestForm TF = new TestForm();
            TF.Show();
        }

        private void drawMode_Click(object sender, EventArgs e)
        {
            DrawForm DF = new DrawForm();
            DF.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RangeTest RT = new RangeTest();
            RT.Show();
        }
    }
}
