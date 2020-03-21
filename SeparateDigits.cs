

using System;
using System.Collections.Generic;
using System.Threading;
namespace csreview
{
  class SeparateDigits{
    static void separateDigits(int n)
    {
        if (n < 10)
        {
            Console.Write("{0}  ", n);
            return;
        }
        separateDigits(n / 10);
        Console.Write(" {0} ", n % 10);
    }
  }
}