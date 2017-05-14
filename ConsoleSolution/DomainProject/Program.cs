using System;
using System.Reflection;
using System.Runtime.Remoting;

namespace DomainProject
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Assembly assembly = Assembly.LoadFile("c:/Users/alex/Desktop/.NET/ConsoleSolution/DomainProject/bin/Debug/OldVersion/ReflectionProject.dll");
      AppDomain domain = AppDomain.CreateDomain("First Domain");
      string typeName = typeof().FullName;

      ObjectHandle handle = domain.CreateInstance(assembly.GetName().Name, typeName);         
      var printer = handle.Unwrap() as NewVersion::ReflectionProject.PropertiesPrinter;
      printer.Print();                                         

      Console.WriteLine("\n\nDone\n\n");


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
