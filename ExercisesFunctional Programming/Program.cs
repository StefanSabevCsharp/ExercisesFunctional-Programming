string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Action<string> action = name => Console.WriteLine(name);
foreach (var name in names)
{
    action(name);
}
