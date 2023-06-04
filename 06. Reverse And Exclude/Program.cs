int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int n = int.Parse(Console.ReadLine());
Func<int,bool> predicate = number => number % n != 0;
 numbers = numbers.Reverse().Where(predicate).ToArray();
Console.WriteLine(string.Join(" ",numbers));