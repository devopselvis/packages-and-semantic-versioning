using System;

namespace MickeysAwesomePackage
{
  public class Calculator
  {
    public static int Add(int a, int b)
    {
      return a + b;
    }

    public static int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
        return a / b;
    }
  }
}