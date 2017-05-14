using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//[assembly: AssemblyVersion("1.0.1.0")]

[assembly: AssemblyVersion("1.0.2.0")]

namespace ReflectionProject
{
  public class PropertiesPrinter : MarshalByRefObject
  {
    /// <summary>
    /// Возвращает имена всех свойств объекта и строковые представления значений свойств.
    /// </summary>
    public void Print()
    {
      // First version.
      //var date = DateTime.Now;

      // Second version.
      var date = DateTime.Now.AddDays(7.0);

      var type = date.GetType();
      var properties = type.GetProperties();

      foreach (var property in properties)
      {
        Console.WriteLine("{0, 20} {1, 12}:  {2}", property.PropertyType, property.Name, property.GetValue(date));
      }
    }
  }
}
