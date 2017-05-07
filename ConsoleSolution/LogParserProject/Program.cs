using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogParserProject
{
  class Program
  {
    static void Main(string[] args)
    {
      CreateLogFile();

      Console.ReadKey();
    }

    static void CreateLogFile()
    {
      FileStream logFile = null;
      StreamWriter logWriter = null;

      try
      {
        logFile = new FileStream("log.txt", FileMode.Append);
        logWriter = new StreamWriter(logFile);
        logWriter.WriteLine("{0}\t{1}", DateTime.Now, "Some information");
        logWriter.WriteLine("{0}\t{1}", DateTime.Now.AddMinutes(1), "Some information");
        logWriter.WriteLine("{0}\t{1}", DateTime.Now.AddHours(1), "Some information");
        logWriter.WriteLine("{0}\t{1}", DateTime.Now.AddDays(1), "Some information");
      }
      catch (Exception e)
      {
        throw new Exception("В процессе формирования лог-файла произошла ошибка", e);
      }
      finally
      {
        logWriter?.Close();
        logFile?.Close();
      }
    }
  }
}
