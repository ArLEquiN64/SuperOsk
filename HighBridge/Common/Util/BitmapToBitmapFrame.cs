﻿using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;

namespace HighBridge.Common.Util
{
    internal class BitmapToBitmapFrame
    {
        internal static BitmapFrame Convert(Bitmap src)
        {
            
            using (var stream = new MemoryStream())
            {
                src.Save(stream, ImageFormat.Bmp);
                return BitmapFrame.Create(stream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
            }
        }
    }

}
