namespace T1;

class StatisticsHelper
{


    public static void Main(string[] args)
    { 
        
    }
    
    public static double CalculateAverage(int[] values)
    {
        int avg = 0;
        foreach (var num in values)
        {
            avg += num;
        }
        return avg / values.Length;
    }
    
    public static int CalculateMax(int[] values){int max = values[0];
        foreach (var num in values)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }
}