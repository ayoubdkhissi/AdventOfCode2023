using AdventOfCode2023;

// read file from current path(not from bin folder) as array of strings (each line represents a string)


Console.WriteLine($"Answer to day 1 part 1: {Day1.Part1(File.ReadAllLines("input-day1.txt"))}");
Console.WriteLine($"Answer to day 1 part 2: {Day1.Part2(File.ReadAllLines("input-day1.txt"))}");
Console.WriteLine($"Answer to day 2 part 1: {Day2.Part1(File.ReadAllLines("input-day2.txt"))}");
Console.WriteLine($"Answer to day 2 part 2: {Day2.Part2(File.ReadAllLines("input-day2.txt"))}");

