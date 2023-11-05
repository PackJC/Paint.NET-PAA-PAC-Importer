﻿// Decompiled with JetBrains decompiler
// Type: BIS.Core.ColorP
// Assembly: PAAType, Version=1.2.7656.845, Culture=ru-RU, PublicKeyToken=null
// MVID: 9564CC68-8D16-446C-9581-EF04FFB56AB6
// Assembly location: C:\Users\ECHO\Desktop\PAAType.dll

using BIS.Core.Streams;
using System;
using System.Globalization;

namespace BIS.Core
{
  public struct ColorP
  {
    public float Red { get; private set; }

    public float Green { get; private set; }

    public float Blue { get; private set; }

    public float Alpha { get; private set; }

    public ColorP(float r, float g, float b, float a)
    {
      this.Red = r;
      this.Green = g;
      this.Blue = b;
      this.Alpha = a;
    }

    public ColorP(BinaryReaderEx input)
    {
      this.Red = input.ReadSingle();
      this.Green = input.ReadSingle();
      this.Blue = input.ReadSingle();
      this.Alpha = input.ReadSingle();
    }

    public void Read(BinaryReaderEx input)
    {
      this.Red = input.ReadSingle();
      this.Green = input.ReadSingle();
      this.Blue = input.ReadSingle();
      this.Alpha = input.ReadSingle();
    }

    public void Write(BinaryWriterEx output)
    {
      output.Write(this.Red);
      output.Write(this.Green);
      output.Write(this.Blue);
      output.Write(this.Alpha);
    }

    public override string ToString()
    {
      CultureInfo cultureInfo = new CultureInfo("en-GB");
      return "{" + this.Red.ToString((IFormatProvider) cultureInfo.NumberFormat) + "," + this.Green.ToString((IFormatProvider) cultureInfo.NumberFormat) + "," + this.Blue.ToString((IFormatProvider) cultureInfo.NumberFormat) + "," + this.Alpha.ToString((IFormatProvider) cultureInfo.NumberFormat) + "}";
    }
  }
}
