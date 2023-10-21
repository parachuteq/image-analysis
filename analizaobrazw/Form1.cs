using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace analizaobrazw
{
    public partial class Form1 : Form
    {
        private Bitmap img;
        private Bitmap grayImg;
        private Bitmap binary;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void UploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Open Image";
                dialog.Filter = "JPG files (*.jpg)|*.jpg";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    img = new Bitmap(dialog.FileName);
                    image.Image = img;
                }
            }
        }

        private void Graybutton_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                grayImg = ConvertToGrayscale(img);
                grayImage.Image = grayImg;

                int[] histogram = GenerateHistogram(grayImg);
                DrawHistogram(histogram, histogramBox, "Poziomy szarości", "Liczba pikseli");
            }
        }

        private void Binarybutton_Click(object sender, EventArgs e)
        {
            if (grayImg != null)
            {
                UpdateImage(128);
            }
        }

        private void UpdateImage(int value)
        {
            if (grayImg != null)
            {
                binary = ConvertToBinary(grayImg, value);
                binaryImage.Image = binary;

                double white, black;
                CalculateWhiteBlackPercentage(binary, out white, out black);

                whiteLabel.Text = "White: " + white.ToString("0.00") + "%";
                blackLabel.Text = "Black: " + black.ToString("0.00") + "%";

                int[] histogram = GenerateHistogram(grayImg);
                DrawHistogram(histogram, histogramBox, "Poziomy szarości", "Liczba pikseli");
            }
        }

        private Bitmap ConvertToGrayscale(Bitmap image)
        {
            Bitmap grayImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color originalColor = image.GetPixel(i, j);
                    int grayScale = (int)((originalColor.R * 0.3) + (originalColor.G * 0.59) + (originalColor.B * 0.11));
                    Color newColor = Color.FromArgb(originalColor.A, grayScale, grayScale, grayScale);
                    grayImage.SetPixel(i, j, newColor);
                }
            }

            return grayImage;
        }

        private Bitmap ConvertToBinary(Bitmap image, int threshold)
        {
            Bitmap binaryImage = new Bitmap(image.Width, image.Height);
            double white = 0;
            double black = 0;

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    Color pixelColor = image.GetPixel(j, i);
                    int avgColor = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color binaryColor = avgColor < threshold ? Color.Black : Color.White;

                    if (binaryColor == Color.Black)
                    {
                        black++;
                    }
                    else
                    {
                        white++;
                    }

                    binaryImage.SetPixel(j, i, binaryColor);
                }
            }

            return binaryImage;
        }

        private void CalculateWhiteBlackPercentage(Bitmap image, out double white, out double black)
        {
            white = black = 0;

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    Color pixelColor = image.GetPixel(j, i);

                    if (pixelColor == Color.Black)
                    {
                        black++;
                    }
                    else
                    {
                        white++;
                    }
                }
            }

            white = (white / (white + black)) * 100;
            black = (black / (white + black)) * 100;
        }

        private int[] GenerateHistogram(Bitmap image)
        {
            int[] histogram = new int[256];

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color pixelColor = image.GetPixel(i, j);
                    int grayScale = (int)((pixelColor.R * 0.3) + (pixelColor.G * 0.59) + (pixelColor.B * 0.11));
                    histogram[grayScale]++;
                }
            }

            return histogram;
        }

        private void DrawHistogram(int[] histogram, PictureBox pictureBox, string xAxisLabel, string yAxisLabel)
        {
            Bitmap histogramImage = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics graphics = Graphics.FromImage(histogramImage);

            int maxCount = histogram.Length > 0 ? histogram.Max() : 1;

            for (int i = 0; i < histogram.Length; i++)
            {
                int barHeight = (int)(((double)histogram[i] / maxCount) * pictureBox.Height);
                graphics.DrawLine(Pens.Black, i, pictureBox.Height, i, pictureBox.Height - barHeight);
            }

            pictureBox.Image = histogramImage;
            graphics.DrawString(xAxisLabel, SystemFonts.DefaultFont, Brushes.Black, new PointF(pictureBox.Width / 2, pictureBox.Height - 20));
            graphics.DrawString(yAxisLabel, SystemFonts.DefaultFont, Brushes.Black, new PointF(5, pictureBox.Height / 2), new StringFormat(StringFormatFlags.DirectionVertical));
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            UpdateImage(trackBar1.Value);
        }

        private void transformButton_Click(object sender, EventArgs e)
        {
            if (grayImg != null)
            {
                int width = grayImg.Width;
                int height = grayImg.Height;
                Bitmap transformImg = new Bitmap(width, height);

                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        Color pixelColor = grayImg.GetPixel(i, j);
                        byte pixelValue = pixelColor.R;

                        if (comboBox1.Text == "Sqrt")
                        {
                            double sqrtPixelValue = Math.Sqrt(pixelValue);
                            byte normalizedValue = (byte)(sqrtPixelValue / Math.Sqrt(255) * 255);
                            Color color = Color.FromArgb(pixelColor.A, normalizedValue, normalizedValue, normalizedValue);
                            transformImg.SetPixel(i, j, color);
                        }
                        else if (comboBox1.Text == "Log")
                        {
                            double logPixelValue = Math.Log(pixelValue + 1, 2);
                            byte normalizedValue = (byte)(logPixelValue / Math.Sqrt(255) * 255);
                            Color color = Color.FromArgb(pixelColor.A, normalizedValue, normalizedValue, normalizedValue);
                            transformImg.SetPixel(i, j, color);
                        }
                    }
                }

                transformImage.Image = transformImg;
                int[] histogram = GenerateHistogram(transformImg);
                DrawHistogram(histogram, histogramBox, "Poziomy szarości", "Liczba pikseli");
            }
        }

        private Bitmap Sobel(Bitmap bitmap)
        {
            Bitmap bitmapClone = (Bitmap)bitmap.Clone();
            int[,] sobelX = new int[3, 3] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            int[,] sobelY = new int[3, 3] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };

            for (int y = 1; y < bitmapClone.Height - 1; y++)
            {
                for (int x = 1; x < bitmapClone.Width - 1; x++)
                {
                    int pixelValueX = 0;
                    int pixelValueY = 0;

                    for (int j = 0; j < 3; j++)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Color pixelColor = bitmapClone.GetPixel(x + i - 1, y + j - 1);
                            int grayscaleValue = pixelColor.R;
                            pixelValueX += sobelX[i, j] * grayscaleValue;
                            pixelValueY += sobelY[i, j] * grayscaleValue;
                        }
                    }

                    int sobelValue = (int)Math.Sqrt(pixelValueX * pixelValueX + pixelValueY * pixelValueY);
                    sobelValue = Math.Min(255, sobelValue);
                    sobelValue = Math.Max(0, sobelValue); // Ensure the value is not negative
                    Color sobelColor = Color.FromArgb(sobelValue, sobelValue, sobelValue);
                    bitmapClone.SetPixel(x, y, sobelColor);
                }
            }

            return bitmapClone;
        }

        private void SobelButton_Click(object sender, EventArgs e)
        {
            if (grayImg != null)
            {
                Bitmap sobelImage = Sobel(grayImg);
                sobelImageBox.Image = sobelImage;
            }
        }

    }
}
