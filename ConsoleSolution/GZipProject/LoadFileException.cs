using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZipProject
{
  /// <summary>
  /// Класс "LoadFileException"
  /// </summary>
  internal class LoadFileException : Exception
  {
    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="message">Сообщение.</param>
    /// <param name="innerException">Вложенное сообщение.</param>
    public LoadFileException(string message, Exception innerException)
      : base(message, innerException)
    {
    }
  }
}
