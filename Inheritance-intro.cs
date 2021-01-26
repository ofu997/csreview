using System;
using System.Collections.Generic;

namespace CSharpIntermediate 
{
  public class Element
  {
    // properties and methods must be public to be inheritable
    // Inheritance benefits: code reuse, polymorphic behavior
    public int Width { get; set; }
    public  int Height { get; set; }

    public void Copy()
    {
      System.Console.WriteLine("Object copied.");
    }

    public void Duplicate()
    {
      System.Console.WriteLine("Object duplicated.");
    }
  }

  public class Text : Element
  {
    public int FontSize { get; set; }
    public string FontName { get; set; }

    public void AddHyperlink(string url) 
    {
      System.Console.WriteLine("We added a link to: " + url);
    }
  }
}