int n = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

Func<string,bool> func = name => name.Length <= n;
names = names.Where(func).ToArray();
Console.WriteLine(string.Join(Environment.NewLine,names));