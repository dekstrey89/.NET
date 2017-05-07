using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumberProject
{
  internal class Complex : IComparable
  {
    public int Re { get; set; }
    public int Im { get; set; }

    public int CompareTo(object obj)
    {
      if (obj == null) return 1;

      var other = obj as Complex;

      if (other != null)
      {
        return CalculateModulus(this).CompareTo(CalculateModulus(other));
      }
      else
      {
        throw new ArgumentException("Object is not a Complex");
      }
    }

    public double CalculateModulus(Complex c)
    {
      return Math.Sqrt(Math.Pow(c.Re, 2) + Math.Pow(c.Im, 2));
    }
  }
}
