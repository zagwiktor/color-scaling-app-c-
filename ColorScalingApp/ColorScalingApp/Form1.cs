using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ColorScalingApp
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        private Bitmap modifiedImage;
        ColorScalingDLL.Class1 colorScalingDLL = new ColorScalingDLL.Class1();
        public Form1()
        {
            InitializeComponent();
            currNumOfThreads.Text = Environment.ProcessorCount.ToString();
        }
        private void setModifiedImage()
        {
            if (originalImage != null)
            {
                if (asmRButton.Checked)
                {
                    modifiedImage = colorScalingDLL.ColorsAsm(originalImage, trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value, numOfThreds());
                    modifiedImageBox.SizeMode = PictureBoxSizeMode.Zoom;
                    modifiedImageBox.Image = new Bitmap(modifiedImage);
                }
                if (cRButton.Checked) 
                {
                    modifiedImage = colorScalingDLL.AdjustColors(originalImage, trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value, numOfThreds());
                    modifiedImageBox.SizeMode = PictureBoxSizeMode.Zoom;
                    modifiedImageBox.Image = new Bitmap(modifiedImage);
                }
                
            }
        }

        /// <summary>
        /// Function responsible for loading a photo into the application.
        /// </summary>
        private void loadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png; *.jpg; *.bmp)|*.png;*.jpg;*.bmp|All files (*.*)|*.*";
            openFileDialog.Title = "Please select image";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    originalImage = new Bitmap(openFileDialog.FileName);
                    oryginalImageField.SizeMode = PictureBoxSizeMode.Zoom;
                    oryginalImageField.Image = originalImage;
                    modifiedImage = new Bitmap(originalImage);
                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Function responsible for clearing images.
        /// </summary>
        private void clearImageButton_Click(object sender, EventArgs e)
        {
            oryginalImageField.Image = null;
            modifiedImageBox.Image = null;
            originalImage = null;
            modifiedImage = null;
        }


        /// <summary>
        /// Function responsible for saving a photo into the application.
        /// </summary>
        private void scaleRgbButton_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            setModifiedImage();
            watch.Stop();
            MessageBox.Show("threads: " + numOfThreds() + ", time elapsed: " + watch.ElapsedMilliseconds + "ms", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Function checking how many threads have been selected.
        /// </summary>
        private void saveButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saveFileDialog = new FolderBrowserDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (modifiedImage != null) 
                {
                    try
                    {
                        string fileName = $"modified_image_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                        string filePath = Path.Combine(saveFileDialog.SelectedPath, fileName);
                        modifiedImage.Save(filePath, ImageFormat.Png);
                        MessageBox.Show("Modified image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while saving the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No modified image to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Function checking how many threads have been selected.
        /// </summary>
        /// <returns>Numbers of threads.</returns>
        private int numOfThreds() 
        {
            if (thred1.Checked == true) 
            {
                return 1;
            }
            if (thred2.Checked == true)
            {
                return 2;
            }
            if (thred4.Checked == true)
            {
                return 4;
            }
            if (thred8.Checked == true)
            {
                return 8;
            }
            if (thred16.Checked == true)
            {
                return 16;
            }
            if (thred32.Checked == true)
            {
                return 32;
            }
            if (thred64.Checked == true)
            {
                return 64;
            }
            if (sliderThread.Checked == true)
            {
                return trackBar1.Value;
            }

            int processorCount = Environment.ProcessorCount;
            return processorCount;
        }

        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (sliderThread.Checked == true)
            {
                currNumOfThreads.Text = trackBar1.Value.ToString();
            }
        }

        private void defNumOfThreads_CheckedChanged(object sender, EventArgs e)
        {
            currNumOfThreads.Text = Environment.ProcessorCount.ToString();
        }

        private void thred1_CheckedChanged(object sender, EventArgs e)
        {
            currNumOfThreads.Text = 1.ToString();
        }

        private void thred2_CheckedChanged(object sender, EventArgs e)
        {
            currNumOfThreads.Text = 2.ToString();
        }

        private void thred4_CheckedChanged(object sender, EventArgs e)
        {
            currNumOfThreads.Text = 4.ToString();
        }

        private void thred8_CheckedChanged(object sender, EventArgs e)
        {
            currNumOfThreads.Text = 8.ToString();
        }

        private void thred16_CheckedChanged(object sender, EventArgs e)
        {
            currNumOfThreads.Text = 16.ToString();
        }

        private void thred32_CheckedChanged(object sender, EventArgs e)
        {
            currNumOfThreads.Text = 32.ToString();
        }

        private void thred64_CheckedChanged(object sender, EventArgs e)
        {
            currNumOfThreads.Text = 64.ToString();
        }

        private void sliderThread_CheckedChanged(object sender, EventArgs e)
        {
            currNumOfThreads.Text = trackBar1.Value.ToString();
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            float redFactor = (float)Math.Round((1.0f + trackBarRed.Value / 100.0f), 2);
            valueOfRed.Text = redFactor.ToString();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            float greenFactor = (float)Math.Round((1.0f + trackBarGreen.Value / 100.0f), 2);
            valueOfGreen.Text = greenFactor.ToString();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            float blueFactor = (float)Math.Round((1.0f + trackBarBlue.Value / 100.0f), 2);

            valueOfBlue.Text = blueFactor.ToString();
        }
    }
}
