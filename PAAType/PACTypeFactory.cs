// Decompiled with JetBrains decompiler
// Type: PAAType.PACTypeFactory
// Assembly: PAAType, Version=1.2.7656.845, Culture=ru-RU, PublicKeyToken=null
// MVID: 9564CC68-8D16-446C-9581-EF04FFB56AB6
// Assembly location: C:\Users\ECHO\Desktop\PAAType.dll

using PaintDotNet;

namespace PAAType
{
  public class PACTypeFactory : IFileTypeFactory
  {
    public FileType[] GetFileTypeInstances() => new FileType[1]
    {
      (FileType) new PACType()
    };
  }
}
