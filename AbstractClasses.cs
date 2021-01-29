using System;
using System.Collections.Generic;

namespace CSharpIntermediate 
{
  // abstract members (like methods) can't include implementation.
  // i.e. public abstract void Draw(); no function body.
  // if a member is declared as abstract, containing class needs to be abstract too.
  // derived classes must implement all abstract members in the base abstract class.
  // abstract classes cannot be instantiated.
  public abstract class AbstractShape
  {
    public int Width { get; set; }
    public int Height { get; set; }

    public abstract void Draw();

    public void Copy()
    {
      System.Console.WriteLine("Copied shape.");
    }

    public void Select()
    {
      System.Console.WriteLine("Copied shape.");
    }

    public static void createAbstract()
    {
      var sphere = new Sphere();
      sphere.Draw();

      var cube = new Cube();
      cube.Draw();
    }
  }

  public class Sphere : AbstractShape
  {
    public override void Draw()
    {
      System.Console.WriteLine("draw a sphere.");
    }
  }

  public class Cube : AbstractShape
  {
    public override void Draw()
    {
      System.Console.WriteLine("draw a cube.");
    }
  }

}