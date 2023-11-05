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
      : base("ArmA/DayZ .PAC", new FileTypeOptions()
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
