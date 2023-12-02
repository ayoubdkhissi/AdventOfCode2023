namespace AdventOfCode2023;
public static class Day2
{
    public static int Part1(string[] input)
    {
        return input
            .Select(line => new Game(line))
            .Where(g => g.Possible)
            .Sum(g => g.Id);
    }
}


public class Game
{
    public int Id { get; set; }
    public int MaxBlues { get; set;}
    public int MaxReds { get; set; }
    public int MaxGreens { get; set; }
    public bool Possible { get; set; }
    public Game(string line)
    {
        Id = int.Parse(line.Substring(5, line.IndexOf(':') - 5));
        MaxBlues = GetMaxByColor('b', line);
        MaxReds = GetMaxByColor('r', line);
        MaxGreens = GetMaxByColor('g', line);
        Possible = MaxReds <= MaxPossibleReds &&
                   MaxGreens <= MaxPossibleGreens &&
                   MaxBlues <= MaxPossibleBlues;
    }
    private int GetMaxByColor(char color, string line)
    {
        return line
            .Select((c, index) =>
            c == color ? int.Parse(line.Substring(index - 3, 2)) : -1)
            .Where(item => item != -1)
            .Max();
    }

    private static int MaxPossibleReds = 12;
    private static int MaxPossibleGreens = 13;
    private static int MaxPossibleBlues = 14;

}
