int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Func<int[], int> minFunc = numbers => numbers.Min();
int number = minFunc(numbers);
Console.WriteLine(number);