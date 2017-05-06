using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingForLogging
{
  class Program
  {
    static void PrintFormatDateTime()
    {
      var date = new DateTime(2000, 12, 31, 13, 59, 00);

      Console.WriteLine("Стандартное форматирование: {0}\n", date);

      Console.WriteLine("Форматирование в ToString(): {0}\n", date.ToString("MM/dd/yyyy"));

      Console.WriteLine("Форматирование в string.Format: {0:MM-dd-yyyy}\n", date);

      Console.WriteLine("С использованием германской культуры: {0}\n", 
        date.ToString("MM/dd/yyyy", CultureInfo.CreateSpecificCulture("el-GR")));

      Console.WriteLine("А также с указанием эры (описатель gg): {0:MM/dd/yyyy g}\n", date);

      Console.WriteLine("12-часовой формат: {0}\n", 
        date.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture));
    }

    static void PrintFormatRealNumbers()
    {
      double value = 1.2;

      Console.WriteLine("---- Описатель 0 ----");

      Console.WriteLine(value.ToString("0.00", CultureInfo.InvariantCulture));
      Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0.00}\n", value));

      CultureInfo daDK = CultureInfo.CreateSpecificCulture("da-DK");
      Console.WriteLine(String.Format(daDK, "{0:00.00}\n", value));

      value = .56;
      Console.WriteLine(value.ToString("0.0", CultureInfo.InvariantCulture));
      Console.WriteLine(value.ToString("0.00\n", CultureInfo.InvariantCulture)); 

      value = 1234.567890;
      Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}\n", value));

      Console.WriteLine("---- Описатель # ----");
      value = 1.2;
      Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:#.##}\n", value));

      value = 123;
      Console.WriteLine(String.Format("{0:#####}\n", value));

      value = 123456;
      Console.WriteLine(String.Format("{0:[##-##-##]}\n", value));

      value = 1234567890;
      Console.WriteLine(String.Format("{0:#}\n", value));

      Console.WriteLine(String.Format("{0:(###) ###-####}\n", value));

    }

    static void Main(string[] args)
    {
      PrintFormatDateTime();
      PrintFormatRealNumbers();

      Console.ReadKey();
    }
  }
}
