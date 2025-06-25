using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class User
{
    public int rank;
    public int progress;

    public Dictionary<int, int> indexes = new();

    public User(int rank = -8, int progress = 0)
    {
        this.rank = rank;
        this.progress = progress;
        for (int i = 0; i < 16; i++)
        {
            indexes[i - 8 < 0 ? i - 8 : i - 7] = i;
        }
    }

    public void incProgress(int actRank)
    {
        Console.WriteLine($"Rank: {rank}");
        Console.WriteLine($"Actual rank: {actRank}");
        Console.WriteLine($"Progress: {progress}");
        if (actRank < -8 || actRank > 8 || actRank == 0) throw new ArgumentException();

        int difference = Math.Abs(indexes[actRank] - indexes[rank]);
        int prog = 0;
        if (difference == 0) prog = 3;
        else if (indexes[actRank] < indexes[rank]) prog = 1;
        else prog = 10 * difference * difference;

        progress += prog;

        if (progress == 1) progress--;

        while (progress >= 100 && rank < 8 && rank >= -8)
        {
            progress -= 100;
            rank++;
            if (rank == 0) rank++;
        }

        if (rank == 8) progress = 0;
    }
}
