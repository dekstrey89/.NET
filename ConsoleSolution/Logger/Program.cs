using System;
using System.IO;
using System.Net.Mime;

namespace GCLogger
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      using (var logger = new Logger("temp.txt"))
      {
        Console.WriteLine(@"Создан ресурс: {0}\temp.txt", Directory.GetCurrentDirectory());
        logger.WriteString("Tru");
        logger.WriteString("-la");
        logger.WriteString("-la");
        Console.WriteLine("Удостоверьтесь, что ресурс занят и нажмите любую клавишу...");
        Console.ReadKey();
      }

      Console.WriteLine("Удостоверьтесь, что ресурс свободен и нажмите любую клавишу...");
      Console.ReadKey();
    }
  }
}
