int[] numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
string command = Console.ReadLine();
Predicate<int> predicate = command switch
{
    "odd" => number => number % 2 != 0,
    "even" => number => number % 2 == 0,
    _ => null
};
List<int> result = new List<int>();
for (int i = numbers[0]; i <= numbers[1]; i++)
{
    if (predicate(i))
    {
        result.Add(i);
    }
}   
Console.WriteLine(string.Join(" ",result));