using System;
using System.Collections.Generic;
using System.Threading;
namespace csreview
{
  class ImplementInterface
  {
    public static void EmployeeSimulation()
    {
      // Instantiates TechnicalEmployee Object with name Fido and salary 2000 called employee1
      var employee1 = new TechnicalEmployee("Fido");
      // Instantiates TechnicalEmployee Object with name Ryder called employee2
      var employee2 = new TechnicalEmployee("Ryder");
      // Instantiates BusinessEmployee Object with name CoconutRiceBear called employee3
      var employee3 = new BusinessEmployee("CoconutRiceBear");
      // Output to the console window
      Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());      
    }
  }
}