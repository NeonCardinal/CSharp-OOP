using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for(int i = 0; i < n; i++)
            {
                var strs = Console.ReadLine().Split();
                Person person = new Person(strs[0], strs[1], int.Parse(strs[2]), decimal.Parse(strs[3]));
                persons.Add(person);
            }

            decimal percentage = decimal.Parse(Console.ReadLine());

            persons.ForEach(p => p.IncreaseSalary(percentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
