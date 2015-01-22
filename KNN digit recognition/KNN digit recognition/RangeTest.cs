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
    public partial class RangeTest : Form
    {
        public RangeTest()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RangeTest_Shown(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Image Index";
            dataGridView1.Columns[1].Name = "Label";
            dataGridView1.Columns[2].Name = "Prediction";

        }


        private void Classify_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            int l = Math.Min(Convert.ToInt32(imageLeftIndex.Text), Convert.ToInt32(imageRightIndex.Text));
            int r = Math.Max(Convert.ToInt32(imageLeftIndex.Text), Convert.ToInt32(imageRightIndex.Text));
            l--;
            r--;
            if (l >= 0 && r < 10000 && Convert.ToInt32(K_text.Text)<=60000)
            {
               double accuracy= KNN.Classify(l, r, ReadingInput.testImages, ReadingInput.trainImages, Convert.ToInt32(K_text.Text));

                int index = 0;
                for (int i = 0; i <= r - l; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = KNN.testResults[index];
                    row.Cells[1].Value = KNN.testResults[index+1];
                    row.Cells[2].Value = KNN.testResults[index + 2];
                    index = index + 3;
                   dataGridView1.Rows.Add(row);
                }
                accuracy_text.Text = accuracy.ToString() + "%";
                ConfusionMatrix CM = new ConfusionMatrix();
                CM.Show();
            }

        }


    }
}
