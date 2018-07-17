using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DDU
{
    public static class Extensions
    {
        public static readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" };

        public static bool IsImage(this FileInfo file)
        {
            return ImageExtensions.Contains(file.Extension.ToUpperInvariant());
        }

        public static Bitmap TrimImage(this Bitmap img)
        {
            //get image data
            var bd = img.LockBits(new Rectangle(Point.Empty, img.Size), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            var rgbValues = new int[img.Height * img.Width];
            Marshal.Copy(bd.Scan0, rgbValues, 0, rgbValues.Length);
            img.UnlockBits(bd);

            #region determine bounds
            var left = bd.Width;
            var top = bd.Height;
            var right = 0;
            var bottom = 0;

            //determine top
            for (var i = 0; i < rgbValues.Length; i++)
            {
                var color = rgbValues[i] & 0xffffff;
                if (color == 0xffffff) 
                    continue;

                var r = i / bd.Width;
                var c = i % bd.Width;

                if (left > c)
                {
                    left = c;
                }

                if (right < c)
                {
                    right = c;
                }

                bottom = r;
                top = r;
                break;
            }

            //determine bottom
            for (var i = rgbValues.Length - 1; i >= 0; i--)
            {
                var color = rgbValues[i] & 0xffffff;
                if (color == 0xffffff) 
                    continue;

                var r = i / bd.Width;
                var c = i % bd.Width;

                if (left > c)
                {
                    left = c;
                }

                if (right < c)
                {
                    right = c;
                }

                bottom = r;
                break;
            }

            if (bottom > top)
            {
                for (var r = top + 1; r < bottom; r++)
                {
                    //determine left
                    for (var c = 0; c < left; c++)
                    {
                        var color = rgbValues[r * bd.Width + c] & 0xffffff;
                        if (color == 0xffffff) 
                            continue;

                        if (left <= c) 
                            continue;

                        left = c;
                        break;
                    }

                    //determine right
                    for (var c = bd.Width - 1; c > right; c--)
                    {
                        var color = rgbValues[r * bd.Width + c] & 0xffffff;
                        if (color == 0xffffff) 
                            continue;

                        if (right >= c) 
                            continue;

                        right = c;
                        break;
                    }
                }
            }

            var width = right - left + 1;
            var height = bottom - top + 1;
            #endregion

            //copy image data
            var imgData = new int[width * height];
            for (var r = top; r <= bottom; r++)
            {
                Array.Copy(rgbValues, r * bd.Width + left, imgData, (r - top) * width, width);
            }

            //create new image
            var newImage = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            var nbd = newImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(imgData, 0, nbd.Scan0, imgData.Length);
            newImage.UnlockBits(nbd);

            return newImage;
        }
    }
}
