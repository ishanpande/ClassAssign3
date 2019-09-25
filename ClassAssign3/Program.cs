using System;

namespace ClassAssign3
{
    class Person
    {
        string firstName;
        string lastName;

        string getName()
        {
            return firstName + " " + lastName;
        }

        public Person()
        {
            firstName = "John";
            lastName = "Doe";
        }

        
    }
}

