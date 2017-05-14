using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace COMProject
{
  class Program
  {
    static void Main(string[] args)
    {
      EarlyBindingWriteTable("EarlyBindingMultiplicationTable.xlsx");
      Console.WriteLine("EarlyBindingMultiplicationTable.xlsx is successfully created.");

      LateBindingWriteTable("LateBindingMultiplicationTable.xlsx");
      Console.WriteLine("LateBindingMultiplicationTable.xlsx is successfully created.");

      Console.ReadKey();
    }

    /// <summary>
    /// Создать Excel-документ и записать в него таблицу умножения, используя раннее связывание.
    /// </summary>
    /// <param name="fileName">Имя Excel-файла.</param>
    private static void EarlyBindingWriteTable(string fileName)
    {
      var excel = new Application();

      try
      {
        excel.Workbooks.Add();

        var workSheet = (Worksheet) excel.ActiveSheet;

        for (var i = 1; i < 10; i++)
        {
          for (var j = 1; j < 10; j++)
          {
            workSheet.Cells[i, j] = (i * j);
          }
        }

        workSheet.SaveAs($"{Directory.GetCurrentDirectory()}/{fileName}");
      }
      catch (Exception ex)
      {
        Console.WriteLine("EarlyBindingWriteTable: {0}", ex.Message);
      }
      finally
      {
        excel.Quit();
      }
    }

    /// <summary>
    /// Создать Excel-документ и записать в него таблицу умножения, используя позднее связывание.
    /// </summary>
    /// <param name="fileName">Имя Excel-файла.</param>
    private static void LateBindingWriteTable(string fileName)
    {
      dynamic excel = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));

      try
      {
        excel.Workbooks.Add();

        var workSheet = (Worksheet) excel.ActiveSheet;

        for (var i = 1; i < 10; i++)
        {
          for (var j = 1; j < 10; j++)
          {
            workSheet.Cells[i, j] = (i * j);
          }
        }

        workSheet.SaveAs($"{Directory.GetCurrentDirectory()}/{fileName}");
      }
      catch (Exception ex)
      {
        Console.WriteLine("LateBindingWriteTable: {0}", ex.Message);
      }
      finally
      {
        excel.Quit();
      }
    }
  }
}
