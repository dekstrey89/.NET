using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GZipProject
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      CreateGZipFile();

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());
    }

    public static void CreateGZipFile()
    {
      const string text = "When the going gets tough, the tough get going.\n" +
                          "Fortune favors the bold.\n" +
                          "People who live in glass houses should not throw stones.\n" +
                          "Hope for the best, but prepare for the worst.\n" +
                          "Better late than never.\n" +
                          "Discretion is the greater part of valour.\n";

      using (var fileToCompress = new FileStream("GZipFileExample.txt", FileMode.Create))
      {
        using (var fileWriter = new StreamWriter(fileToCompress))
        {
          fileWriter.Write(text);
        }
      }

      using (var compressedFileStream = File.Create("GZipFileExample.gz"))
      {
        using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
        {
          using (var fileToCompress = new FileStream("GZipFileExample.txt", FileMode.Open))
          {
            fileToCompress.CopyTo(compressionStream);
          }
        }
      }
    }
  }
}
