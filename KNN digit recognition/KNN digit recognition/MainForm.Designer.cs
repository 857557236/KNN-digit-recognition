namespace KNN_digit_recognition
{
    partial class MainForm
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
            this.Test_mode = new System.Windows.Forms.Button();
            this.drawMode = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Test_mode
            // 
            this.Test_mode.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test_mode.Location = new System.Drawing.Point(60, 209);
            this.Test_mode.Name = "Test_mode";
            this.Test_mode.Size = new System.Drawing.Size(184, 136);
            this.Test_mode.TabIndex = 0;
            this.Test_mode.Text = "Test Single Image Mode";
            this.Test_mode.UseVisualStyleBackColor = true;
            this.Test_mode.Click += new System.EventHandler(this.Test_mode_Click);
            // 
            // drawMode
            // 
            this.drawMode.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawMode.Location = new System.Drawing.Point(379, 209);
            this.drawMode.Name = "drawMode";
            this.drawMode.Size = new System.Drawing.Size(184, 136);
            this.drawMode.TabIndex = 1;
            this.drawMode.Text = "Draw Mode";
            this.drawMode.UseVisualStyleBackColor = true;
            this.drawMode.Click += new System.EventHandler(this.drawMode_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(223, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 136);
            this.button1.TabIndex = 2;
            this.button1.Text = "Test Range Mode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.drawMode);
            this.Controls.Add(this.Test_mode);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Test_mode;
        private System.Windows.Forms.Button drawMode;
        private System.Windows.Forms.Button button1;

    }
}