using System;
using System.Collections.Generic;

namespace CSharpIntermediate 
{
  public class Calculator 
  {
    public static int Add(params int[] numbers) 
    {
      var sum = 0;
      foreach( var number in numbers)
      {
        sum += number;
      }

      return sum; 
    }
    public static void useParams()
    {
      // var calculator = new Calculator();
      Console.WriteLine(Calculator.Add(1,2,3,4));   
    }
  }

  public class Point
  {
    public int X;
    public int Y;

    public Point(int x, int y) 
    {
      this.X = x;
      this.Y = y; 
    }

    public void Move(int x, int y) 
    {
      this.X = x; 
      this.Y = y; 
    }

    public void Move(Point newLocation) 
    {
    //   this.X = newLocation.X;
    //   this.Y = newLocation.Y; 

      if (newLocation == null) 
        throw new ArgumentNullException("newLocation");

      Move(newLocation.X, newLocation.Y);
    }

    public static void UsePoints()
    {
      try
      {
        var point = new Point(10, 20);
        point.Move(new Point(40, 60));
        Console.WriteLine("point is at ({0}, {1})", point.X, point.Y);
      }
      catch (Exception)
      {
        System.Console.WriteLine("An unexpected error occurred.");
      }
    }
  }
}