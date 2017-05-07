using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsProject
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(new StringValue("AAA").Equals(new StringValue("AAA")));

      Console.ReadKey();
    }
  }
}
