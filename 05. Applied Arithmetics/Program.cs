﻿int[] numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
string command = Console.ReadLine();
while (command != "end")
{
    switch (command)
    {
        case "add":
            numbers = numbers.Select(n => n + 1).ToArray();
            break;
        case "multiply":
            numbers = numbers.Select(n => n * 2).ToArray();
            break;
        case "subtract":
            numbers = numbers.Select(n => n - 1).ToArray();
            break;
        case "print":
            Console.WriteLine(string.Join(" ",numbers));
            break;
    }
    command = Console.ReadLine();
}