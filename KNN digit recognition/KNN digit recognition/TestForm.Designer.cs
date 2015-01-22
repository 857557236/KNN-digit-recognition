namespace KNN_digit_recognition
{
    partial class TestForm
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
            this.Classify_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imageIndex = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.predicion_text = new System.Windows.Forms.TextBox();
            this.show_Image = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.K_text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Classify_button
            // 
            this.Classify_button.Location = new System.Drawing.Point(467, 24);
            this.Classify_button.Name = "Classify_button";
            this.Classify_button.Size = new System.Drawing.Size(75, 23);
            this.Classify_button.TabIndex = 0;
            this.Classify_button.Text = "Classify";
            this.Classify_button.UseVisualStyleBackColor = true;
            this.Classify_button.Click += new System.EventHandler(this.Classify_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of test image(1-10000): ";
            // 
            // imageIndex
            // 
            this.imageIndex.Location = new System.Drawing.Point(193, 21);
            this.imageIndex.Name = "imageIndex";
            this.imageIndex.Size = new System.Drawing.Size(77, 20);
            this.imageIndex.TabIndex = 2;
            this.imageIndex.Text = "1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prediction : ";
            // 
            // predicion_text
            // 
            this.predicion_text.Location = new System.Drawing.Point(460, 198);
            this.predicion_text.Name = "predicion_text";
            this.predicion_text.ReadOnly = true;
            this.predicion_text.Size = new System.Drawing.Size(67, 20);
            this.predicion_text.TabIndex = 5;
            // 
            // show_Image
            // 
            this.show_Image.Location = new System.Drawing.Point(25, 57);
            this.show_Image.Name = "show_Image";
            this.show_Image.Size = new System.Drawing.Size(81, 23);
            this.show_Image.TabIndex = 6;
            this.show_Image.Text = "Show Image";
            this.show_Image.UseVisualStyleBackColor = true;
            this.show_Image.Click += new System.EventHandler(this.show_Image_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "K : ";
            // 
            // K_text
            // 
            this.K_text.Location = new System.Drawing.Point(321, 21);
            this.K_text.Name = "K_text";
            this.K_text.Size = new System.Drawing.Size(36, 20);
            this.K_text.TabIndex = 8;
            this.K_text.Text = "1";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 326);
            this.Controls.Add(this.K_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.show_Image);
            this.Controls.Add(this.predicion_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imageIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Classify_button);
            this.Name = "TestForm";
            this.Text = "Test Form";
            this.Shown += new System.EventHandler(this.TestForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Classify_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imageIndex;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox predicion_text;
        private System.Windows.Forms.Button show_Image;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox K_text;
    }
}

