using HNUDIP;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WebCamLib;
using static System.Net.Mime.MediaTypeNames;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap loadImage;
        Bitmap resultImage;
        Bitmap ImageA, ImageB, colorgreen;
        

        Device[] devices = DeviceManager.GetAllDevices();
        Device webcam = DeviceManager.GetDevice(0);
        
            Timer captureTimer;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loadImage = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loadImage;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for(int i = 0; i < loadImage.Width; i++)
            {
                for(int j = 0; j < loadImage.Height; j++)
                {
                    Color pixel = loadImage.GetPixel(i, j);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    resultImage.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
                pictureBox2.Image = resultImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)// COPY
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for (int i = 0; i < resultImage.Width; i++)
            {
                for (int j = 0; j < resultImage.Height; j++)
                {
                    Color pixel = loadImage.GetPixel(i, j);
                    resultImage.SetPixel(i, j, pixel);
                }
                pictureBox2.Image = resultImage;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for (int i = 0; i < resultImage.Width; i++)
            {
                for (int j = 0; j < resultImage.Height; j++)
                {
                    Color pixel = loadImage.GetPixel(i, j);

                    int sepiaR = (int)(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B);
                    int sepiaG = (int)(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B);
                    int sepiaB = (int)(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B);

                    resultImage.SetPixel(i, j, Color.FromArgb(Math.Min(255, sepiaR), Math.Min(255, sepiaG), Math.Min(255, sepiaB)));
                }
            }
            pictureBox2.Image = resultImage;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            resultImage.Save(saveFileDialog1.FileName);
        }

        private void Inversion_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for (int i = 0; i < resultImage.Width; i++)
            {
                for (int j = 0; j < resultImage.Height; j++)
                {
                    Color pixel = loadImage.GetPixel(i, j);
                    resultImage.SetPixel(i, j, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }
                pictureBox2.Image = resultImage;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for (int i = 0; i < loadImage.Width; i++)
                for (int j = 0; j < loadImage.Height; j++)
                {
                    Color pixel = loadImage.GetPixel(i, j);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    resultImage.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            Color sample;
            int[] histData = new int[256];
            for (int i = 0; i < loadImage.Width; i++)
                for (int j = 0; j < loadImage.Height; j++)
                {
                    sample = resultImage.GetPixel(i, j);
                    histData[sample.R] = histData[sample.R] + 1;
                }
            Bitmap myData = new Bitmap(256, 800);
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < 800; j++)
                {
                    myData.SetPixel(i, j, Color.White);
                }
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < Math.Min(histData[i] / 5, 800); j++)
                {
                    myData.SetPixel(i, 799 - j, Color.Black);
                }
            pictureBox2.Image = myData;
        }



        // Subtract

        private void button2_Click_2(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            ImageB = new Bitmap(openFileDialog2.FileName);
            pictureBox1.Image = ImageB;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {
            ImageA = new Bitmap(openFileDialog3.FileName);
            pictureBox2.Image = ImageA;
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            Color mygreen = Color.FromArgb(0, 0, 255);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;

            Bitmap resultImage = new Bitmap(ImageB.Width, ImageB.Height);
            for (int i = 0; i < ImageB.Width; i++)
            {
                for (int j = 0; j < ImageB.Height; j++)
                {
                    Color pixel = ImageB.GetPixel(i, j);
                    Color backpixel = ImageA.GetPixel(i, j);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int  subtractvalue = Math.Abs( grey - greygreen );
                    if(subtractvalue < threshold) { 
                        resultImage.SetPixel(i,j,backpixel);
                    }
                    else
                    {
                        resultImage.SetPixel(i, j, pixel);
                    }
                }
                pictureBox2.Image = resultImage;
            }
        }


        // OPEN FILE
        private void openFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        // Load Image
        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        //  Load Background - Only for subtraction
        private void loadBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        // Save Image
        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(this);
        }
        // Copy Loaded Image
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageProcess.copyImage(ref loadImage,ref resultImage);
            pictureBox2.Image = resultImage;
            /*resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for (int i = 0; i < resultImage.Width; i++)
            {
                for (int j = 0; j < resultImage.Height; j++)
                {
                    Color pixel = loadImage.GetPixel(i, j);
                    resultImage.SetPixel(i, j, pixel);
                }
                pictureBox2.Image = resultImage;
            }*/
        }

        // Grey Scale
        private void greyScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for (int i = 0; i < loadImage.Width; i++)
            {
                for (int j = 0; j < loadImage.Height; j++)
                {
                    Color pixel = loadImage.GetPixel(i, j);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    resultImage.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
                pictureBox2.Image = resultImage;
            }
        }


        // Inversion of Loaded Image
        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for (int i = 0; i < resultImage.Width; i++)
            {
                for (int j = 0; j < resultImage.Height; j++)
                {
                    Color pixel = loadImage.GetPixel(i, j);
                    resultImage.SetPixel(i, j, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }
                pictureBox2.Image = resultImage;
            }
        }
        // Sepia Loaded Image
        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for (int i = 0; i < resultImage.Width; i++)
            {
                for (int j = 0; j < resultImage.Height; j++)
                {
                    Color pixel = loadImage.GetPixel(i, j);

                    int sepiaR = (int)(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B);
                    int sepiaG = (int)(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B);
                    int sepiaB = (int)(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B);

                    resultImage.SetPixel(i, j, Color.FromArgb(Math.Min(255, sepiaR), Math.Min(255, sepiaG), Math.Min(255, sepiaB)));
                }
            }
            pictureBox2.Image = resultImage;
        }
        // Histogram
        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {

            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for (int i = 0; i < loadImage.Width; i++)
                for (int j = 0; j < loadImage.Height; j++)
                {
                    Color pixel = loadImage.GetPixel(i, j);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    resultImage.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            Color sample;
            int[] histData = new int[256];
            for (int i = 0; i < loadImage.Width; i++)
                for (int j = 0; j < loadImage.Height; j++)
                {
                    sample = resultImage.GetPixel(i, j);
                    histData[sample.R] = histData[sample.R] + 1;
                }
            Bitmap myData = new Bitmap(256, 800);
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < 800; j++)
                {
                    myData.SetPixel(i, j, Color.White);
                }
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < Math.Min(histData[i] / 5, 800); j++)
                {
                    myData.SetPixel(i, 799 - j, Color.Black);
                }
            pictureBox2.Image = myData;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog4_FileOk(object sender, CancelEventArgs e)
        {

        }
        

        // Open File Dialog 4
        private void openFileDialog4_FileOk_1(object sender, CancelEventArgs e)
        {
            ImageB = new Bitmap(openFileDialog4.FileName);
            pictureBox3.Image = ImageB;
        }


        // Subtract Image
        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog4.ShowDialog();
            //ImageB.Width != ImageA.Width || ImageB.Height != ImageA.Height
            /*if (ImageB.Width != ImageA.Width || ImageB.Height != ImageA.Height)
            {
                MessageBox.Show("Error: Image dimensions do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pictureBox1.Image.Dispose();
                pictureBox2.Image.Dispose();
                pictureBox3.Image.Dispose();
                return;

            }*/
                ImageB = new Bitmap(openFileDialog1.FileName);
                ImageA = new Bitmap(openFileDialog4.FileName);

            Color mygreen = Color.FromArgb(0, 0, 255);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;

            Bitmap resultImage = new Bitmap(ImageB.Width, ImageB.Height);
            for (int i = 0; i < ImageB.Width; i++)
            {
                for (int j = 0; j < ImageB.Height; j++)
                {
                    Color pixel = ImageB.GetPixel(i, j);
                    Color backpixel = ImageA.GetPixel(i, j);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractvalue = Math.Abs(grey - greygreen);
                    if (subtractvalue < threshold)
                    {
                        resultImage.SetPixel(i, j, backpixel);
                    }
                    else
                    {
                        resultImage.SetPixel(i, j, pixel);
                    }
                }
                pictureBox2.Image = resultImage;
            }
        }

        private void cameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void Camera_CheckedChanged(object sender, EventArgs e)
        {
            if(Camera.Checked == true)
            {
                webcam.ShowWindow(pictureBox1);
            }
            else
            {
                webcam.Stop();
            }
        }
        
        private void CaptureTimer_Tick(object sender, EventArgs e)
        {
            webcam.ShowWindow(pictureBox1);
            
        }


        // Camera Subtract
        private void subtractToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        //Camera Subtract on
        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            captureTimer = new Timer();
            captureTimer.Interval = 10; 
            captureTimer.Tick += SubtractTimer_Tick;
            captureTimer.Start();
        }
        private void SubtractTimer_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            System.Drawing.Image bmap;
            devices[0].Sendmessage();
            data = Clipboard.GetDataObject();

            int threshold = 100;
            if (data != null)
            {
                bmap = (System.Drawing.Image)(data.GetData("System.Drawing.Bitmap", true));
                if (bmap != null)
                {
                    Bitmap b = new Bitmap(bmap);
                    ImageProcess2.BitmapFilter.Subtract(b, ImageB, Color.Green, threshold);
                    pictureBox2.Image = b;
                }
            }
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            captureTimer.Enabled = false;
            captureTimer.Interval = 10;
            captureTimer.Tick += Copy_tick;
            captureTimer.Start();
        }

        private void cameraSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // Load Camera Background
        private void loadCameraBackgrounToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog4.ShowDialog();
        }

        // Camera Copy
        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            captureTimer.Enabled = false;
            captureTimer = new Timer();
            captureTimer.Interval = 10;
            captureTimer.Tick += Copy_tick;
            captureTimer.Start();
        }
        private void Copy_tick(object sender, EventArgs e)
        {
            IDataObject data;
            System.Drawing.Image bmap;
            devices[0].Sendmessage();
            data = Clipboard.GetDataObject();

            int threshold = 100;
            if (data != null)
            {
                bmap = (System.Drawing.Image)(data.GetData("System.Drawing.Bitmap", true));
                if (bmap != null)
                {
                    Bitmap b = new Bitmap(bmap);
                    ImageProcess.copyImage(ref b, ref ImageB);
                    pictureBox2.Image = b;
                }
            }
        }

        // Camera Inversion
        private void invertionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            captureTimer.Enabled = false;
            captureTimer = new Timer();
            captureTimer.Interval = 10;
            captureTimer.Tick += Invertion_tick;
            captureTimer.Start();
        }
        private void Invertion_tick(object sender, EventArgs e)
        {
            IDataObject data;
            System.Drawing.Image bmap;
            devices[0].Sendmessage();
            data = Clipboard.GetDataObject();

            int threshold = 100;
            if (data != null)
            {
                bmap = (System.Drawing.Image)(data.GetData("System.Drawing.Bitmap", true));
                if (bmap != null)
                {
                    Bitmap b = new Bitmap(bmap);
                    ImageProcess2.BitmapFilter.Invert(b);
                    pictureBox2.Image = b;
                }
            }
        }
        // Camera GreyScale
        private void greyScaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            captureTimer.Enabled = false;
            captureTimer = new Timer();
            captureTimer.Interval = 10;
            captureTimer.Tick += GreyScale_tick;
            captureTimer.Start();

        }
        private void GreyScale_tick(object sender, EventArgs e)
        {
            IDataObject data;
            System.Drawing.Image bmap;
            devices[0].Sendmessage();
            data = Clipboard.GetDataObject();

            int threshold = 100;
            if (data != null)
            {
                bmap = (System.Drawing.Image)(data.GetData("System.Drawing.Bitmap", true));
                if (bmap != null)
                {
                    Bitmap b = new Bitmap(bmap);
                    ImageProcess2.BitmapFilter.GrayScale(b);
                    pictureBox2.Image = b;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
