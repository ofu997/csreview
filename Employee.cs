using System;
using System.Collections.Generic;
using System.Threading;
namespace CSharpIntermediate
{
  abstract class Employee
  {
    // abstract classes can't be instantiated.  

    // Creates integer variable called "employeeCount" and assigns value to 1
    private static int employeeCount = 1;    
    private string employeeName;
    private double employeeBaseSalary;
    private int employeeId;
    // Public properties
    public string Name
    {
        get
        {
            return employeeName;
        }

        set
        {
            employeeName = value;
        }
    }
    public double BaseSalary
    {
        get
        {
            return employeeBaseSalary;
        }

        set
        {
            employeeBaseSalary = value;
        }
    }
    public int ID
    {
        get
        {
            return employeeId;
        }

        set
        {
            employeeId = value;
        }
    }    
    // Constructor
    public Employee(String name, double baseSalary)
    {
      this.Name = name;
      this.BaseSalary = baseSalary;
      this.ID = employeeCount++;
    }
    // returns the employee's base salary    
    public double getBaseSalary()
    {
      return this.BaseSalary;
    }
    // This method returns the employee's name
    public String getName()
    {
      return this.Name; 
    }
    // returns the employee's ID
    public int getEmployeeID()
    {
      return this.ID;
    }
    // returns the employee's ID and Name
    public String toString()
    {
      return this.ID + " " + this.Name;
    }

    // This method returns the employee's ID and Name and confirms that the employee is in the system
    // virtual: can be overridden
    // abstract: forces sub classes to implement, while base method body is undefined
    public abstract String employeeStatus();
  } // class Employee
}