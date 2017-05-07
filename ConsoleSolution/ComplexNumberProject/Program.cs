using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumberProject
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var TwoComplexes = new List<Complex>() { new Complex() { Re = 3, Im = 5 },
        new Complex() { Re = 4, Im = 4 },
        new Complex() { Re = 6, Im = 2 },
        new Complex() { Re = 2, Im = 2 },
        new Complex() { Re = 4, Im = 2 }};

      Console.WriteLine("Исходная коллекция комплексных чисел:");
      PrintList(TwoComplexes);

      TwoComplexes.Sort();

      Console.WriteLine("\nСортированная коллекция комплексных чисел:");
      PrintList(TwoComplexes);

      Console.ReadKey();
    }

    private static void PrintList(List<Complex> list)
    {
      foreach (var complex in list)
      {
        Console.WriteLine("Complex Re = {0}, Im = {1}, modulus = {2:##.00}", 
          complex.Re, complex.Im, complex.CalculateModulus(complex));
      }
    }
  }
}
