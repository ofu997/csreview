using System;
using System.Collections.Generic;

namespace CSharpIntermediate 
{
  public class Person
  {
    public string Name { get; set; }
    // read-only birthdate
    public DateTime Birthdate { get; private set; }

    public Person(DateTime birthdate) 
    {
      this.Birthdate = birthdate; 
    }

    public int Age 
    {
      get
      {
        var timeSpan = DateTime.Today - Birthdate;
        var years = timeSpan.Days/365;
        return years;
      }
    }

    public static void createPerson()
    {
      var myPerson = new Person(new DateTime (1933, 1,22));
      // myPerson.Birthdate = new DateTime(1933, 1, 22);h
      System.Console.WriteLine(myPerson.Age);
    }
  }
  public class PersonWithManualGetterAndSetter 
  {
    private DateTime _birthdate;

    public void SetBirthdate(DateTime birthdate)
    {
      _birthdate = birthdate; 
    }

    public DateTime GetBirthdate()
    {
      return _birthdate;
    }

    public static void personWithAccessModifiers()
    {
      var person = new PersonWithManualGetterAndSetter();
      person.SetBirthdate(new DateTime(1982, 1, 1));
      System.Console.WriteLine(person.GetBirthdate());
    }
  }
}