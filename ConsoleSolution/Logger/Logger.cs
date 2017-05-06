using System;
using System.IO;

namespace GCLogger
{
  /// <summary>
  /// Класс "Логгер".
  /// </summary>
  public class Logger : IDisposable
  {
    /// <summary>
    /// Признак выполненного освобождения ресурсов.
    /// </summary>
    private bool _disposed;

    /// <summary>
    /// Файл логов.
    /// </summary>
    private readonly FileStream _logFile;

    /// <summary>
    /// Писатель в лог.
    /// </summary>
    private readonly StreamWriter _logWriter;

    /// <summary>
    /// Создать объект.
    /// </summary>
    /// <param name="fileName">Имя файла логов.</param>
    public Logger(string fileName)
    {
      _logFile = new FileStream(fileName, FileMode.Append);
      _logWriter = new StreamWriter(_logFile);
    }

    /// <summary>
    /// Деструктор.
    /// </summary>
    //~Logger()
    //{
    //  Dispose(false);
    //}

    /// <summary>
    /// Записать строку в файл.
    /// </summary>
    /// <param name="data">Строка.</param>
    public void WriteString(string data)
    {
      _logWriter.WriteLine(data);
      _logWriter.Flush();
    }

    /// <summary>
    /// Освободить ресурсы объекта.
    /// </summary>
    /// <param name="disposing">Признак, необходимо ли чистить управляемые ресурсы.</param>
    private void Dispose(bool disposing)
    {
      if (this._disposed)
        return;

      if (disposing)
      {
        _logWriter.Close();
        _logFile.Close();
      }

      this._disposed = true;
    }

    /// <summary>
    /// Освободить ресурсы объекта.
    /// </summary>
    public void Dispose()
    {
      this.Dispose(true);
      //GC.SuppressFinalize(this);
    }
  }

}
