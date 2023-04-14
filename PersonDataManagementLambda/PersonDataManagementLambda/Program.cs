using System;
using System.Collections.Generic;

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
            personList.Add(new Person { SSN = "123-45-6789", Name = "Nikhil", Address = "123 Nashik", Age = 30 });
            personList.Add(new Person { SSN = "987-65-4321", Name = "Parbhu", Address = "456 Pune", Age = 25 });
            personList.Add(new Person { SSN = "555-55-5555", Name = "Prachi", Address = "789 Nagar", Age = 40 });

            //List<Person> personList = new List<Person>();


            //UC-02Retrieve top 2 records from the list for age is less than 60
            // retrieve top 2 records for age less than 60


            var topTwo = personList.Where(p => p.Age < 60)
                       .OrderByDescending(p => p.Age)
                       .Take(2)
                       .ToList();

            // display the top two records
            foreach (var person in topTwo)
            {
                Console.WriteLine("SSN: {0}", person.SSN);
                Console.WriteLine("Name: {0}", person.Name);
                Console.WriteLine("Address: {0}", person.Address);
                Console.WriteLine("Age: {0}", person.Age);
                Console.WriteLine();


            }
        }
    }
}