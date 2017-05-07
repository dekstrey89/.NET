using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumberProject
{
  /// <summary>
  /// Класс "Complex".
  /// </summary>
  internal class Complex : IComparable
  {
    /// <summary>
    /// Действительная часть числа.
    /// </summary>
    public int Re { get; set; }

    /// <summary>
    /// Мнимая часть числа.
    /// </summary>
    public int Im { get; set; }

    /// <summary>
    /// Реализация IComparable.
    /// </summary>
    /// <param name="obj">Объект для сравнения.</param>
    /// <returns></returns>
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

    /// <summary>
    /// Вычислить модуль комплексного числа.
    /// </summary>
    /// <param name="c">Комплексное число.</param>
    /// <returns></returns>
    public double CalculateModulus(Complex c)
    {
      return Math.Sqrt(Math.Pow(c.Re, 2) + Math.Pow(c.Im, 2));
    }
  }
}
