// Decompiled with JetBrains decompiler
// Type: PAAType.PAAType
// Assembly: PAAType, Version=1.2.7656.845, Culture=ru-RU, PublicKeyToken=null
// MVID: 9564CC68-8D16-446C-9581-EF04FFB56AB6
// Assembly location: C:\Users\ECHO\Desktop\PAAType.dll

using PaintDotNet;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace PAAType
{
  public class PAAType : FileType
  {
    public PAAType()
      : base("Arma images PAA", new FileTypeOptions()
      {
        LoadExtensions = (IReadOnlyList<string>) new string[1]
        {
          ".paa"
        }
      })
    {
    }

    protected override Document OnLoad(Stream input) => Document.FromImage((Image) new PAAFile(input).GetBitmap());
    
  }
}
