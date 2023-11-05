using PaintDotNet;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace PAAType
{
  public class PAAType : FileType
  {
    public PAAType()
      : base("ArmA/DayZ .PAA", new FileTypeOptions()
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
