﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace PAAType
{
  internal class PAAFile : IDisposable
  {
    private bool isPAC = false;
    private Bitmap bmp;
    private int Width = 1024;
    private int Height = 1024;

    public PAAFile(Stream input)
    {
      BIS.PAA.PAA paa = new BIS.PAA.PAA(input, this.isPAC);
      this.Width = paa.Width;
      this.Height = paa.Height;
      this.bmp = new Bitmap(this.Width, this.Height);
      byte[] argB32PixelData = BIS.PAA.PAA.GetARGB32PixelData(paa, input);
      BitmapData bitmapdata = this.bmp.LockBits(new Rectangle(0, 0, this.Width, this.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
      Marshal.Copy(argB32PixelData, 0, bitmapdata.Scan0, argB32PixelData.Length);
      this.bmp.UnlockBits(bitmapdata);
    }

    public Bitmap GetBitmap() => this.bmp != null ? this.bmp : throw new Exception("Failed to load texture!");

    public void Dispose() => this.bmp = (Bitmap) null;
  }
}
