using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace ColorScalingDLL
{
    public class Class1
    {
        [DllImport(@"C:\Users\zagwi\OneDrive\Pulpit\SZKOLA\Semestr 5\JA\Projekt\ColorScalingApp\x64\Debug\AsmDLL.dll")]
        static extern int MyProc1(byte[] pixelsdouble, double redFactor, double greenFactor, double blueFactor, int y, int x, int stride);


        public Bitmap AdjustColors(Bitmap originalImage, int trackBarRed, int trackBarGreen, int trackBarBlue, int numOfThreads)
        {

            if (trackBarRed == 0 && trackBarGreen == 0 && trackBarBlue == 0)
            {
                return new Bitmap(originalImage); 
            }

            Bitmap modifiedImage = new Bitmap(originalImage);
            float redFactor = 1.0f + trackBarRed / 100.0f;
            float greenFactor = 1.0f + trackBarGreen / 100.0f;
            float blueFactor = 1.0f + trackBarBlue / 100.0f;

            Rectangle rect = new Rectangle(0, 0, modifiedImage.Width, modifiedImage.Height);
            BitmapData modifiedData = modifiedImage.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            int bytesPerPixel = 4;
            int stride = modifiedData.Stride;
            byte[] pixels = new byte[stride * rect.Height];

            Marshal.Copy(modifiedData.Scan0, pixels, 0, pixels.Length);

            Parallel.For(0, rect.Height, new ParallelOptions { MaxDegreeOfParallelism = numOfThreads }, y =>
            {
                for (int x = 0; x < rect.Width; x++)
                {
                    int index = y * stride + x * bytesPerPixel;
                    int newRed = (int)(pixels[index + 2] * redFactor);
                    int newGreen = (int)(pixels[index + 1] * greenFactor);
                    int newBlue = (int)(pixels[index] * blueFactor);

                    pixels[index + 2] = (byte)Math.Max(0, Math.Min(255, newRed));
                    pixels[index + 1] = (byte)Math.Max(0, Math.Min(255, newGreen));
                    pixels[index] = (byte)Math.Max(0, Math.Min(255, newBlue));
                    
                }
            });

            Marshal.Copy(pixels, 0, modifiedData.Scan0, pixels.Length);
            modifiedImage.UnlockBits(modifiedData);

            return modifiedImage;
        }


        public Bitmap ColorsAsm(Bitmap originalImage, int trackBarRed, int trackBarGreen, int trackBarBlue, int numOfThreads)
        {
            if (trackBarRed == 0 && trackBarGreen == 0 && trackBarBlue == 0)
            {
                return new Bitmap(originalImage); 
            }

            Bitmap modifiedImage = new Bitmap(originalImage);
            double redFactor = 1.0f + trackBarRed / 100.0f;
            double greenFactor = 1.0f + trackBarGreen / 100.0f;
            double blueFactor = 1.0f + trackBarBlue / 100.0f;

            Rectangle rect = new Rectangle(0, 0, modifiedImage.Width, modifiedImage.Height);
            BitmapData modifiedData = modifiedImage.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            int bytesPerPixel = 4;
            int stride = modifiedData.Stride;
            byte[] pixels = new byte[stride * rect.Height];

            Marshal.Copy(modifiedData.Scan0, pixels, 0, pixels.Length);


            Parallel.For(0, rect.Height, new ParallelOptions { MaxDegreeOfParallelism = numOfThreads }, y =>
            {
                for (int x = 0; x < rect.Width; x++) 
                {
                    
                    int index = y * stride + x * bytesPerPixel;
                    MyProc1(pixels, redFactor, greenFactor, blueFactor, y, x, stride);
                }
            });


            Marshal.Copy(pixels, 0, modifiedData.Scan0, pixels.Length);
            modifiedImage.UnlockBits(modifiedData);

            return modifiedImage;
        }

     
    }
}

    
