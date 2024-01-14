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

        private void clearImageButton_Click(object sender, EventArgs e)
        {
            oryginalImageField.Image = null;
            modifiedImageBox.Image = null;
            originalImage = null;
            modifiedImage = null;
        }

        private void scaleRgbButton_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            setModifiedImage();
            watch.Stop();
            MessageBox.Show("threads: " + numOfThreds() + ", time elapsed: " + watch.ElapsedMilliseconds + "ms", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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
            int processorCount = Environment.ProcessorCount;
            return processorCount;
        }

   
    }
}
