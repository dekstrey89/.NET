using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GZipProject
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void DownloadBtn_Click(object sender, EventArgs e)
    {
      FileStream sourceStream = null;
      GZipStream uncompressedStream = null;
      StreamReader textReader = null;

      try
      {
        sourceStream = new FileStream("GZipFileExample.gz", System.IO.FileMode.Open,
          FileAccess.Read, FileShare.Read);

        uncompressedStream = new GZipStream(sourceStream, CompressionMode.Decompress, true);
                                                          
        textReader = new StreamReader(uncompressedStream, true);
        richTextBox1.Text = textReader.ReadToEnd();
      }
      catch (FileNotFoundException exception)
      {
        throw new LoadFileException("Произошла ошибка при загрузке файла:\n", exception);
      }
      catch (UnauthorizedAccessException exception)
      {
        throw new LoadFileException("Произошла ошибка при загрузке файла:\n", exception);
      }
      finally
      {
        sourceStream?.Close();
        uncompressedStream?.Close();
        textReader?.Close();
      }
    }
  }
}
