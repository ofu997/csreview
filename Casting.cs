using System;
using System.Collections.Generic;

namespace CSharpIntermediate 
{
  public class Shape
  {
    public int Width { get; set; }  
    public int Height { get; set; }
    public int X  { get; set; }
    public int Y { get; set; }

    public void Draw()
    {

    }
  }

  public class Writing : Shape
  {
    public int FontSize { get; set; }
    public string FontName { get; set; }
  }

}