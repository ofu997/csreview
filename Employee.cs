using System;
using System.Collections.Generic;
using System.Threading;
namespace csreview
{
  class Employee
  {
    private string employeeName;
    private double employeeBaseSalary;
    private int employeeId;

    // Creates integer variable called "employeeCount" and assigns value to 1
    private static int employeeCount = 1;

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
    public virtual String employeeStatus()
    {
      return toString() + " is in the the company's system";
    }
  } // class Employee
}