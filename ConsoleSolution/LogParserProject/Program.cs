using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogParserProject
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      // Написать функцию, на вход которой подаются лог-файл и интервал дат, 
      // а на выходе у нее – количество записей за указный интервал.

      using (var logFile = new FileStream("log.txt", FileMode.Create))
      {
        CreateLogFile(logFile);
      }

      //using (var logFile = new FileStream("log.txt", FileMode.Open))
      //{
      //  GetQuantityBugs(logFile, DateTime.Now.AddDays(2), DateTime.Now.AddDays(4));
      //}

      //Console.WriteLine("\n");

      // Требуется разработать метод, который будет фильтровать строки лог-файла на указанную дату и
      // сортировать их по времени.

      using (var logFile = new FileStream("log.txt", FileMode.Open))
      {
        GetQuantityBugs(logFile, DateTime.Now);
      }

      // Проверить, что получается при преобразовании экземпляров класса в строку(методом ToString).
      // Сделать выводы о том, как правильно разрабатывать классы, которые должны преобразовываться в строки.

      //var objOverrideToString = new OverrideToString();
      //var objNotOverrideToString = new NotOverrideToString();

      //Console.WriteLine("Класс objOverrideToString выводит результат " +
      //                  "переопределенного метода ToString(): {0}\n", objOverrideToString);
      //Console.WriteLine("Класс objNotOverrideToString выводит результат метода ToString() " +
      //                  "базового класса Object: {0}", objNotOverrideToString);

      Console.ReadKey();
    }

    /// <summary>
    /// Вывести количество записей в лог-файле за указанный период.
    /// </summary>
    /// <param name="fs">Лог-файл.</param>
    /// <param name="beginDate">Дата начала периода.</param>
    /// <param name="endDate">Дата конца периода.</param>
    private static void GetQuantityBugs(FileStream fs, DateTime targetDate)
    {
      using (var logReader = new StreamReader(fs))
      {
        var dates = new Dictionary<DateTime, string>();

        while (logReader.Peek() >= 0)
        {
          var str = logReader.ReadLine();
          var key = DateTime.Parse(str.Substring(0, str.IndexOf("\t", StringComparison.Ordinal)));
          var first = str.IndexOf("\t", StringComparison.Ordinal);
          var second = str.Length - first;
          var value = str.Substring(first, second);

          dates[key] = value;
        }

        var dateTimes = dates.Where(x => x.Key.Date.Equals(targetDate.Date)).OrderBy(x => x.Key);

        foreach (var dateTime in dateTimes)
        {
          Console.WriteLine("{0}: {1}", dateTime.Key, dateTime.Value);
        }
      }
    }

    /// <summary>
    /// Вывести количество записей в лог-файле за указанный период.
    /// </summary>
    /// <param name="fs">Лог-файл.</param>
    /// <param name="beginDate">Дата начала периода.</param>
    /// <param name="endDate">Дата конца периода.</param>
    private static void GetQuantityBugs(FileStream fs, DateTime beginDate, DateTime endDate)
    {
      using (var logReader = new StreamReader(fs))
      {
        var count = 0;

        while (logReader.Peek() >= 0)
        {
          var day = 0;
          var month = 0;
          var year = 0;
          var hour = 0;
          var minute = 0;
          var second = 0;
          var ok = true;

          var str = logReader.ReadLine();
          ok &= int.TryParse(str.Substring(0, 2), out day);
          ok &= int.TryParse(str.Substring(3, 2), out month);
          ok &= int.TryParse(str.Substring(6, 4), out year);
          ok &= int.TryParse(str.Substring(11, 2), out hour);
          ok &= int.TryParse(str.Substring(14, 2), out minute);
          ok &= int.TryParse(str.Substring(17, 2), out second);

          if (!ok)
            continue;

          var date = new DateTime(year, month, day, hour, minute, second);

          if (date.Ticks >= beginDate.Ticks && date.Ticks <= endDate.Ticks)
          {
            count++;
          }
        }

        Console.WriteLine("Кол-во записей за указанный интервал: {0}", count);
      }
    }

    /// <summary>
    /// Создание лог-файла.
    /// </summary>
    /// <param name="fs">Лог-файл.</param>
    private static void CreateLogFile(FileStream fs)
    {
      using (var logWriter = new StreamWriter(fs))
      {
        logWriter.WriteLine("{0}\t{1}", DateTime.Now.AddDays(3), "Some information");
        logWriter.WriteLine("{0}\t{1}", DateTime.Now.AddDays(3).AddMinutes(1), "Some information");
        logWriter.WriteLine("{0}\t{1}", DateTime.Now.AddDays(3).AddHours(1), "Some information");

        logWriter.WriteLine("{0}\t{1}", DateTime.Now, "Some information");
        logWriter.WriteLine("{0}\t{1}", DateTime.Now.AddMinutes(1), "Some information");
        logWriter.WriteLine("{0}\t{1}", DateTime.Now.AddMinutes(7), "Some information");
        logWriter.WriteLine("{0}\t{1}", DateTime.Now.AddMinutes(2), "Some information");
        logWriter.WriteLine("{0}\t{1}", DateTime.Now.AddMinutes(6), "Some information");
        logWriter.WriteLine("{0}\t{1}", DateTime.Now.AddMinutes(3), "Some information");
        logWriter.WriteLine("{0}\t{1}", DateTime.Now.AddMinutes(5), "Some information");
        logWriter.WriteLine("{0}\t{1}", DateTime.Now.AddMinutes(4), "Some information");
        logWriter.WriteLine("{0}\t{1}", DateTime.Now.AddHours(1), "Some information");

        logWriter.WriteLine("{0}\t{1}", DateTime.Now.AddDays(5), "Some information");
        logWriter.WriteLine("{0}\t{1}", DateTime.Now.AddDays(5).AddMinutes(1), "Some information");
        logWriter.WriteLine("{0}\t{1}", DateTime.Now.AddDays(5).AddHours(1), "Some information");
      }
    }
  }
}
