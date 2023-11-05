// Decompiled with JetBrains decompiler
// Type: PAAType.PACFile
// Assembly: PAAType, Version=1.2.7656.845, Culture=ru-RU, PublicKeyToken=null
// MVID: 9564CC68-8D16-446C-9581-EF04FFB56AB6
// Assembly location: C:\Users\ECHO\Desktop\PAAType.dll

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace PAAType
{
  internal class PACFile : IDisposable
  {
    private Bitmap bmp;
    private int Width = 1024;
    private int Height = 1024;

    public PACFile(Stream input, bool isPAC)
    {
      BIS.PAA.PAA paa = new BIS.PAA.PAA(input, isPAC);
      this.Width = paa.Width;
      this.Height = paa.Height;
      byte[] argB32PixelData = BIS.PAA.PAA.GetARGB32PixelData(paa, input);
      BitmapData bitmapdata = this.bmp.LockBits(new Rectangle(0, 0, this.Width, this.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
      Marshal.Copy(argB32PixelData, 0, bitmapdata.Scan0, argB32PixelData.Length);
      this.bmp.UnlockBits(bitmapdata);
    }

    public Bitmap GetBitmap() => this.bmp != null ? this.bmp : throw new OperationCanceledException("Failed to load texture!");

    public void Dispose() => this.bmp = (Bitmap) null;
  }
}
