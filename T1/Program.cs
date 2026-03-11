namespace T1;

class StatisticsHelper
{


    public static void Main(string[] args)
    { 
        
    }
    
    
    public static double CalculateAverage(int[] values)
    {
        int avg = values[0];
        foreach (var num in values)
        {
            avg += num;
        }
        return avg / values.Length;
    }
}