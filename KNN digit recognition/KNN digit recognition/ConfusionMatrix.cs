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
    public partial class ConfusionMatrix : Form
    {
        public ConfusionMatrix()
        {
            InitializeComponent();
        }

        private void ConfusionMatrix_Shown(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.ColumnCount = 10;
            dataGridView1.Columns[0].Name = "Class 1";
            dataGridView1.Columns[1].Name = "Class 2";
            dataGridView1.Columns[2].Name = "Class 3";
            dataGridView1.Columns[3].Name = "Class 4";
            dataGridView1.Columns[4].Name = "Class 5";
            dataGridView1.Columns[5].Name = "Class 6";
            dataGridView1.Columns[6].Name = "Class 7";
            dataGridView1.Columns[7].Name = "Class 8";
            dataGridView1.Columns[8].Name = "Class 9";
            dataGridView1.Columns[9].Name = "Class 10";
            dataGridView1.RowCount = 10;
            dataGridView1.Rows[0].HeaderCell.Value = "Class 1";
            dataGridView1.Rows[1].HeaderCell.Value = "Class 2";
            dataGridView1.Rows[2].HeaderCell.Value = "Class 3";
            dataGridView1.Rows[3].HeaderCell.Value = "Class 4";
            dataGridView1.Rows[4].HeaderCell.Value = "Class 5";
            dataGridView1.Rows[5].HeaderCell.Value = "Class 6";
            dataGridView1.Rows[6].HeaderCell.Value = "Class 7";
            dataGridView1.Rows[7].HeaderCell.Value = "Class 8";
            dataGridView1.Rows[8].HeaderCell.Value = "Class 9";
            dataGridView1.Rows[9].HeaderCell.Value = "Class 10";
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    dataGridView1.Rows[i].Cells[j].Value = KNN.confusionMatrix[i, j];
        }
    }
}
