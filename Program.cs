using System;

namespace helloWorld
{
    public class DrinksMachine
    {
        private int age;
        private string make;
        // A get property accessor is used to return the property value
        // A set accessor is used to assign a new value. (Omitting this property makes it read only)
        // A value keyword is used to define the "value" being assigned by the set accessor.
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Make
        {
            get
            {
                return make;
            }
            set
            { 
                make = value;
            }
        }
        
        // auto-implemented property
        public string Model { get; set; }

        public DrinksMachine(int age)
        {
            this.Age = age;
        }
        public DrinksMachine(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }
        public DrinksMachine(int age, string make, string model)
        {
            this.Age = age;
            this.Make = make;
            this.Model = model;
        }
    }
}
