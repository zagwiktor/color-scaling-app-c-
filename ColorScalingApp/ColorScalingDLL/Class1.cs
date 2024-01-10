using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace ColorScalingDLL
{
    public class Class1
    {
       
        public Bitmap AdjustColors(Bitmap originalImage, int trackBarRed, int trackBarGreen, int trackBarBlue, int numOfThreads)
        {
           
            int defaultRedValue = 0;
            int defaultGreenValue = 0;
            int defaultBlueValue = 0;
            if (trackBarRed == defaultRedValue && trackBarGreen == defaultGreenValue && trackBarBlue == defaultBlueValue)
            {
                return new Bitmap(originalImage);
            }

            Bitmap modifiedImage = new Bitmap(originalImage);

            float redFactor = 1.0f + trackBarRed / 100.0f;
            float greenFactor = 1.0f + trackBarGreen / 100.0f;
            float blueFactor = 1.0f + trackBarBlue / 100.0f;

            Rectangle rect = new Rectangle(0, 0, originalImage.Width, originalImage.Height);
            BitmapData originalData = originalImage.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData modifiedData = modifiedImage.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            int bytesPerPixel = 4;
            int height = rect.Height;
            int width = rect.Width;
            int stride = originalData.Stride;

            byte[] originalPixels = new byte[stride * height];
            byte[] modifiedPixels = new byte[stride * height];

            Marshal.Copy(originalData.Scan0, originalPixels, 0, originalPixels.Length);

            Parallel.For(0, height, new ParallelOptions { MaxDegreeOfParallelism = numOfThreads }, y =>
            {
                for (int x = 0; x < width; x++)
                {
                    int index = y * stride + x * bytesPerPixel;

                    int newRed = (int)(originalPixels[index + 2] * redFactor);
                    int newGreen = (int)(originalPixels[index + 1] * greenFactor);
                    int newBlue = (int)(originalPixels[index] * blueFactor);

                    newRed = Math.Max(0, Math.Min(255, newRed));
                    newGreen = Math.Max(0, Math.Min(255, newGreen));
                    newBlue = Math.Max(0, Math.Min(255, newBlue));

                    modifiedPixels[index + 2] = (byte)newRed;
                    modifiedPixels[index + 1] = (byte)newGreen;
                    modifiedPixels[index] = (byte)newBlue;
                    modifiedPixels[index + 3] = 255;
                }
            });

            Marshal.Copy(modifiedPixels, 0, modifiedData.Scan0, modifiedPixels.Length);

            originalImage.UnlockBits(originalData);
            modifiedImage.UnlockBits(modifiedData);

            return modifiedImage;
        }
    }
}
