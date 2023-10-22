using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.ArcadeGame;

public class ArcadeGame
{
    /*
     * Complete the 'climbingLeaderboard' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY ranked
     *  2. INTEGER_ARRAY player
     */

    public static List<int> ClimbingLeaderboard(List<int> ranked, List<int> player)
    {

        List<int> result = new List<int>();
        ranked = ranked.Distinct().OrderByDescending(o => o).ToList();
        //int n = ranked.Count;
        //int m = player.Count;

        foreach (int i in player)
        {
            if (!ranked.Contains(i))
            {
                ranked.Add(i);
            }

            result.Add(ranked.Distinct().OrderByDescending(o => o).ToList().FindIndex(f => f == i) + 1);
        }

        //foreach (int i in player)
        //{
        //    if (!ranked.Contains(i)) 
        //    { 
        //        ranked.Add(i); 
        //    }

        //    ranked = ranked.Distinct().OrderByDescending(o => o).ToList();
        //}

        return result;

    }
}
