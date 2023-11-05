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
