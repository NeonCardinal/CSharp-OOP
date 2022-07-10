using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for(int i = 0; i < input; i++)
            {
                var strs = Console.ReadLine().Split();
                Person person = new Person(strs[0], strs[1], int.Parse(strs[2]));
                persons.Add(person);
            }

            persons.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList().ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
