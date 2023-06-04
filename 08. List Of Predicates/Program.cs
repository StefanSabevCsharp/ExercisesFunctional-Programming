int maxNum = int.Parse(Console.ReadLine());
int[] dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
List<int> list = new List<int>();
for (int i = 1; i <= maxNum; i++)
{
  Func<int, bool> func = num => i % num == 0;
    if (dividers.All(func))
    {
        list.Add(i);
    }

}





Console.WriteLine(string.Join(" ",list));