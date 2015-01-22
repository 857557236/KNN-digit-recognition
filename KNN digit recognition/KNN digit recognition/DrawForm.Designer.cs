namespace KNN_digit_recognition
{
    partial class DrawForm
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
            this.predicion_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Classify_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // K_text
            // 
            this.K_text.Location = new System.Drawing.Point(71, 26);
            this.K_text.Name = "K_text";
            this.K_text.Size = new System.Drawing.Size(36, 20);
            this.K_text.TabIndex = 10;
            this.K_text.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "K : ";
            // 
            // predicion_text
            // 
            this.predicion_text.Location = new System.Drawing.Point(467, 226);
            this.predicion_text.Name = "predicion_text";
            this.predicion_text.ReadOnly = true;
            this.predicion_text.Size = new System.Drawing.Size(67, 20);
            this.predicion_text.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prediction : ";
            // 
            // Classify_button
            // 
            this.Classify_button.Location = new System.Drawing.Point(459, 46);
            this.Classify_button.Name = "Classify_button";
            this.Classify_button.Size = new System.Drawing.Size(75, 23);
            this.Classify_button.TabIndex = 13;
            this.Classify_button.Text = "Classify";
            this.Classify_button.UseVisualStyleBackColor = true;
            this.Classify_button.Click += new System.EventHandler(this.Classify_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(44, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(45, 71);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // DrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 343);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Classify_button);
            this.Controls.Add(this.predicion_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.K_text);
            this.Controls.Add(this.label3);
            this.Name = "DrawForm";
            this.Text = "DrawForm";
            this.Shown += new System.EventHandler(this.DrawForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox K_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox predicion_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Classify_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Clear;
    }
}