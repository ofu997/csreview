using System;
using System.Collections.Generic;

namespace CSharpIntermediate 
{
  public class Buyer
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public void Promote()
    {
      var rating = CalculateRating(excludeOrders: true);
      if (rating ==0)
        System.Console.WriteLine("Promoted to level 1.");
      else  
        System.Console.WriteLine("Promoted to level 2.");
    }
    // A protected member is accessible within its class and by derived class instances.
    // A protected member of a base class is accessible in a derived class only if the access occurs through the derived class type.
    protected int CalculateRating(bool excludeOrders)
    {
      return 0;
    }

  }

  public class Test
  {
    public int Id { get; set; }
  }

  public class GoldBuyer : Buyer
  {
    public void OfferVoucher()
    {
      var rating = this.CalculateRating(true);
    }
  }
  public class Vehicle
  {
    private readonly string _registrationNumber;
    public Vehicle()
    {
        System.Console.WriteLine("Vehicle is being initialized.");
    }

    public Vehicle(string registrationNumber)
    {
        _registrationNumber = registrationNumber; 
        System.Console.WriteLine("Vehicle is being initialized. {0}", _registrationNumber);
    }
  }

  public class Automobile : Vehicle 
  {
    // Creates Vehicle with registrationNumber, then Automobile with registrationNumer
    public Automobile(string registrationNumber)
      : base(registrationNumber)
    {
        System.Console.WriteLine("Car is being initialized. {0}", registrationNumber);
    }
  }
}