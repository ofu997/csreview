using System;
using System.Collections.Generic;

namespace CSharpIntermediate 
{
  // an example of how to use constructor overloading
  public class Customer
  {
    public int Id;
    public string Name;
    public readonly List<Order> Orders;

    public Customer()
    {
      Orders = new List<Order>();
    }

    public Customer(int id)
      : this()
    {
      this.Id = id;
    }

    public Customer(int id, string name)
      : this(id)
    {
      this.Name = name;
    }

    public void Promote()
    {

    }
  }

  // var myCustomer = new Customer { Id=3, Name="Francine"}

  // System.Console.WriteLine(myCustomer.Name);
}

// Notes: this() imports the constructor specified by what's inside the ()

// we can also use public List<Order> Orders = new List<Order>(); and get rid of default constructor

// readonly: can only be assigned once