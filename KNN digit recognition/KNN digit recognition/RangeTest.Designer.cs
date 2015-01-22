namespace KNN_digit_recognition
{
    partial class RangeTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.K_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imageLeftIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Classify_button = new System.Windows.Forms.Button();
            this.imageRightIndex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accuracy_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // K_text
            // 
            this.K_text.Location = new System.Drawing.Point(331, 12);
            this.K_text.Name = "K_text";
            this.K_text.Size = new System.Drawing.Size(36, 20);
            this.K_text.TabIndex = 12;
            this.K_text.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "K : ";
            // 
            // imageLeftIndex
            // 
            this.imageLeftIndex.Location = new System.Drawing.Point(197, 12);
            this.imageLeftIndex.Name = "imageLeftIndex";
            this.imageLeftIndex.Size = new System.Drawing.Size(77, 20);
            this.imageLeftIndex.TabIndex = 10;
            this.imageLeftIndex.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "From test image number (1-10000): ";
            // 
            // Classify_button
            // 
            this.Classify_button.Location = new System.Drawing.Point(525, 52);
            this.Classify_button.Name = "Classify_button";
            this.Classify_button.Size = new System.Drawing.Size(75, 23);
            this.Classify_button.TabIndex = 13;
            this.Classify_button.Text = "Classify";
            this.Classify_button.UseVisualStyleBackColor = true;
            this.Classify_button.Click += new System.EventHandler(this.Classify_button_Click);
            // 
            // imageRightIndex
            // 
            this.imageRightIndex.Location = new System.Drawing.Point(197, 52);
            this.imageRightIndex.Name = "imageRightIndex";
            this.imageRightIndex.Size = new System.Drawing.Size(77, 20);
            this.imageRightIndex.TabIndex = 15;
            this.imageRightIndex.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "To test image number (1-10000): ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 282);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // accuracy_text
            // 
            this.accuracy_text.Location = new System.Drawing.Point(533, 120);
            this.accuracy_text.Name = "accuracy_text";
            this.accuracy_text.ReadOnly = true;
            this.accuracy_text.Size = new System.Drawing.Size(67, 20);
            this.accuracy_text.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Accuracy : ";
            // 
            // RangeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 444);
            this.Controls.Add(this.accuracy_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.imageRightIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Classify_button);
            this.Controls.Add(this.K_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imageLeftIndex);
            this.Controls.Add(this.label1);
            this.Name = "RangeTest";
            this.Text = "RangeTest";
            this.Shown += new System.EventHandler(this.RangeTest_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox K_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox imageLeftIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Classify_button;
        private System.Windows.Forms.TextBox imageRightIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox accuracy_text;
        private System.Windows.Forms.Label label4;
    }
}