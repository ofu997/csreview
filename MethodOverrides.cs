using System;
using System.Collections.Generic;

namespace CSharpIntermediate 
{
  public class Canvas
  {
    public void DrawShapes(List<ShapeWithMethodOverride> shapes)
    {
      foreach (var shape in shapes)
      {
        shape.Draw();
      }
    }

    public static void createShapes()
    {
      var shapes = new List<ShapeWithMethodOverride>();
      shapes.Add( new Circle());
      shapes.Add( new Rectangle()); 

      var canvas = new Canvas();
      canvas.DrawShapes(shapes); 
    }
    public void Draw()
    {

    }
  }

  public class ShapeWithMethodOverride
  {
    public int Width { get; set; }
    public int Height { get; set; }
    // public Position  Position { get; set; }
    // public ShapeType Type { get; set; }

    public virtual void Draw()
    {

    }
  }

  public class Circle : ShapeWithMethodOverride
  {
    public override void Draw()
    {
      // base.Draw(); 
      System.Console.WriteLine("Draw a CIRCLE");
    }
  }

  public class Rectangle : ShapeWithMethodOverride 
  {
    public override void Draw()
    {
      // base.Draw(); 
      System.Console.WriteLine("Draw a RECTANGLE");
    }
  }
  
  public class Position
  {

  }
}