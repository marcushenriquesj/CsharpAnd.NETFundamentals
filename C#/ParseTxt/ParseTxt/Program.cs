using System.Xml;

namespace Parsetxt;

class program
{
    public static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("People.txt");
        IEnumerable<Person> people = GenerateEnumPeople(lines);

        foreach (Person person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }

        Console.WriteLine($"Average Age: {people.Average(p => p.Age)}");

    }

    public static IEnumerable<Person> GenerateEnumPeople(string[] lines)
    {
        List<Person> list = new List<Person>();
        foreach(var line in lines)
        {

            string[] nameAndAge = line.Split(',');
            if (nameAndAge.Length == 2)
            {
                if (int.TryParse(nameAndAge[1], out int age))
                {
                    string name = nameAndAge[0];
                    list.Add(new Person(name, age));
                }
                else
                {
                    //invalid age
                }
            }
            else
            {
                //invalid line
            }
            
        }

        return list;

    }
}

public record Person(string Name, int Age);

