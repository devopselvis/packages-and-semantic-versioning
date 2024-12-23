using System;
using MickeysAwesomePackage;

namespace TestApp
{
  class Program
  {
    static void Main(string[] args)
    {
      var result = Calculator.Add(2, 3);
      Console.WriteLine($"2 + 3 = {result}");
    }
  }
}