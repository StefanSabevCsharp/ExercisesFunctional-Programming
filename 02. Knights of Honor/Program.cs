string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
string title = "Sir";
Action<string> action = name => Console.WriteLine($"{title} {name}");
foreach (var name in names)
{
    action(name);
}