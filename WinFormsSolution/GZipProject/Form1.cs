using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
      using (var sourceStream = new System.IO.FileStream("GZipFileExample.gz", 
        System.IO.FileMode.Open, System.IO.FileAccess.Read,
        System.IO.FileShare.Read))

      using (var uncompressedStream = new System.IO.Compression.GZipStream(
        sourceStream, System.IO.Compression.CompressionMode.Decompress, true))

      using (var textReader = new System.IO.StreamReader(uncompressedStream, true))
        richTextBox1.Text = textReader.ReadToEnd();
    }
  }
}
