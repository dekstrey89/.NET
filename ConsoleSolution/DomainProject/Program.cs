using System;
using System.Reflection;
using System.Runtime.Remoting;

namespace DomainProject
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      var oldAssembly = Assembly.LoadFile(@"c:\Users\Vyatchanin_AS\Desktop\.NET\ConsoleSolution\DomainProject\bin\Debug\OldVersion\ReflectionProject.dll");

      foreach (var type in oldAssembly.GetExportedTypes())
      {
        var c = Activator.CreateInstance(type);
        type.InvokeMember("Print", BindingFlags.InvokeMethod, null, c, null);
      }

      Console.WriteLine("\n\n");

      var newAssembly = Assembly.LoadFile(@"c:\Users\Vyatchanin_AS\Desktop\.NET\ConsoleSolution\DomainProject\bin\Debug\NewVersion\ReflectionProject.dll");

      foreach (var type in newAssembly.GetExportedTypes())
      {
        var c = Activator.CreateInstance(type);
        type.InvokeMember("Print", BindingFlags.InvokeMethod, null, c, null);
      }


      //Assembly assembly2 = Assembly.Load("ReflectionProject2");
      //AppDomain domain2 = AppDomain.CreateDomain("Second Domain");
      //string typeName2 = typeof(PropertiesPrinter).FullName;

      //ObjectHandle handle2 = domain2.CreateInstance(assembly2.GetName().Name, typeName2);
      //var printer2 = handle2.Unwrap() as PropertiesPrinter;
      //printer2.Print();

      Console.ReadKey();
    }
  }
}
