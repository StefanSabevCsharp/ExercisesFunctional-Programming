string[] listOfPeople = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
List<Person> persons = new List<Person>();
for (int i = 0; i < listOfPeople.Length; i++)
{
    Person person = new Person(listOfPeople[i], listOfPeople[i].Length);
    persons.Add(person);
}

string command = Console.ReadLine();
string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

while (command != "Party!")
{
    string action = commandArgs[0];
    string condition = commandArgs[1];
    string value = commandArgs[2];
    

    Predicate<Person> filterStart = p => p.Name.StartsWith(value);
    Predicate<Person> filterEnd = p => p.Name.EndsWith(value);
    Predicate<Person> filterLenght = p => p.Lenght == int.Parse(value);

    Func<Person,bool> filterStart1 = p => p.Name.StartsWith(value);
    Func<Person,bool> filterEnd2 = p => p.Name.EndsWith(value);
    Func<Person,bool> filterLenght3 = p => p.Lenght == int.Parse(value);

    if (action == "Remove")
    {
        if(condition == "StartsWith")
        {
            persons.RemoveAll(filterStart);
        }
        else if(condition == "EndsWith")
        {
            persons.RemoveAll(filterEnd);
        }
        else if(condition == "Length")
        {
            persons.RemoveAll(filterLenght);
        }
        
    }
    else if(action == "Double")
    {
        List<Person> filteredPersons = new List<Person>();
        if (condition == "StartsWith")
        {
            filteredPersons = persons.Where(filterStart1).ToList();
        }
        else if (condition == "EndsWith")
        {
            filteredPersons = persons.Where(filterEnd2).ToList();
        }
        else if (condition == "Length")
        {
            filteredPersons = persons.Where(filterLenght3).ToList();
        }

        foreach (var person in filteredPersons)
        {
            int index = persons.IndexOf(person);
            persons.Insert(index, person);
        }
    }

    command = Console.ReadLine();
    commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
}


if (persons.Count == 0)
{
    Console.WriteLine("Nobody is going to the party!");
    return;
}
Console.WriteLine($"{string.Join(", ", persons.Select(p => p.Name))} are going to the party!");
class Person
{
    public string Name { get; set; }
    public int Lenght { get; set; }
    public Person(string name, int lenght)
    {
        Name = name;
        Lenght = lenght;
    }
}