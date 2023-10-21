namespace analizaobrazw
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UploadButton = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this.GrayButton = new System.Windows.Forms.Button();
            this.grayImage = new System.Windows.Forms.PictureBox();
            this.binaryImage = new System.Windows.Forms.PictureBox();
            this.Binarybutton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.whiteLabel = new System.Windows.Forms.Label();
            this.blackLabel = new System.Windows.Forms.Label();
            this.transformImage = new System.Windows.Forms.PictureBox();
            this.tranformButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.histogramBox = new System.Windows.Forms.PictureBox();
            this.sobelImageBox = new System.Windows.Forms.PictureBox();
            this.SobelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transformImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobelImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(12, 12);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(91, 27);
            this.UploadButton.TabIndex = 0;
            this.UploadButton.Text = "Load";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // image
            // 
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Location = new System.Drawing.Point(12, 59);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(382, 229);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            // 
            // GrayButton
            // 
            this.GrayButton.Location = new System.Drawing.Point(109, 12);
            this.GrayButton.Name = "GrayButton";
            this.GrayButton.Size = new System.Drawing.Size(91, 27);
            this.GrayButton.TabIndex = 2;
            this.GrayButton.Text = "Grayscale";
            this.GrayButton.UseVisualStyleBackColor = true;
            this.GrayButton.Click += new System.EventHandler(this.Graybutton_Click);
            // 
            // grayImage
            // 
            this.grayImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grayImage.Location = new System.Drawing.Point(400, 59);
            this.grayImage.Name = "grayImage";
            this.grayImage.Size = new System.Drawing.Size(382, 229);
            this.grayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grayImage.TabIndex = 3;
            this.grayImage.TabStop = false;
            // 
            // binaryImage
            // 
            this.binaryImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.binaryImage.Location = new System.Drawing.Point(12, 351);
            this.binaryImage.Name = "binaryImage";
            this.binaryImage.Size = new System.Drawing.Size(382, 229);
            this.binaryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.binaryImage.TabIndex = 4;
            this.binaryImage.TabStop = false;
            // 
            // Binarybutton
            // 
            this.Binarybutton.Location = new System.Drawing.Point(206, 12);
            this.Binarybutton.Name = "Binarybutton";
            this.Binarybutton.Size = new System.Drawing.Size(91, 27);
            this.Binarybutton.TabIndex = 5;
            this.Binarybutton.Text = "Binarization";
            this.Binarybutton.UseVisualStyleBackColor = true;
            this.Binarybutton.Click += new System.EventHandler(this.Binarybutton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(231, 300);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(163, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 1;
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // whiteLabel
            // 
            this.whiteLabel.AutoSize = true;
            this.whiteLabel.Location = new System.Drawing.Point(8, 310);
            this.whiteLabel.Name = "whiteLabel";
            this.whiteLabel.Size = new System.Drawing.Size(38, 13);
            this.whiteLabel.TabIndex = 7;
            this.whiteLabel.Text = "White:";
            // 
            // blackLabel
            // 
            this.blackLabel.AutoSize = true;
            this.blackLabel.Location = new System.Drawing.Point(9, 332);
            this.blackLabel.Name = "blackLabel";
            this.blackLabel.Size = new System.Drawing.Size(37, 13);
            this.blackLabel.TabIndex = 8;
            this.blackLabel.Text = "Black:";
            // 
            // transformImage
            // 
            this.transformImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transformImage.Location = new System.Drawing.Point(400, 351);
            this.transformImage.Name = "transformImage";
            this.transformImage.Size = new System.Drawing.Size(382, 229);
            this.transformImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.transformImage.TabIndex = 9;
            this.transformImage.TabStop = false;
            // 
            // tranformButton
            // 
            this.tranformButton.Location = new System.Drawing.Point(303, 12);
            this.tranformButton.Name = "tranformButton";
            this.tranformButton.Size = new System.Drawing.Size(91, 27);
            this.tranformButton.TabIndex = 10;
            this.tranformButton.Text = "Transform";
            this.tranformButton.UseVisualStyleBackColor = true;
            this.tranformButton.Click += new System.EventHandler(this.transformButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Log",
            "Sqrt"});
            this.comboBox1.Location = new System.Drawing.Point(661, 324);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Sqrt";
            // 
            // histogramBox
            // 
            this.histogramBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.histogramBox.Location = new System.Drawing.Point(788, 59);
            this.histogramBox.Name = "histogramBox";
            this.histogramBox.Size = new System.Drawing.Size(382, 229);
            this.histogramBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.histogramBox.TabIndex = 13;
            this.histogramBox.TabStop = false;
            // 
            // sobelImageBox
            // 
            this.sobelImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sobelImageBox.Location = new System.Drawing.Point(788, 351);
            this.sobelImageBox.Name = "sobelImageBox";
            this.sobelImageBox.Size = new System.Drawing.Size(382, 229);
            this.sobelImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sobelImageBox.TabIndex = 14;
            this.sobelImageBox.TabStop = false;
            // 
            // SobelButton
            // 
            this.SobelButton.Location = new System.Drawing.Point(400, 12);
            this.SobelButton.Name = "SobelButton";
            this.SobelButton.Size = new System.Drawing.Size(91, 27);
            this.SobelButton.TabIndex = 15;
            this.SobelButton.Text = "Sobel";
            this.SobelButton.UseVisualStyleBackColor = true;
            this.SobelButton.Click += new System.EventHandler(this.SobelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 596);
            this.Controls.Add(this.SobelButton);
            this.Controls.Add(this.sobelImageBox);
            this.Controls.Add(this.histogramBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tranformButton);
            this.Controls.Add(this.transformImage);
            this.Controls.Add(this.blackLabel);
            this.Controls.Add(this.whiteLabel);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Binarybutton);
            this.Controls.Add(this.binaryImage);
            this.Controls.Add(this.grayImage);
            this.Controls.Add(this.GrayButton);
            this.Controls.Add(this.image);
            this.Controls.Add(this.UploadButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "image analysis";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transformImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobelImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button GrayButton;
        private System.Windows.Forms.PictureBox grayImage;
        private System.Windows.Forms.PictureBox binaryImage;
        private System.Windows.Forms.Button Binarybutton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label whiteLabel;
        private System.Windows.Forms.Label blackLabel;
        private System.Windows.Forms.PictureBox transformImage;
        private System.Windows.Forms.Button tranformButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox histogramBox;
        private System.Windows.Forms.PictureBox sobelImageBox;
        private System.Windows.Forms.Button SobelButton;
    }
}

