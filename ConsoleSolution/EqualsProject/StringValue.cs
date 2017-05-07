using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsProject
{
  /// <summary>
  /// Класс "StringValue"
  /// </summary>
  class StringValue
  {
    /// <summary>
    /// Значение.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="value">Параметр для инициализации значения.</param>
    public StringValue(string value)
    {
      this.Value = value;
    }

    /// <summary>
    /// Переопределенный метод System.Object.Equals().
    /// </summary>
    /// <param name="obj">Объект, с которым необходимо сравнить.</param>
    /// <returns></returns>
    public override bool Equals(object obj)
    {
      if (obj.GetType() != this.GetType())
      {
        return false;
      }

      var other = (StringValue) obj;
      return this.Value == other.Value;
    }

    /// <summary>
    /// Перегруженный оператор ==.
    /// </summary>
    /// <param name="v1">Первый операнд.</param>
    /// <param name="v2">Второй операнд.</param>
    /// <returns>Результат сравнения типа bool.</returns>
    public static bool operator ==(StringValue v1, StringValue v2)
    {
      return v1.Value == v2.Value;
    }

    /// <summary>
    /// Перегруженный оператор !=.
    /// </summary>
    /// <param name="v1">Первый операнд.</param>
    /// <param name="v2">Второй операнд.</param>
    /// <returns>Результат сравнения типа bool.</returns>
    public static bool operator !=(StringValue v1, StringValue v2)
    {
      return v1.Value != v2.Value;
    }
  }
}
