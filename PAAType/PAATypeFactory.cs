using PaintDotNet;

namespace PAAType
{
  public class PAATypeFactory : IFileTypeFactory
  {
    public FileType[] GetFileTypeInstances() => new FileType[1]
    {
      (FileType) new PAAType()
    };
  }
}
