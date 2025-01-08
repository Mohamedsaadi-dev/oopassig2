using System;
using System.Drawing;

namespace oopassig2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PERSON
            Person[] persons = new Person[3];

            persons[0] = new Person("MOHAMED", 25);
            persons[1] = new Person("ZEO", 30);
            persons[2] = new Person("AMR", 35);
            foreach (var person in persons)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
            #endregion
            #region point
            
            Point ReadPoint(string pointName)
            {
                Console.WriteLine($"Enter coordinates for {pointName}:");
                Console.Write("X: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Y: ");
                double y = double.Parse(Console.ReadLine());
               
            }
            Point point1 = ReadPoint("Point 1");
            Point point2 = ReadPoint("Point 2");

            
            double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));

            
            Console.WriteLine($"The distance between Point 1 and Point 2 is: {distance:F2}");
            #endregion
            #region Q3
            Person ReadPerson(int index)
            {
                Console.WriteLine($"Enter details for Person {index + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                return new Person(name, age);
            }

            Person[] persons = new Person[3];

            
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = ReadPerson(i);
            }

            
            Person oldestPerson = persons[0];
            foreach (var person in persons)
            {
                if (person.Age > oldestPerson.Age)
                {
                    oldestPerson = person;
                }
            }
            Console.WriteLine($"The oldest person is {oldestPerson.Name} with age {oldestPerson.Age}.");




            #endregion

        }
    }
}
