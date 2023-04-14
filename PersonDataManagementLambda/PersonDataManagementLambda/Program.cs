using System;

namespace PersonDataManagementLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                Person Data Management
                - Create Person class with SSN,Name, Address and Age fields
                - Create variable for List of Person
                    class in Main method
                UC 1 - Add default values in created list
             */
            List<Person> personList = new List<Person>();

            // add default values
            personList.Add(new Person { SSN = "123-45-6789", Name = "John Doe", Address = "123 Main St", Age = 30 });
            personList.Add(new Person { SSN = "987-65-4321", Name = "Jane Smith", Address = "456 Elm St", Age = 25 });
            personList.Add(new Person { SSN = "555-55-5555", Name = "Bob Johnson", Address = "789 Oak St", Age = 40 });

           
        }
    }
}