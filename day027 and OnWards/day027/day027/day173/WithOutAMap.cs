public class Kata
{
    public static int[] Maps(int[] x)
    {
        for (int i = 0; i < x.Length; i++)
        {
            int doubleXValue = x[i] * 2;
            x[i] = doubleXValue;
        }
        return x;
    }
}