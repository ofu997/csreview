using System;
using System.Collections.Generic;
using System.Collections;

namespace CSharpIntermediate 
{
  public class BoxingAndUnboxing
  {
    public static void boxingExamples()
    {
      // boxing 
      int number = 10;
      object obj = number;

      // unboxing
      object obj2 = 10;
      int number2 = (int) obj; 

      var list = new ArrayList();
      // Add takes object. Adding value type like 1 causes 'boxing', which has a performance penalty
      list.Add(1);
      // string type is a reference, doesn't cause 'boxing'
      list.Add("me");
      // structure is a value type, causes 'boxing' 
      list.Add(DateTime.Today);

      // can't cast
      var number3 = (int) list[1];

      var anotherList = new List<int>();
      var names = new List<string>();
      names.Add("nn"); 
    }

    public static void castingUpAndDownExamples()
    {
      Writing writing = new Writing();
      // Upcasting example. 
      Shape shape = writing; 

      writing.Width = 200; 
      shape.Width = 100; 
      // 100
      System.Console.WriteLine(writing.Width);

      // Downcasting example
      // shape2 is of type Writing
      Shape shape2 = new Writing();
      // convert shape2 to type Writing
      Writing writing2 = (Writing) shape2; 
    }
  }
}