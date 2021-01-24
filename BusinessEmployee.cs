using System;
using System.Collections.Generic;
namespace CSharpIntermediate
{
  class BusinessEmployee : Employee
  {
    // Creates double variable called "bonusBudget" and assigns value to 1000
    public double bonusBudget = 1000;    
    // This method returns the toString() method - which is the employee's ID number and name - and prints the bonus budget
    public override String employeeStatus()
    {
        return toString() + " with a budget of " + this.bonusBudget;
    }    
    // Calls upon base-class (Employee Class) constructor from within derived class (BusinessEmployee Class)
    // Sets baseSalary to 50000 for all BusinessEmployee objects
    public BusinessEmployee(String name) : base(name, 50000)
    {
    }
  } // class BusinessEmployee
}