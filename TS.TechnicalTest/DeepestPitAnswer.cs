namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        var pits = new List<Tuple<int, int, int>>();
        var firstHigh = points[0];
        var low = 0;
        var secondHigh = 0;
        var isInPit = false;

        for (var c=1; c<points.Length; c++)
        {
            if (points[c] > firstHigh && !isInPit && points[c] > 0)
            {
                firstHigh = points[c];
                low = points[c];
            }
            else if (points[c] < low)
            {
                low = points[c];
                secondHigh = points[c];
                isInPit = true;
            }
            else if (points[c] > secondHigh && isInPit)
            {
                secondHigh = points[c];
                var pit = new Tuple<int, int, int>(firstHigh, low, secondHigh);
                pits.Add(pit);

                if (c+1 < points.Length && points[c+1] < points[c] && points[c] > 0)
                {
                    isInPit = false;
                    firstHigh = points[c];
                }
            }
        }

        if (pits.Count == 0)
        {
            return -1;
        }

        var deepestPit = Math.Min(pits[0].Item1 - pits[0].Item2, pits[0].Item3 - pits[0].Item2);
        foreach (var pit in pits)
        {
            var minDiff = Math.Min(pit.Item1-pit.Item2, pit.Item3-pit.Item2);

            if (deepestPit < minDiff)
            {
                deepestPit = minDiff;
            }
        }
        
        return deepestPit;
    }
}
