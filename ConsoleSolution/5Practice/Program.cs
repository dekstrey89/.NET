using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Practice
{
  /// <summary>
  /// Тип прав.
  /// </summary>
  [Flags, Serializable]
  public enum AccessRights : byte
  {
    /// <summary>
    /// Просмотр.
    /// </summary>
    View = 1,

    /// <summary>
    /// Выполнение.
    /// </summary>
    Run = 2,

    /// <summary>
    /// Добавление.
    /// </summary>
    Add = 4,

    /// <summary>
    /// Изменение.
    /// </summary>
    Edit = 8,

    /// <summary>
    /// Утверждение.
    /// </summary>
    Ratify = 16,

    /// <summary>
    /// Удаление.
    /// </summary>
    Delete = 32,

    /// <summary>
    /// Нет доступа.
    /// </summary>
    /// <remarks>
    /// Этот флаг имеет максимальный приоритет.
    /// Если он установлен, остальные флаги игнорируются 
    /// </remarks>
    AccessDenied = 64
  }

  class Program
  {
    /// <summary>
    /// Метод, показывающий перечень разрешенных действий для указанного типа прав доступа.
    /// </summary>
    /// <param name="right">Право доступа.</param>
    private static void PrintAvailableActions(AccessRights right)
    {
      if (right == AccessRights.AccessDenied)
      {
        Console.WriteLine("Нет разрешенных операций.");
      }
      else
      {
        foreach (var ar in Enum.GetValues(typeof(AccessRights)))
        {
          if ((byte)ar <= (byte)right)
          {
            Console.WriteLine(ar);
          }
        }
      }
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Проверка доступных действий для права {0}:",AccessRights.View);
      PrintAvailableActions(AccessRights.View);

      Console.WriteLine("\nПроверка доступных действий для права {0}:", AccessRights.Add);
      PrintAvailableActions(AccessRights.Add);

      Console.WriteLine("\nПроверка доступных действий для права {0}:", AccessRights.Delete);
      PrintAvailableActions(AccessRights.Delete);

      Console.WriteLine("\nПроверка доступных действий для права {0}:", AccessRights.AccessDenied);
      PrintAvailableActions(AccessRights.AccessDenied);

      Console.ReadKey();
    }
  }
}
