using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxGenericProject
{
  class Program
  {
    private static void Main(string[] args)
    {
      var x = 10;
      var y = 5;
      var z = 25;
      PrintMaximum(x, y, z);

      var  date1 = DateTime.Now;
      var date2 = DateTime.Now.AddDays(5);
      var date3 = DateTime.Now.AddDays(1);
      PrintMaximum(date1, date2, date3);

      Console.ReadKey();
    }

    private static void PrintMaximum<T>(T x, T y, T z)
      where T : IComparable<T>
    {
      var max = x;

      if (y.CompareTo(max) > 0)
      {
        max = y;
      }

      if (z.CompareTo(max) > 0)
      {
        max = z;
      }

      Console.WriteLine("Maximum in set{{ {0}, {1}, {2} }} is {3}\n", x, y, z, max);
    }
  }
}
