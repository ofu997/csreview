using System;
using System.Collections.Generic;
using System.Threading;
namespace csreview
{
  class TechnicalEmployee : Employee
  {
    public int successfulCheckIns = 5;
    // Calls upon base-class (Employee Class) constructor from within derived class (TechnicalEmployee Class)
    // Sets baseSalary to 75000 for all TechnicalEmployee objects
    public TechnicalEmployee(String name) : base(name, 75000)
    {

    }
    public override String employeeStatus()
    {
      return this.toString() + " has " + this.successfulCheckIns + "successful check-ins";
    }
  } // class TechnicalEmployee
}