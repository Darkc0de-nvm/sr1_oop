using System.Linq;

public class Matrix
{
    private readonly int[][] rows;

    public Matrix(string input)
    {
        rows = input
            .Split('\n')
            .Select(line => line.Split(' ').Select(int.Parse).ToArray())
            .ToArray();
    }

    public int[] Row(int row) => rows[row - 1];

    public int[] Column(int col) => rows.Select(r => r[col - 1]).ToArray();
}