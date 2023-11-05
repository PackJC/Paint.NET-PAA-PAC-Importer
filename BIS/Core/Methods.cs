// Decompiled with JetBrains decompiler
// Type: BIS.Core.Methods
// Assembly: PAAType, Version=1.2.7656.845, Culture=ru-RU, PublicKeyToken=null
// MVID: 9564CC68-8D16-446C-9581-EF04FFB56AB6
// Assembly location: C:\Users\ECHO\Desktop\PAAType.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace BIS.Core
{
  public static class Methods
  {
    public static void Swap<T>(ref T v1, ref T v2)
    {
      T obj = v1;
      v1 = v2;
      v2 = obj;
    }

    public static bool EqualsFloat(float f1, float f2, float tolerance = 0.0001f) => (double)System.Math.Abs(f1 - f2) <= (double) tolerance;

    public static IEnumerable<T> Yield<T>(this T src)
    {
      yield return src;
    }

    public static IEnumerable<T> Yield<T>(params T[] elems) => (IEnumerable<T>) elems;

    public static string CharsToString(this IEnumerable<char> chars) => new string(chars.ToArray<char>());
  }
}
