// Decompiled with JetBrains decompiler
// Type: PAAType.PACType
// Assembly: PAAType, Version=1.2.7656.845, Culture=ru-RU, PublicKeyToken=null
// MVID: 9564CC68-8D16-446C-9581-EF04FFB56AB6
// Assembly location: C:\Users\ECHO\Desktop\PAAType.dll

using PaintDotNet;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace PAAType
{
  public class PACType : FileType
  {
    private bool isPac = true;

    public PACType()
      : base("PAC ARMA Textures", new FileTypeOptions()
      {
        LoadExtensions = (IReadOnlyList<string>) new string[1]
        {
          ".pac"
        }
      })
    {
    }

    protected override Document OnLoad(Stream input) => Document.FromImage((Image) new PACFile(input, true).GetBitmap());
  }
}
